using MatchMakings.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Male> Males { get; set; }
        public DbSet<Women> Womens { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<FamilyDetails> FamilyDetails { get; set; }
        public DbSet<MatchMaker> MatchMakers { get; set; }
       
        public DbSet<BaseUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MatchMakings");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            
        }


    }

}
