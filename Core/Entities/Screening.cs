using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Screening : BaseEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Place { get; set; }
        public int NumberOfSeats { get; set; }
        public int NumberOfTickets { get; set; }
        public int MediaId { get; set; }
        public Media Media { get; set; }

    }
}