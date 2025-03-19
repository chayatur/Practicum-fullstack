using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Core.DTOs
{
    public class MeetingDto
    {
        //   public int Id { get; set; }
        public int MatchId { get; set; }
        public int NumMeeting { get; set; }
        public DateTime DateMeeting { get; set; }
        public string PlaceMeeting { get; set; }
    }
}
