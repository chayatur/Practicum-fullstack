using MatchMaking.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MatchMaker> MatchMakers { get; set; }
        public DbSet<Match> Matches { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=my_db;Trusted_Connection=True");

        }
    }
}
