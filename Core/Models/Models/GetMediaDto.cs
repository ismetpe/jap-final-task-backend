using System.Collections.Generic;
using Common;
namespace Core.Models.Models
{
    public class GetMediaDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Release_year { get; set; }
        public string img_url { get; set; }
        public MediaType MediaType { get; set;}
        public List<GetRatingDto> Ratings { get; set; } = new List<GetRatingDto>();
        public List<GetActorDto> Actors { get; set;} = new List<GetActorDto>();
    }
}