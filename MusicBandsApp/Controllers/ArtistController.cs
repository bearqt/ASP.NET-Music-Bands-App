using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MusicBandsApp.Data;
using MusicBandsApp.Data.Models;
using MusicBandsApp.Services;
using MusicBandsApp.Services.Dto;

namespace MusicBandsApp.Controllers
{
    [ApiController]
    [Route("artists")]
    [Route("/")]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistService _service;

        public ArtistController(IArtistService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ArtistDto>> Index()
        {
            return Ok(_service.GetAllArtists());
        }
        
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult<ArtistDto> GetById(int id)
        {
            var artist = _service.GetArtistById(id);
            if (artist == null) return NotFound();
            return Ok(artist);
        }

        [HttpPost]
        public ActionResult<ArtistDto> Create([Bind("FirstName,LastName")]ArtistDto dto)
        {
            return _service.AddArtist(dto);
        }

        [HttpPut]
        public ActionResult<ArtistDto> Update(ArtistDto dto)
        {
            return _service.UpdateArtist(dto);
        }

        [HttpDelete]
        public ActionResult<ArtistDto> Delete(int id)
        {
            return _service.DeleteArtist(id);
        }
        
    }
}