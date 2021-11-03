using Core.Models.Models;
using Core.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IMediaService
    {
        Task<List<GetMediaDto>> GetMediaAsync(GetMediaRequestDto request);
        Task<int> AddMovieAsync(AddMovieDto movie);
        Task<int> EditMovieAsync(EditMovieDto movie, int Id);


    }
}
