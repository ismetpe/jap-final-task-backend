using AutoMapper;
using Common;
using Core.Interfaces;
using Core.Models.Models;
using Core.Models.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Database.Services
{
    public class MediaService : IMediaService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public MediaService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        private async Task<List<GetMediaDto>> SearchFilter(string value)
        {

            if (value.ToUpper().Contains("STARS"))
            {
                string[] numbers = Regex.Split(value, @"\D+");

                int i = int.Parse(numbers[0]);

                if (i >= 0 && i <= 5 && value.ToUpper().Contains("LEAST"))
                {
                    return await _context.Medias
                                  .Include(x => x.Ratings)
                                  .AsSplitQuery()
                                  .Include(x => x.Actors)
                                  .AsSplitQuery().Where(s => s.Ratings.Select(x => x.Rating_value).Average() >= i).Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();

                }
                else
                {
                    return await _context.Medias
                                  .Include(x => x.Ratings)
                                  .AsSplitQuery()
                                  .Include(x => x.Actors)
                                  .AsSplitQuery().Where(s => s.Ratings.Select(x => x.Rating_value).Average() == i).Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();

                }
            }



            //throw new NotSupportedException();
            return await _context.Medias
                          .Include(x => x.Ratings)
                          .AsSplitQuery()
                          .Include(x => x.Actors)
                          .AsSplitQuery().Where(s => s.Title.ToUpper().Contains(value.ToUpper()) || s.Description.ToUpper().Contains(value.ToUpper())).Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();


        }
        private async Task<List<GetMediaDto>> TypeFilter(MediaType? type, int pagination)
        {


            return await _context.Medias
                                  .Include(x => x.Ratings)
                                  .AsSplitQuery()
                                  .Include(x => x.Actors)
                                  .AsSplitQuery()
                                  .Where(x => x.MediaType == type)
                                  .Take(pagination)
                                  .Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();


        }
        public async Task<List<GetMediaDto>> GetMedia(GetMediaRequestDto request)
        {

            if (!string.IsNullOrEmpty(request.SearchTerm))
            {
                return await SearchFilter(request.SearchTerm);
            }
            if (request.Type != null)
            {
                return await TypeFilter(request.Type, request.Pagination);
            }
            if (request.GetMediaId != null)
            {
                return await _context.Medias
                                      .Include(x => x.Ratings)
                                      .AsSplitQuery()
                                      .Include(x => x.Actors)
                                      .AsSplitQuery()
                                      .Where(x => x.Id == request.GetMediaId)
                                      .Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();
            }

            return await _context.Medias
                                       .Include(x => x.Ratings)
                                       .AsSplitQuery()
                                       .Include(x => x.Actors)
                                       .AsSplitQuery()
                                       .Select(x => _mapper.Map<GetMediaDto>(x)).ToListAsync();
        }
    }
}
