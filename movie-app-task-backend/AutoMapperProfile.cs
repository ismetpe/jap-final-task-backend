using AutoMapper;
using Core.Entities;
using Core.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Media, GetMediaDto>();
            CreateMap<Rating, GetRatingDto>();
            CreateMap<Actor, GetActorDto>();
            CreateMap<Screening, GetScreeningDto>();
            CreateMap<PurchasedTicket, GetPurchasedTicketsDto>();
        }
    }
}
