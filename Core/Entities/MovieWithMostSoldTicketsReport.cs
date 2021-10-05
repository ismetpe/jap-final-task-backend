using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MovieWithMostSoldTicketsReport
    {
        public string Title { get; set; }
        public int ScreeningName { get; set; }
        public int SoldTickets { get; set; }
    }
}
