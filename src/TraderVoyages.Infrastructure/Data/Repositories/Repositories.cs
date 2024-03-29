using Microsoft.EntityFrameworkCore;
using TraderVoyages.Domain.Entities;
using TraderVoyages.Infrastructure.Data;

namespace TraderVoyages.Domain.Repository
{

    public class CityRepository : ICityRepository
    {
        private readonly ApplicationDbContext _context;

        public CityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<City> GetAllCities()
        {
            return _context.Cities.ToList();
        }

        public City GetCityById(int cityId)
        {
            return _context.Cities.FirstOrDefault(c => c.CityID == cityId);
        }


    }

    public class GoodRepository : IGoodRepository
    {
        private readonly ApplicationDbContext _context;

        public GoodRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Good> GetAllGoods()
        {
            return _context.Goods.ToList();
        }

        public Good GetGoodById(int goodId)
        {
            return _context.Goods.FirstOrDefault(g => g.GoodID == goodId);
        }
    }


    public class CityGoodRepository : ICityGoodRepository
    {
        private readonly ApplicationDbContext _context;

        public CityGoodRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<CityGood> GetCityGoods()
        {
            return _context.CityGoods
                            .Include(cg => cg.City)
                            .Include(cg => cg.Good).ToList();
        }

        public List<CityGood> GetCityGoods(int cityId)
        {
            return _context.CityGoods.Where(cg => cg.CityID == cityId).ToList();
        }
    }

}