using System.Collections.Generic;
using MusicBandsApp.Services.Dto;

namespace MusicBandsApp.Services
{
    public interface IArtistService
    {
        IEnumerable<ArtistDto> GetAllArtists();
        ArtistDto GetArtistById(int id);
        
        ArtistDto AddArtist(ArtistDto dto);
        ArtistDto UpdateArtist(ArtistDto dto);
        ArtistDto DeleteArtist(int id);
    }
}