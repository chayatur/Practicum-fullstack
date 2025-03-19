using MatchMaking.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Core.Repositories
{
    public interface IResumeService
    {
        List<Resume> GetList();

        Resume GetById(int id);

        Resume GetByMin(string min);

        Task<Resume> AddAsync(Resume r);

        Task<Resume> UpdatePhonAsync(int id, string phon);

        void Delete(int id);
    }
}
