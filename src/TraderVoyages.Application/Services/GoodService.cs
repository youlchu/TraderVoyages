using System.Collections.Generic;
using TraderVoyages.Application.DTOs;
using TraderVoyages.Application.Interfaces;
using TraderVoyages.Domain.Entities;
using TraderVoyages.Infrastructure.Data;

namespace TraderVoyages.Application.Services
{
    public class GoodService : IGoodService
    {
        private readonly ApplicationDbContext _context;

        public GoodService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<GoodDto> GetGoods()
        {
            return _context.Goods.Select(g => new GoodDto
            {
                Name = g.Name,
                Weight = g.Weight
            }).ToList();
        }


    }
}
