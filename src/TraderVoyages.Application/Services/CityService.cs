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

        public List<CityDto> GetCities()
        {

            return _context.Cities.Select(c => new CityDto
            {
                CityID = c.CityID,
                Name = c.Name,
            }).ToList();
        }


        public List<CitiesWithGoodsDTO> GetCitiesGoods()
        {
            var cityGoodsList = _context.CityGoods
                                    .Include(cg => cg.City)
                                    .Include(cg => cg.Good)
                                    .ToList();

            var result = cityGoodsList.GroupBy(cg => cg.CityID)
                                      .Select(cg => new CitiesWithGoodsDTO
                                      {
                                          CityID = cg.Key,
                                          CityName = cg.First().City.Name,
                                          Goods = cg.Select(g => new GoodPriceDTO
                                          {
                                              GoodID = g.GoodID,
                                              GoodName = g.Good.Name,
                                              PurchasePrice = g.PurchasePrice,
                                              SalePrice = g.SalePrice,
                                              Quantity = g.Quantity
                                          }).ToList()
                                      }).ToList();

            return result;
        }

        public List<GoodsOfCityDTO> GetCityGoods(int cityId)
        {
            var cityGoodsList = _context.CityGoods
                                    .Include(cg => cg.City)
                                    .Include(cg => cg.Good)
                                    .Where(cg => cg.CityID == cityId)
                                    .ToList();

            var result = cityGoodsList.GroupBy(cg => cg.CityID)
                                      .Select(cg => new GoodsOfCityDTO
                                      {
                                          CityID = cg.Key,
                                          CityName = cg.First().City.Name,
                                          Goods = cg.Select(g => new GoodPriceDTO
                                          {
                                              GoodID = g.GoodID,
                                              GoodName = g.Good.Name,
                                              PurchasePrice = g.PurchasePrice,
                                              SalePrice = g.SalePrice,
                                              Quantity = g.Quantity
                                          }).ToList()
                                      }).ToList();

            return result;
        }

    }
}
