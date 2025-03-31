using MatchMakings.Core.DTOs;
using MatchMakings.Core.IRepositories;
using MatchMakings.Core.IServices;
using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Service
{
    public class BaseUserService : IBaseUserService
    {
        private readonly IBaseUserRepository _userRepository;

        public BaseUserService(IBaseUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<BaseUser> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }

        public async Task<BaseUser> RegisterUserAsync(RegisterDTO registerDto)
        {
            var existingUser = await _userRepository.GetUserByUsernameAsync(registerDto.Username);
            if (existingUser != null)
            {
                throw new InvalidOperationException("⚠ המשתמש כבר קיים במערכת!");
            }

            BaseUser user = new BaseUser
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Username = registerDto.Username,
                Password = registerDto.Password, // יש לשקול להשתמש בהצפנה
                Role = (BaseUser.ERole)Enum.Parse(typeof(BaseUser.ERole), registerDto.Role, true)
            };

            return await _userRepository.AddUserAsync(user);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _userRepository.DeleteUserAsync(id);
        }
    }

}
