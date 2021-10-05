
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Infrastructure.Database.Seeds
{
    public class TicketsSeed
    {
        public static List<Ticket> Tickets { get; } = new()
        {
            new Ticket { Id = 1, Price = 5.5F, ScreeningId = 1 },
            new Ticket { Id = 2, Price = 5.5F, ScreeningId = 25 },
            new Ticket { Id = 3, Price = 5.5F, ScreeningId = 30 },
            new Ticket { Id = 4, Price = 5.5F, ScreeningId = 35 },
            new Ticket { Id = 5, Price = 5.5F, ScreeningId = 40 },
            new Ticket { Id = 6, Price = 5.5F, ScreeningId = 45 },
            new Ticket { Id = 7, Price = 5.5F, ScreeningId = 50 },
            new Ticket { Id = 8, Price = 5.5F, ScreeningId = 55 },
            new Ticket { Id = 9, Price = 5.5F, ScreeningId = 60 },
            new Ticket { Id = 10, Price = 5.5F, ScreeningId = 65 }
        };
    }
}
