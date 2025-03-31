using MatchMakings.Core.DTOs;
using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.IServices
{
    public interface IBaseUserService
    {
        Task<BaseUser> GetUserByIdAsync(int id);
        Task<BaseUser> RegisterUserAsync(RegisterDTO registerDto);
        Task DeleteUserAsync(int id);
    }

}
