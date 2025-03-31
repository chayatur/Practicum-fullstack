using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.IServices
{
    public interface IMatchMakerService
    {
        Task<IEnumerable<MatchMaker>> GetListOfMatchMakerAsync();
        Task<MatchMaker> GetMatchMakerByIdAsync(int id);
        Task<MatchMaker> AddMatchMakerAsync(MatchMaker matchMaker);
        Task<MatchMaker> DeleteMatchMakerAsync(int id);
        Task<MatchMaker> UpdateMatchMakerAsync(int id, MatchMaker matchMaker);
    }
}
