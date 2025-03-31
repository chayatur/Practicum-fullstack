using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.IServices
{
    public interface IWomenService
    {
        Task<IEnumerable<Women>> GetListOfWomenAsync();
        Task<Women> GetWomenByIdAsync(int id);
        Task<Women> AddWomenAsync(Women women);
        Task<Women> DeleteWomenAsync(int id);
        Task<Women> UpdateWomenAsync(int id, Women women);
    }
}
