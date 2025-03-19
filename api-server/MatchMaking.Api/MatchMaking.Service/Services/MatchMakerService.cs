using MatchMaking.Core.Models;
using MatchMaking.Core.Repositories;
using MatchMaking.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Service.Services
{
    public class MatchMakerService:IMatchMakerService
    {
        private readonly IManagerRepository _managerRepository;
        private readonly IMatchMakerRepository _matchMakerRepository;
        public MatchMakerService(IMatchMakerRepository matchMakerRepository, IManagerRepository managerRepository)
        {
            _matchMakerRepository = matchMakerRepository;
            _managerRepository = managerRepository;
        }

        public List<MatchMaker> GetAll()
        {
            return _matchMakerRepository.GetList();
        }

        public MatchMaker GetById(int id)
        {
            return _matchMakerRepository.GetById(id);
        }
        public MatchMaker GetByName(string name)
        {
            return _matchMakerRepository.GetByName(name);
        }
        public async Task<MatchMaker> AddAsync(MatchMaker matchMaker)
        {
            return await _matchMakerRepository.AddAsync(matchMaker);
            // _managerRepository.save();

        }
        public async Task<MatchMaker> UpdatePriceAsync(int id, int price)
        {
            return await _matchMakerRepository.UpdatePriceAsync(id, price);
            //_managerRepository.save();

        }
        public async Task<MatchMaker> DeleteAsync(int id)
        {
            return await _matchMakerRepository.DeleteAsync(id);
            //_managerRepository.save();
        }

    }
}
