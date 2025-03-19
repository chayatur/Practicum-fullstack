using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Core.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        //
        public int MatchId { get; set; }
        public Match Match { get; set; }
        //
        public int NumMeeting { get; set; }
        public DateTime DateMeeting { get; set; }
        public string PlaceMeeting { get; set; }

        public Meeting()
        {


        }

        public Meeting(int id, Match Match, int numMeeting, DateTime datemeeting, string placemeeting, int matchid)
        {
            Id = id;
            this.Match = Match;
            NumMeeting = numMeeting;
            DateMeeting = datemeeting;
            PlaceMeeting = placemeeting;
            MatchId = matchid;
        }
    }
}
