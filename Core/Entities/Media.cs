using Common;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReleaseYear { get; set; }
        public string ImgUrl { get; set; }
        public MediaType MediaType { get; set;}
        public List<Rating> Ratings { get; set; } = new List<Rating>();
        public List<Actor> Actors { get; set;} = new List<Actor>();
        public List<Screening> Screenings { get; set;} = new List<Screening>();
    }
}