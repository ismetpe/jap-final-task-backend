using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MostRatedMoviesReport
    {
        public string Title { get; set; }
        public int NumberOfRatings { get; set; }
        public double MovieRating { get; set; }
    }
}
