using MatchMaking.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Core.Repositories
{
    public interface IMeetingService
    {
        List<Meeting> GetList();

        Meeting GetById(int id);
        //Meeting GetByIdResume(int id);

        Task<Meeting> AddAsync(Meeting m);

        Task<Meeting> UpdatePlaceAsync(int id, string place);

        void Delete(int id);
    }
}
