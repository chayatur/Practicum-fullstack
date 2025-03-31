using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.DTOs
{
    public class WomenDTO:BaseUserDTO
    {
        
            public int Id { get; set; }
            public string? Country { get; set; }
            public string? City { get; set; }
            public string? Address { get; set; }
            public string? Tz { get; set; }
            public string? Class { get; set; }
            public bool? AnOutsider { get; set; }
            public string? BackGround { get; set; }
            public string? Openness { get; set; }
            public DateTime? BurnDate { get; set; }
            public int? Age { get; set; }
            public bool? HealthCondition { get; set; }
            public string? Status { get; set; }
            public bool? StatusVacant { get; set; }
            public string? PairingType { get; set; }
            public double? Height { get; set; }
            public string? GeneralAppearance { get; set; }
            public string? FacePaint { get; set; }
            public string? Appearance { get; set; }
            public string? Phone { get; set; }
            public string? Email { get; set; }
            public string? FatherPhone { get; set; }
            public string? MotherPhone { get; set; }
            public string? MoreInformation { get; set; }
            public string? HeadCovering { get; set; }
            public string? HighSchool { get; set; }
            public string? Seminar { get; set; }
            public string? StudyPath { get; set; }
            public string? AdditionalEducationalInstitution { get; set; }
            public string? CurrentOccupation { get; set; }
            public string? Club { get; set; }
            public int? AgeFrom { get; set; }
            public int? AgeTo { get; set; }
            public string? ImportantTraitsInMe { get; set; }
            public string? ImportantTraitsIMLookingFor { get; set; }
            public string? PreferredSittingStyle { get; set; }
            public string? InterestedInBoy { get; set; }
            public string? DrivingLicense { get; set; }
            public bool? Smoker { get; set; }
            public string? Beard { get; set; }
            public string? Hat { get; set; }
            public string? Suit { get; set; }
            public string? Occupation { get; set; }
        }

    }

