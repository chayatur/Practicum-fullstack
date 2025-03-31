using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.Models
{
   
    public  class BaseUser
    {
        public enum ERole
        {
            MatchMaker,
            Women,
            Male
        }
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public ERole Role { get; set; }
        public BaseUser(string firstName,string lastName, string Username,string passwordHash,string Password,ERole Role)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = Username;
            this.Password = Password;
            this.PasswordHash = passwordHash;
            this.Role = Role;
        }
        public BaseUser()
        {
                
        }
    }
}
