using Microsoft.EntityFrameworkCore;
using TraderVoyages.Application.DTOs;
using TraderVoyages.Application.Interfaces;
using TraderVoyages.Domain.Repository;


namespace TraderVoyages.Application.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IGoodRepository _goodRepository;
        private readonly ICityGoodRepository _cityGoodRepository;
        public CityService(ICityRepository cityRepository, IGoodRepository goodRepository, ICityGoodRepository cityGoodRepository
        )
        {
            _cityRepository = cityRepository;
            _goodRepository = goodRepository;
            _cityGoodRepository = cityGoodRepository;
        }

        public List<CityDto> GetCities()
        {

            var cities = _cityRepository.GetAllCities();
            return cities.Select(c => new CityDto
            {
                CityID = c.CityID,
                Name = c.Name,
                XCoordinate = c.XCoordinate,
                YCoordinate = c.YCoordinate
            }).ToList();
        }

        public List<CitiesWithGoodsDTO> GetCitiesGoods()
        {

            var cityGoodsList = _cityGoodRepository.GetCityGoods();



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
            var cities = _cityRepository.GetAllCities();
            var goods = _goodRepository.GetAllGoods();

            var cityGoodsList = _cityGoodRepository.GetCityGoods(cityId);

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

        public CityDto GetCityById(int cityId)
        {
            var city = _cityRepository.GetCityById(cityId);
            return new CityDto
            {
                CityID = city.CityID,
                Name = city.Name,
            };
        }
    }
}
