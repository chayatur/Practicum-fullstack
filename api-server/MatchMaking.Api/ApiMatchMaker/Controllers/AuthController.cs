// AuthController.cs
using AutoMapper;
using MatchMakings.Core.DTOs;
using MatchMakings.Core.IRepositories;
using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BCrypt.Net;

namespace ApiMatchMaker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IMaleRepository _maleUserRepository;
        private readonly IWomenRepository _femaleUserRepository;
        private readonly IMapper _mapper;

        public AuthController(IMaleRepository maleUserRepository, IWomenRepository femaleUserRepository, IMapper mapper, IAuthService authService)
        {
            _maleUserRepository = maleUserRepository;
            _femaleUserRepository = femaleUserRepository;
            _authService = authService;
            _mapper = mapper;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDto)
        {
            if (loginDto == null || string.IsNullOrEmpty(loginDto.Username) || string.IsNullOrEmpty(loginDto.Password))
            {
                return BadRequest("שם משתמש או סיסמה לא יכולים להיות ריקים.");
            }

            try
            {
                var user = await _authService.AuthenticateUserAsync(loginDto);
                if (user == null) return Unauthorized("שם משתמש או סיסמה שגויים");

                var token = await _authService.GenerateTokenAsync(user);
                return Ok(new { Token = token, Role = user.Role });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"שגיאה במהלך תהליך ההתחברות: {ex.Message}");
            }
        }

        [HttpPost("register-male")]
        public async Task<IActionResult> RegisterMale([FromBody] RegisterDTO registerDto)
        {
            if (registerDto == null || string.IsNullOrEmpty(registerDto.Username) || string.IsNullOrEmpty(registerDto.Password))
            {
                return BadRequest("שם משתמש או סיסמה לא יכולים להיות ריקים.");
            }

            var newUser = new Male
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Username = registerDto.Username,
                //PasswordHash = HashPassword(registerDto.Password),
                Role = BaseUser.ERole.Male
            };

            await _maleUserRepository.AddMaleAsync(newUser);
            var token = await _authService.GenerateTokenAsync(newUser);

            return Ok(new { Token = token, Message = "נרשמת בהצלחה!", User = newUser });
        }

        [HttpPost("register-female")]
        public async Task<IActionResult> RegisterFemale([FromBody] RegisterDTO registerDto)
        {
            if (registerDto == null || string.IsNullOrEmpty(registerDto.Username) || string.IsNullOrEmpty(registerDto.Password))
            {
                return BadRequest("שם משתמש או סיסמה לא יכולים להיות ריקים.");
            }

            var newUser = new Women
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Username = registerDto.Username,
               // PasswordHash = HashPassword(registerDto.Password),
                Role = BaseUser.ERole.Women
            };

            await _femaleUserRepository.AddWomenAsync(newUser);
            var token = await _authService.GenerateTokenAsync(newUser);

            return Ok(new { Token = token, Message = "נרשמת בהצלחה!", User = newUser });
        }
        //BCrypt לא מיבא טוב את 
        //private string HashPassword(string password)
        //{
        //    return BCrypt.Net.BCrypt.HashPassword(password);
        //}

        [HttpGet("admin-only")]
        [Authorize(Policy = "AdminOnly")]
        public IActionResult AdminOnly()
        {
            return Ok("This is accessible only by Admins.");
        }

        [HttpGet("shadchan-only")]
        [Authorize(Policy = "ShadchanOnly")]
        public IActionResult ShadchanOnly()
        {
            return Ok("This is accessible only by Matchmakers.");
        }

        [HttpGet("user-only")]
        [Authorize(Policy = "UserOnly")]
        public IActionResult UserOnly()
        {
            return Ok("This is accessible only by Users.");
        }
    }
}
