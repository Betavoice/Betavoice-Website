using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Betavoice.Models;
using Betavoice.Dtos;
using AutoMapper;

namespace Betavoice.Controllers.Api
{
    public class TracksController : ApiController
    {
        private ApplicationDbContext _context;
        public TracksController()
        {
            _context = new ApplicationDbContext();
        }
        //GET/api/tracks
        public IEnumerable<TrackDto> GetTracks()
        {
            return _context.Tracks.ToList().Select(Mapper.Map<Track, TrackDto>);
        }

        //GET/api/tracks/1

        public Track GetTrack(int id)
        {
            var track = _context.Tracks.SingleOrDefault(t => t.Id == id);
            if (track == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return track;
        }

        //POST/api/tracks
        [HttpPost]
        public Track CreateTrack(Track track)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            _context.Tracks.Add(track);
            _context.SaveChanges();
            return track;
        }

        //PUT/api/track/1
        [HttpPut]
        public void UpdateTrack(int id, Track track)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var trackInDb = _context.Tracks.SingleOrDefault(t => t.Id == id);
            if (trackInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            trackInDb.Title = track.Title;
            trackInDb.Author = track.Author;
            trackInDb.ReleaseDate = track.ReleaseDate;

            _context.SaveChanges();
        }

        //Delete/api/track/1
        [HttpDelete]
        public void DeleteTrack(int id)
        {
            var trackInDb = _context.Tracks.SingleOrDefault(t => t.Id == id);
            if (trackInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Tracks.Remove(trackInDb);
            _context.SaveChanges();
        }
    }
}
