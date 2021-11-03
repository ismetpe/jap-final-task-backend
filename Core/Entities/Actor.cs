﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
   public class Actor : BaseEntity
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public List<Media> Media { get; set; } = new List<Media>();
    }
}
