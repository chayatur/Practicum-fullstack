using MatchMaking.Core.Models;
using MatchMaking.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Data.Repositories
{
    public class MatchRepository:IMatchRepository
    {
        private readonly DataContext _context;

        public MatchRepository(DataContext context)
        {
            _context = context;
        }

        public List<Match> GetList()
        {
            return _context.Matches.ToList();
        }
        public Match GetById(int id)
        {
            return _context.Matches.FirstOrDefault(x => x.Id == id);
        }
        public Match GetByDate(DateTime date)
        {
            return _context.Matches.FirstOrDefault(x => x.Date == date);
        }
        public async Task<Match> AddAsync(Match match)
        {
            _context.Matches.Add(match);
            await _context.SaveChangesAsync();
            return match;
        }

        public void Delete(int id)
        {
            Match m = _context.Matches.FirstOrDefault(x => x.Id == id);
            _context.Matches.Remove(m);
        }

    }
}
