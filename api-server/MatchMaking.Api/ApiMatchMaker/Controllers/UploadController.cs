using Amazon.S3;
using Amazon.S3.Model;
using MatchMakings.Core.IServices;
using MatchMakings.Core.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.IO;
using System.Threading.Tasks;
using static MatchMakings.Core.Models.BaseUser;
using MatchMakings.Core.Models;

[Authorize]
[Route("api/upload")]
public class UploadController : ControllerBase
{
    private readonly IMaleService _maleService;
    private readonly IWomenService _femaleService;
    private readonly IAmazonS3 _s3Client;
    private const string BucketName = "resumesbuc";

    public UploadController(IMaleService maleService, IWomenService femaleService, IAmazonS3 s3Client)
    {
        _maleService = maleService;
        _femaleService = femaleService;
        _s3Client = s3Client;
    }

    [HttpPost("upload-resume")]
    public async Task<IActionResult> UploadResume([FromForm] IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest("לא נבחר קובץ.");

        // העלאת הקובץ ל-S3
        using (var stream = new MemoryStream())
        {
            await file.CopyToAsync(stream);
            stream.Position = 0;

            var putRequest = new PutObjectRequest
            {
                BucketName = BucketName,
                Key = file.FileName, // או כל מפתח אחר שתרצה
                InputStream = stream,
                ContentType = file.ContentType
            };

            await _s3Client.PutObjectAsync(putRequest);

            // קריאת הקובץ עם OfficeOpenXml
            stream.Position = 0; // לאפס את המיקום של הזרם
            using var package = new ExcelPackage(stream);
            var worksheet = package.Workbook.Worksheets[0];

            for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
            {
                var firstName = worksheet.Cells[row, 2].Text; // עמודה 2 - שם פרטי
                var lastName = worksheet.Cells[row, 4].Text; // עמודה 4 - שם משפחה
                var id = int.Parse(worksheet.Cells[row, 3].Text); // עמודה 3 - מזהה
                var username = worksheet.Cells[row, 7].Text; // עמודה 7 - שם משתמש (נניח)
                var role = worksheet.Cells[row, 8].Text == "male" ? ERole.Male : ERole.Women; // עמודה 8 - תפקיד

                var country = worksheet.Cells[row, 5].Text; // עמודה 5 - מדינה
                var city = worksheet.Cells[row, 6].Text; // עמודה 6 - עיר

                if (worksheet.Cells[row, 1].Text == "male")
                {
                    await _maleService.UpdateMaleAsync(id, new Male
                    {
                        Id = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Username = username,
                        Role = role,
                        Country = country,
                        City = city,
                    });
                }
                else if (worksheet.Cells[row, 1].Text == "female")
                {
                    await _femaleService.UpdateWomenAsync(id, new Women
                    {
                        Id = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Username = username,
                        Role = role,
                        Country = country,
                        City = city,
                    });
                }
            }
        }

        return Ok("הקובץ הועלה והנתונים עודכנו בהצלחה.");
    }
}