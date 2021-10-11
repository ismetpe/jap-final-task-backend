using Core.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUsersService
    {
        Task<List<GetPurchasedTicketsDto>> GetUserTicketsAsync(int id);
    }
}
