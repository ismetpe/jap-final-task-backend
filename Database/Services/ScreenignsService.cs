using AutoMapper;
using Core.Entities;
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
    public class ScreeningsService : IScreeningsService
    {

        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public ScreeningsService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<GetScreeningDto>> GetScreenings()
        {
            return await _context.Screenings.Include(x => x.Tickets).AsSplitQuery().Select(x => _mapper.Map<GetScreeningDto>(x)).ToListAsync();

        }

        public async Task<int> BuyTickets(AddPurchasedTicketDto request)
        {

            var ListOfScreenings = await GetScreenings();

            var screening = ListOfScreenings.Find(x => x.Id == request.ScreeningID);



            int result = DateTime.Compare(request.DateOfBuying, screening.Date);
            Console.WriteLine(screening.Date + " " + request.DateOfBuying + " " + result);
            if (result < 0 || result == 0)
            {
                throw new Exception("Screening date must be in future");
            }

            if (request.NumberOfTickets > 10)
            {
                throw new Exception("You can't buy more than 10 tickets");
            }
            for (int i = 0; i < request.NumberOfTickets; i++)
            {
                var purchasedTicket = new PurchasedTicket
                {
                    Price = 5.5F,
                    ScreeningId = request.ScreeningID,
                    UserId = request.UserID
                };

                await _context.PurchasedTickets.AddAsync(purchasedTicket);
                await _context.SaveChangesAsync();
            }

            int id = _context.PurchasedTickets.Max(x => x.Id);

            return id;
        }


       public async Task<List<GetScreeningDto>> GetScreeningsByMovie(int id)
        {
            return await _context.Screenings.Where(x => x.MediaId == id).Select(x => _mapper.Map<GetScreeningDto>(x)).ToListAsync();
        }
    }
}
