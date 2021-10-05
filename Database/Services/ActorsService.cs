
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
    public class ActorsService : IActorsService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public ActorsService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<GetActorDto>> GetActors()
        {
            return await _context.Actors.Select(x => _mapper.Map<GetActorDto>(x)).ToListAsync();
        }


    }
}
