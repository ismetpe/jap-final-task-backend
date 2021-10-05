
using AutoMapper;
using Core.Entities;
using Core.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Media, GetMediaDto>();
            CreateMap<Rating, GetRatingDto>();
            CreateMap<Actor, GetActorDto>();
            CreateMap<Screening, GetScreeningDto>();
        }
    }
}
