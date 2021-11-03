
using Core.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
   public interface IScreeningsService
    {
        Task<List<GetScreeningDto>> GetScreeningsAsync();
        Task<int> BuyTicketsAsync(AddPurchasedTicketDto request);
        Task<List<GetScreeningDto>> GetScreeningsByMovieAsync(int id);
        Task<int> AddScreeningsAsync(AddScreeningDto screening);
    }
}
