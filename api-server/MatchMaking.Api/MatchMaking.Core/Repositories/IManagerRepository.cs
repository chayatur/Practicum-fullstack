using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Core.Repositories
{
    public interface IManagerRepository
    {
        IResumeService Resumes { get; }
        IMatchMakerRepository MatchMakers { get; }
        IMeetingService Meetings { get; }
        IMatchRepository Matches { get; }
        Task<int> Save();
    }
}
