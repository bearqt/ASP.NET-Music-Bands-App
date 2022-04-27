using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MusicBandsApp.Data;
using MusicBandsApp.Data.Models;
using MusicBandsApp.Services.Dto;

namespace MusicBandsApp.Services
{
    public class ArtistService : IArtistService
    {
        private readonly MusicDbContext _context;
        private readonly IMapper _mapper;
        
        public ArtistService(MusicDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public IEnumerable<ArtistDto> GetAllArtists()
        {
            var artists = _context.Artists;
            return _mapper.Map<IEnumerable<Artist>,IEnumerable<ArtistDto>>(artists.ToList());
        }

        public ArtistDto GetArtistById(int id)
        {
            var artist = _context.Artists.FirstOrDefault(a => a.ArtistId == id);
            return _mapper.Map<ArtistDto>(artist);
        }

        public ArtistDto AddArtist(ArtistDto dto)
        {
            var artist = _mapper.Map<Artist>(dto);
            var country = _context.Countries.Find(artist.CountryId);
            var genre = _context.Genres.Find(artist.GenreId);
            artist.Country = country;
            artist.Genre = genre;

            _context.Artists.Add(artist);
            _context.SaveChanges();
            return _mapper.Map<ArtistDto>(artist);
        }

        public ArtistDto UpdateArtist(ArtistDto dto)
        {
            var artist = _mapper.Map<Artist>(dto);
            _context.Update(artist);
            _context.SaveChanges();
            return _mapper.Map<ArtistDto>(artist);
        }

        public ArtistDto DeleteArtist(int id)
        {
            var artist = _context.Artists.Find(id);
            _context.Artists.Remove(artist);
            _context.SaveChanges();
            return _mapper.Map<ArtistDto>(artist);
        }
    }
}