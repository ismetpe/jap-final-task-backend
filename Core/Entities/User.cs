using System.Collections.Generic;

namespace Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] Salt { get; set; }
        public byte[] Hash { get; set; }
        public bool Admin { get; set; }
        public List<PurchasedTicket> PurchasedTickets { get; set; } = new List<PurchasedTicket>();
        
    }
}