using MatchMaking.Core.Models;

namespace Matchmaking.Core.DTOs

{
    public class ResumeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Min { get; set; }
        public string Status { get; set; }
        public int Age { get; set; }
        public int Heigth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string StudiesSubject { get; set; }
        public string EducationalInstitution { get; set; }
        public int MatchId { get; set; }
        public Match MyMatch { get; set; }
    }
}
