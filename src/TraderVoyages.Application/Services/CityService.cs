using Microsoft.EntityFrameworkCore;
using TraderVoyages.Application.DTOs;
using TraderVoyages.Application.Interfaces;
using TraderVoyages.Domain.Entities;
using TraderVoyages.Infrastructure.Data;

namespace TraderVoyages.Application.Services
{
    public class CityService : ICityService
    {
        private readonly ApplicationDbContext _context;

        public CityService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<City> GetCities()
        {

            return _context.Cities.ToList();
        }


        public List<CityGoods> GetCitiesGoods()
        {
            List<City> cities;
            List<CityGood> cityGoods;

            cities = _context.Cities.ToList();
            cityGoods = _context.CityGoods
                .Include(cg => cg.Good)
                .ToList();
            var result = cities.Select(city => new CityGoods
            {
                CityID = city.CityID,
                CityName = city.Name,
                Goods = cityGoods.Where(cg => cg.CityID == city.CityID).Select(cg => new GoodPrice
                {
                    GoodID = cg.GoodID,
                    GoodName = cg.Good.Name,
                    PurchasePrice = cg.PurchasePrice,
                    SalePrice = cg.SalePrice
                }).ToList()
            }).ToList();

            return result;
        }

        public List<CityGoods> GetCityGoods(int cityId)
        {
            List<City> cities;
            List<CityGood> cityGoods;

            cities = _context.Cities.ToList();
            cityGoods = _context.CityGoods
                .Include(cg => cg.Good)
                .ToList();
            var result = cities.Where(c => c.CityID == cityId).Select(city => new CityGoods
            {
                CityID = city.CityID,
                CityName = city.Name,
                Goods = cityGoods.Where(cg => cg.CityID == city.CityID).Select(cg => new GoodPrice
                {
                    GoodID = cg.GoodID,
                    GoodName = cg.Good.Name,
                    PurchasePrice = cg.PurchasePrice,
                    SalePrice = cg.SalePrice
                }).ToList()
            }).ToList();

            return result;
        }
    }
}
