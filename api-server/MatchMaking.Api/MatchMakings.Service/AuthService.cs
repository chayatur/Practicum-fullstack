using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using MatchMakings.Core.DTOs;
using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
using MatchMakings.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using BCrypt.Net;

namespace MatchMakings.Service.Services
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;
        private readonly IConfiguration _config;

        public AuthService(DataContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public async Task<BaseUser> AuthenticateUserAsync(LoginDTO loginDto)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == loginDto.Username);

            if (user == null || !VerifyPassword(loginDto.Password, user.PasswordHash))
            {
                throw new UnauthorizedAccessException("Invalid username or password.");
            }

            return user;
        }
        private bool VerifyPassword(string password, string passwordHash)
        {
            // ודא שאתה משתמש בלוגיקה הנכונה להשוואת סיסמאות
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }
        public async Task<BaseUser> RegisterUserAsync(RegisterDTO registerDto)
        {
            var existingUser = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == registerDto.Username);

            if (existingUser != null)
            {
                throw new InvalidOperationException("User already exists!");
            }

            BaseUser user;

            switch (registerDto.Role.ToLowerInvariant())
            {
                case "matchmaker":
                    user = new MatchMaker
                    {
                        FirstName = registerDto.FirstName,
                        LastName = registerDto.LastName,
                        Username = registerDto.Username,
                        Password = registerDto.Password,
                        Role = BaseUser.ERole.MatchMaker
                    };
                    break;

                case "male":
                    user = new Male
                    {
                        FirstName = registerDto.FirstName,
                        LastName = registerDto.LastName,
                        Username = registerDto.Username,
                        Password = registerDto.Password,
                        Role = BaseUser.ERole.Male
                    };
                    break;

                case "female": // שונה מ-"women" ל-"female"
                    user = new Women
                    {
                        FirstName = registerDto.FirstName,
                        LastName = registerDto.LastName,
                        Username = registerDto.Username,
                        Password = registerDto.Password,
                        Role = BaseUser.ERole.Women
                    };
                    break;

                default:
                    throw new ArgumentException("Invalid user type!");
            }

            await _context.Users.AddAsync(user); // הוספת await
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<string> GenerateTokenAsync(BaseUser user) // שיניתי ל-Task<string>
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            };

            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: credentials
            );

            return await Task.FromResult(new JwtSecurityTokenHandler().WriteToken(token)); // הוספתי await
        }

        public async Task<BaseUser> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) throw new InvalidOperationException("משתמש לא נמצא!");

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
