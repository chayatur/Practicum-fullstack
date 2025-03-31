using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.IRepositories
{
    public interface IBaseUserRepository
    {
        Task<BaseUser> GetUserByIdAsync(int id);
        Task<BaseUser> AddUserAsync(BaseUser user);
        Task DeleteUserAsync(int id);
        Task<BaseUser> GetUserByUsernameAsync(string username);
    }
}
