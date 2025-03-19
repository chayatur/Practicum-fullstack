using AutoMapper;
using MatchMaking.Core.DTOs;
using MatchMaking.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking.Core
{
    public class MappingProfile:Profile
    {
        public MeetingDto MapToMeetingDto(Meeting m)
        {
            return new MeetingDto
            {
                NumMeeting = m.NumMeeting,
                MatchId = m.MatchId,
                DateMeeting = m.DateMeeting,
                PlaceMeeting = m.PlaceMeeting
            }; 
        }
    }
}
