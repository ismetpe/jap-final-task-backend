
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Infrastructure.Database.Seeds
{
    public class ScreeningsSeed
    {
        public static List<Screening> Screenings { get; } = new()
        {
            new Screening { Id = 1, Date = System.DateTime.Now.AddDays(100).AddHours(100).AddMinutes(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "10:00" },
            new Screening { Id = 2, Date = System.DateTime.Now.AddDays(10), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 3, Date = System.DateTime.Now.AddDays(8), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "08:00" },
            new Screening { Id = 4, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "09:00" },
            new Screening { Id = 5, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "10:00" },
            new Screening { Id = 6, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "00:00" },
            new Screening { Id = 7, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "23:00" },
            new Screening { Id = 8, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "22:00" },
            new Screening { Id = 9, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "21:00" },
            new Screening { Id = 11, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "20:00" },
            new Screening { Id = 12, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "19:00" },
            new Screening { Id = 13, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "18:00" },
            new Screening { Id = 14, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "17:00" },
            new Screening { Id = 15, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "16:00" },
            new Screening { Id = 16, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "15:00" },
            new Screening { Id = 17, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "14:00" },
            new Screening { Id = 18, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "13:00" },
            new Screening { Id = 19, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "12:00" },
            new Screening { Id = 20, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 21, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 22, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 23, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 24, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },

            new Screening { Id = 25, Date = System.DateTime.Now.AddDays(100), MediaId = 2, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 26, Date = System.DateTime.Now.AddDays(100), MediaId = 2, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 27, Date = System.DateTime.Now.AddDays(100), MediaId = 2, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 28, Date = System.DateTime.Now.AddDays(100), MediaId = 2, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 29, Date = System.DateTime.Now.AddDays(100), MediaId = 2, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },


            new Screening { Id = 30, Date = System.DateTime.Now.AddDays(100), MediaId = 80, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 31, Date = System.DateTime.Now.AddDays(100), MediaId = 80, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 32, Date = System.DateTime.Now.AddDays(100), MediaId = 80, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 33, Date = System.DateTime.Now.AddDays(100), MediaId = 80, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 34, Date = System.DateTime.Now.AddDays(100), MediaId = 80, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },



            new Screening { Id = 35, Date = System.DateTime.Now.AddDays(100), MediaId = 81, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 36, Date = System.DateTime.Now.AddDays(100), MediaId = 81, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 37, Date = System.DateTime.Now.AddDays(100), MediaId = 81, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 38, Date = System.DateTime.Now.AddDays(100), MediaId = 81, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 39, Date = System.DateTime.Now.AddDays(100), MediaId = 81, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },


            new Screening { Id = 40, Date = System.DateTime.Now.AddDays(100), MediaId = 82, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 41, Date = System.DateTime.Now.AddDays(100), MediaId = 82, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 42, Date = System.DateTime.Now.AddDays(100), MediaId = 82, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 43, Date = System.DateTime.Now.AddDays(100), MediaId = 82, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 44, Date = System.DateTime.Now.AddDays(100), MediaId = 82, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },



            new Screening { Id = 45, Date = System.DateTime.Now.AddDays(100), MediaId = 83, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 46, Date = System.DateTime.Now.AddDays(100), MediaId = 83, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 47, Date = System.DateTime.Now.AddDays(100), MediaId = 83, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 48, Date = System.DateTime.Now.AddDays(100), MediaId = 83, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 49, Date = System.DateTime.Now.AddDays(100), MediaId = 83, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },



            new Screening { Id = 50, Date = System.DateTime.Now.AddDays(100), MediaId = 84, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 51, Date = System.DateTime.Now.AddDays(100), MediaId = 84, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 52, Date = System.DateTime.Now.AddDays(100), MediaId = 84, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 53, Date = System.DateTime.Now.AddDays(100), MediaId = 84, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 54, Date = System.DateTime.Now.AddDays(100), MediaId = 84, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },

            new Screening { Id = 55, Date = System.DateTime.Now.AddDays(100), MediaId = 85, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 56, Date = System.DateTime.Now.AddDays(100), MediaId = 85, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 57, Date = System.DateTime.Now.AddDays(100), MediaId = 85, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 58, Date = System.DateTime.Now.AddDays(100), MediaId = 85, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 59, Date = System.DateTime.Now.AddDays(100), MediaId = 85, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },

            new Screening { Id = 60, Date = System.DateTime.Now.AddDays(100), MediaId = 86, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 61, Date = System.DateTime.Now.AddDays(100), MediaId = 86, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 62, Date = System.DateTime.Now.AddDays(100), MediaId = 86, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 63, Date = System.DateTime.Now.AddDays(100), MediaId = 86, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 64, Date = System.DateTime.Now.AddDays(100), MediaId = 86, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },

            new Screening { Id = 65, Date = System.DateTime.Now.AddDays(100), MediaId = 87, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 66, Date = System.DateTime.Now.AddDays(100), MediaId = 87, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 67, Date = System.DateTime.Now.AddDays(100), MediaId = 87, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 68, Date = System.DateTime.Now.AddDays(100), MediaId = 87, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" },
            new Screening { Id = 69, Date = System.DateTime.Now.AddDays(100), MediaId = 87, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" }
        };
    }
}
