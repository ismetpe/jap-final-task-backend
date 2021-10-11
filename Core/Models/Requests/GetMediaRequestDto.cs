using Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models.Requests
{
    public class GetMediaRequestDto
    {
        public int Id { get; set; } 
        public string SearchTerm { get; set; } = String.Empty;
        public int Pagination { get; set; } = 10;
        public bool GetAllMedia { get; set; }
        public int? GetMediaId { get; set; }
        public MediaType? Type { get; set; }
    }
}
