using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Models
{
    public class AddPurchasedTicketDto
    {
        public int UserID { get; set; }
        public int ScreeningID { get; set; }
        public int NumberOfTickets { get; set; }
        public DateTime DateOfBuying { get; set; } = System.DateTime.Now.AddDays(500);
    }
}
