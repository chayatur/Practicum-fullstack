using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MatchMakings.Core.Models.BaseUser;

namespace MatchMakings.Core.DTOs
{
    public class BaseUserDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public ERole Role { get; set; }
    }
}



