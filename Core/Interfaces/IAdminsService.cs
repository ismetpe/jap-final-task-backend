using Core.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAdminsService
    {
        Task<int> AddMovieAsync(AddMovieDto movie);

        Task<int> EditMovieAsync(EditMovieDto movie, int id);

        Task<int> AddScreeningsAsync(AddScreeningDto screening);


    }
}
