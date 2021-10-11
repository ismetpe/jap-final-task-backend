using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Models
{
   public class EditMovieDto
    {
       
        public string Title { get; set; }
        public string Description { get; set; }
        public string Release_year { get; set; }
        public string img_url { get; set; }

    }
}
