using MatchMaking.Core.Models;
using MatchMaking.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Data.Repositories
{
    public class MeetingRepository:IMeetingService
    {
        private readonly DataContext _context;
        public MeetingRepository(DataContext context)
        {
            _context = context;
        }

        public List<Meeting> GetList()
        {
            return _context.Meetings.ToList();
            //return _context.Meetings.Include(m => m.Match).ToList();

        }
        public Meeting GetById(int id)
        {
            return _context.Meetings.FirstOrDefault(x => x.Id == id);
        }
        //public Meeting GetByIdResume(int id)
        //{
        //    return _context.Meetings.FirstOrDefault(x => x.IdM == id);
        //}
        public async Task<Meeting> AddAsync(Meeting m)
        {
            _context.Meetings.Add(m);
            await _context.SaveChangesAsync();
            return m;
        }
        public async Task<Meeting> UpdatePlaceAsync(int id, string place)
        {
            Meeting m = _context.Meetings.FirstOrDefault(x => x.Id == id);
            m.PlaceMeeting = place;
            await _context.SaveChangesAsync();
            return m;

        }
        public void Delete(int id)
        {
            Meeting m = _context.Meetings.FirstOrDefault(x => x.Id == id);
            _context.Meetings.Remove(m);
        }

    }
}
