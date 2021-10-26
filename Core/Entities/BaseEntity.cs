using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = "SYSTEM";
        public DateTime? ArchivedAt { get; set; } = null;
        public string ArchivedBy { get; set; } = null;
    }
}
