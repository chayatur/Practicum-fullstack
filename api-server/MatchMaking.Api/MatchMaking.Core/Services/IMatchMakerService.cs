using MatchMaking.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Core.Services
{
    public interface IMatchMakerService
    {
        List<MatchMaker> GetAll();

        MatchMaker GetById(int id);

        MatchMaker GetByName(string name);

        Task<MatchMaker> AddAsync(MatchMaker matchMaker);

        Task<MatchMaker> UpdatePriceAsync(int id, int price);

        Task<MatchMaker> DeleteAsync(int id);

    }
}
