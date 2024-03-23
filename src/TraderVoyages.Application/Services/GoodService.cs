using System.Collections.Generic;
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

        public List<Good> GetGoods()
        {
            return _context.Goods.ToList();
        }
    }
}
