
using Core.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
   public interface IScreeningsService
    {
        Task<List<GetScreeningDto>> GetScreenings();
        Task<int> BuyTickets(AddPurchasedTicketDto request);

        Task<List<GetScreeningDto>> GetScreeningsByMovie(int id);
    }
}
