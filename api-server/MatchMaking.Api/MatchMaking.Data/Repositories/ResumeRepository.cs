using MatchMaking.Core.Models;
using MatchMaking.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Data.Repositories
{
    public class ResumeRepository:IResumeService
    {
        private readonly DataContext _context;

        public ResumeRepository(DataContext context)
        {
            _context = context;
        }
        public List<Resume> GetList()
        {
            return _context.Resumes.ToList();
        }
        public Resume GetById(int id)
        {
            return _context.Resumes.FirstOrDefault(x => x.Id == id);
        }
        public Resume GetByMin(string min)
        {
            return _context.Resumes.FirstOrDefault(x => x.Min == min);
        }
        public async Task<Resume> AddAsync(Resume r)
        {
            _context.Resumes.Add(r);
            await _context.SaveChangesAsync();
            return r;
        }

        public async Task<Resume> UpdatePhonAsync(int id, string phon)
        {
            Resume r = _context.Resumes.FirstOrDefault(x => x.Id == id);
            r.Phone = phon;
            await _context.SaveChangesAsync();
            return r;


        }
        public void Delete(int id)
        {
            Resume r = _context.Resumes.FirstOrDefault(x => x.Id == id);
            _context.Resumes.Remove(r);
        }


    }
}
