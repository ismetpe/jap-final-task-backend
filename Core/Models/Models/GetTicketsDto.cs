using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models.Models
{
    public class GetTicketsDto
    {
        public int Id { get; set; }
        public float Price { get; set; }
        public int ScreeningId { get; set; }
    }
}
