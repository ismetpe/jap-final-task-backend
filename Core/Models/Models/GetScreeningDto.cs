
using Core.Entities;
using System;
using System.Collections.Generic;

namespace Core.Models.Models
{
    public class GetScreeningDto
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Place { get; set; }
        public int NumberOfSeats { get; set; }
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
        public int NumberOfTickets { get; set; }
        public int MediaId { get; set; }
    }
}