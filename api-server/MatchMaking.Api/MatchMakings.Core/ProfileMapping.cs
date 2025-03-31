using AutoMapper;
using MatchMakings.Core.DTOs;
using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping()
        {
            CreateMap<RegisterDTO, BaseUser>()
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role));

            CreateMap<LoginDTO, BaseUser>();

            // הוספת המפה מ-BaseUser ל-BaseUserDTO
            CreateMap<BaseUser, BaseUserDTO>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role));
        }
    }

}

