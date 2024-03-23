// src/TraderVoyages.Application/Mappings/MappingProfile.cs
using AutoMapper;
using TraderVoyages.Application.DTOs;
using TraderVoyages.Domain.Entities;

namespace TraderVoyages.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Player, PlayerDTO>();
            // Diğer haritalamalar...
        }
    }
}
