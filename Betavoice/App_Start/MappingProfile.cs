using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Betavoice.Models;
using Betavoice.Dtos;


namespace Betavoice.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Track, TrackDto>();
            Mapper.CreateMap<TrackDto, Track>();
        }
    }
}