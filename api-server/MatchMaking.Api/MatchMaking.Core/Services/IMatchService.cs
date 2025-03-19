using MatchMaking.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Core.DTOs.Services
{
    public interface IMatchService
    {
        List<Match> GetAll();

        Match GetById(int id);

        Match GetByDate(DateTime date);

        Task<Match> AddAsync(Match match);

        void Delete(int id);

    }
}
