using MatchMaking.Core.Models;
using MatchMaking.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Service.Services
{
    public class MeetingService:IMeetingService
    {

        private readonly IManagerRepository _managerRepository;

        private readonly IMeetingService _meetingRepository;
        public MeetingService(IMeetingService meetingRepository, IManagerRepository managerRepository)
        {
            _meetingRepository = meetingRepository;
            _managerRepository = managerRepository;
        }
        public List<Meeting> GetList()
        {
            return _meetingRepository.GetList();
        }
        public Meeting GetById(int id)
        {
            return _meetingRepository.GetById(id);
        }
        //public Meeting GetByIdResume(int id)
        //{
        //    return _meetingRepository.GetByIdResume(id);
        //}
        public async Task<Meeting> AddAsync(Meeting meeting)
        {

            return await _meetingRepository.AddAsync(meeting);
            //   _managerRepository.save();

        }
        public async Task<Meeting> UpdatePlaceAsync(int id, string place)
        {
            return await _meetingRepository.UpdatePlaceAsync(id, place);
            //_managerRepository.save();

        }
        public void Delete(int id)
        {
            _meetingRepository.Delete(id);
            _managerRepository.Save();

        }

    }
}
