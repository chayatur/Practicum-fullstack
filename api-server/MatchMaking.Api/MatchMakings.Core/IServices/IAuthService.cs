using MatchMakings.Core.DTOs;
using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.IServices
{
    public interface IAuthService
    { 
        Task<BaseUser> AuthenticateUserAsync(LoginDTO loginDto);
        Task<BaseUser> RegisterUserAsync(RegisterDTO registerDto);
        Task<string> GenerateTokenAsync(BaseUser user);
        Task<BaseUser> GetUserByIdAsync(int id);
        // Task DeleteUserAsync(int id);
    }
}
