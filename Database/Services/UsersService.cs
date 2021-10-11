using AutoMapper;
using Core.Interfaces;
using Core.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Services
{
    public class UsersService : IUsersService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public UsersService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<GetPurchasedTicketsDto>> GetUserTicketsAsync(int id)
        {
            return await _context.PurchasedTickets.Where(x => x.UserId == id).Select(x => _mapper.Map<GetPurchasedTicketsDto>(x)).ToListAsync();    
        }
    }
}
