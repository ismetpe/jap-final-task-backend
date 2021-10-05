
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Infrastructure.Database.Seeds
{
    public class RatingsSeed
    {
        public static List<Rating> Ratings { get; } = new()
        {
            new Rating { Id = 1, Rating_value = 4.6F, MediaId = 1 },
            new Rating { Id = 2, Rating_value = 4.5F, MediaId = 2 },
            new Rating { Id = 3, Rating_value = 4.5F, MediaId = 3 },
            new Rating { Id = 4, Rating_value = 4.5F, MediaId = 4 },
            new Rating { Id = 5, Rating_value = 4.6F, MediaId = 5 },
            new Rating { Id = 6, Rating_value = 4.5F, MediaId = 6 },
            new Rating { Id = 7, Rating_value = 4.5F, MediaId = 7 },
            new Rating { Id = 8, Rating_value = 4.5F, MediaId = 8 },

            new Rating { Id = 9, Rating_value = 4.6F, MediaId = 9 },
            new Rating { Id = 10, Rating_value = 4.5F, MediaId = 10 },
            new Rating { Id = 11, Rating_value = 4.5F, MediaId = 11 },
            new Rating { Id = 12, Rating_value = 4.5F, MediaId = 12 },
            new Rating { Id = 13, Rating_value = 4.6F, MediaId = 13 },
            new Rating { Id = 14, Rating_value = 4.5F, MediaId = 14 },
            new Rating { Id = 15, Rating_value = 4.5F, MediaId = 15 },
            new Rating { Id = 16, Rating_value = 4.5F, MediaId = 16 },



            new Rating { Id = 17, Rating_value = 4.6F, MediaId = 17 },
            new Rating { Id = 18, Rating_value = 4.5F, MediaId = 18 },
            new Rating { Id = 19, Rating_value = 4.5F, MediaId = 19 },
            new Rating { Id = 20, Rating_value = 4.5F, MediaId = 20 },
            new Rating { Id = 21, Rating_value = 4.6F, MediaId = 21 },
            new Rating { Id = 22, Rating_value = 4.5F, MediaId = 22 },
            new Rating { Id = 23, Rating_value = 4.5F, MediaId = 23 },
            new Rating { Id = 24, Rating_value = 4.5F, MediaId = 24 }
        };
    }
}
