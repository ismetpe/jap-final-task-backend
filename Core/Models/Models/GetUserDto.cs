﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Models
{
    public class GetUserDto
    {
        public string Token { get; set; }
        public string Username { get; set; }
        public bool Admin { get; set; }
    }
}
