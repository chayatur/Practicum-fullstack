using MatchMaking.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Data.Repositories
{
    public class ManagerRepository:IManagerRepository
    {
        private readonly DataContext _context;
        public IResumeService Resumes { get; }
        public IMatchMakerRepository MatchMakers { get; }
        public IMeetingService Meetings { get; }
        public IMatchRepository Matches { get; }

        public ManagerRepository(DataContext context, IResumeService resumeRepository, IMeetingService meetingRepository, IMatchMakerRepository matchMakerRepository, IMatchRepository matches)
        {
            _context = context;
            Resumes = resumeRepository;
            Meetings = meetingRepository;
            MatchMakers = matchMakerRepository;
            this.Matches = matches;
        }
        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

    }
}
