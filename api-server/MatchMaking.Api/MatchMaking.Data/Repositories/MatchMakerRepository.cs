using MatchMaking.Core.Models;
using MatchMaking.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Data.Repositories
{
    public class MatchMakerRepository: IMatchMakerRepository
    {
        private readonly DataContext _context;

        public MatchMakerRepository(DataContext context)
        {
            _context = context;

        }
        public List<MatchMaker> GetList()
        {
            return _context.MatchMakers.ToList();
        }
        public MatchMaker GetById(int id)
        {
            return _context.MatchMakers.FirstOrDefault(x => x.Id == id);

        }
        public MatchMaker GetByName(string name)
        {
            return _context.MatchMakers.FirstOrDefault(x => x.Name == name);
        }
        public async Task<MatchMaker> AddAsync(MatchMaker matchMaker)
        {
            _context.MatchMakers.Add(matchMaker);
            await _context.SaveChangesAsync();
            return matchMaker;
        }
        public async Task<MatchMaker> UpdatePriceAsync(int id, int price)
        {
            MatchMaker m = _context.MatchMakers.FirstOrDefault(x => x.Id == id);
            m.Price = price;
            await _context.SaveChangesAsync();
            return m;
        }
        public async Task<MatchMaker> DeleteAsync(int id)
        {
            MatchMaker m = _context.MatchMakers.FirstOrDefault(x => x.Id == id);
            _context.MatchMakers.Remove(m);
            await _context.SaveChangesAsync();
            return m;
        }

    }
}
