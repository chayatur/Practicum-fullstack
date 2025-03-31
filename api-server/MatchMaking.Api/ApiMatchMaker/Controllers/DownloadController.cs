using MatchMakings.Core.IServices;
using MatchMakings.Core.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using MatchMakings.Core.Models;

namespace MatchMakings.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        private readonly IMaleService _maleService;
        private readonly IWomenService _femaleService;
        private readonly IAuthService _authService;

        public ResumeController(IMaleService maleService, IWomenService femaleService, IAuthService authService)
        {
            _maleService = maleService;
            _femaleService = femaleService;
            _authService = authService;
        }

        [HttpGet("download-resume")]
        public async Task<IActionResult> DownloadResume()
        {
            var userDto = await GetCurrentUserAsync();
            if (userDto == null) return Unauthorized("לא מחובר.");
            var role = userDto.Role;

            using var package = new ExcelPackage();
            var worksheet = package.Workbook.Worksheets.Add("Resume");
            worksheet.Cells[1, 1].Value = "שדה";
            worksheet.Cells[1, 2].Value = "ערך";
            int row = 2;

            if (role == BaseUser.ERole.Male)
            {
                var males = await _maleService.GetListOfMaleAsync();
                foreach (var male in males)
                {
                    worksheet.Cells[row, 1].Value = "שם פרטי";
                    worksheet.Cells[row, 2].Value = male.FirstName;
                    row++;
                    worksheet.Cells[row, 1].Value = "שם משפחה";
                    worksheet.Cells[row, 2].Value = male.LastName;
                    row++;
                }
            }
            else if (role == BaseUser.ERole.Women)
            {
                var females = await _femaleService.GetListOfWomenAsync();
                foreach (var female in females)
                {
                    worksheet.Cells[row, 1].Value = "שם פרטי";
                    worksheet.Cells[row, 2].Value = female.FirstName;
                    row++;
                    worksheet.Cells[row, 1].Value = "שם משפחה";
                    worksheet.Cells[row, 2].Value = female.LastName;
                    row++;
                }
            }

            var stream = new MemoryStream();
            package.SaveAs(stream);
            stream.Position = 0;
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Resume.xlsx");
        }

        [HttpPost("upload-resume")]
        public async Task<IActionResult> UploadResume([FromForm] IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("לא נבחר קובץ.");

            // בדיקת MIME Type
            if (file.ContentType != "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                return BadRequest("נא להעלות קובץ Excel בלבד.");
            }

            // בדיקת שם הקובץ
            if (file.FileName != "Resume.xlsx")
            {
                return BadRequest("נא להעלות את קובץ הרזומה שהורדתם בשם 'Resume.xlsx'.");
            }

            // המשך הקוד להעלאה ל-S3 או עיבוד הקובץ...

            return Ok("הקובץ הועלה בהצלחה.");
        }

        private async Task<BaseUser> GetCurrentUserAsync()
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userIdString, out int userId))
            {
                return null; // או לזרוק שגיאה לפי הצורך
            }

            return await _authService.GetUserByIdAsync(userId);
        }
    }
}
