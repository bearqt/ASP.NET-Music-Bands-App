using System.Collections.Generic;
using AutoMapper;
using MusicBandsApp.Data.Models;

namespace MusicBandsApp.Services.Dto.AutoMapperProfiles
{
    public class ArtistDtoProfile : Profile
    {
        public ArtistDtoProfile()
        {
            CreateMap<Artist, ArtistDto>().ReverseMap();
            // CreateMap<IEnumerable<Artist>, IEnumerable<ArtistDto>>();
        }
        
        
    }
}