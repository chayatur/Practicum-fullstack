using MatchMaking.Core.Models;
using MatchMaking.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Service.Services
{
    public class ResumeService:IResumeService
    {
        private readonly IManagerRepository _managerRepository;

        private readonly IResumeService _resumeRepository;
        public ResumeService(IResumeService resumeRepository, IManagerRepository managerRepository)
        {
            _resumeRepository = resumeRepository;
            _managerRepository = managerRepository;
        }
        public List<Resume> GetList()
        {
            return _resumeRepository.GetList();
        }
        public Resume GetById(int id)
        {
            return _resumeRepository.GetById(id);
        }
        public Resume GetByMin(string min)
        {
            return _resumeRepository.GetByMin(min);
        }
        public async Task<Resume> AddAsync(Resume r)
        {
            return await _resumeRepository.AddAsync(r);
            /// _managerRepository.save();

        }
        public async Task<Resume> UpdatePhonAsync(int id, string phone)
        {
            return await _resumeRepository.UpdatePhonAsync(id, phone);
            //_managerRepository.save();

        }
        public void Delete(int id)
        {
            _resumeRepository.Delete(id);
            _managerRepository.Save();

        }



    }
}
