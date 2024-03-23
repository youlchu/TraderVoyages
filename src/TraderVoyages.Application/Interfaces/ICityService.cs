
using TraderVoyages.Application.DTOs;
using TraderVoyages.Domain.Entities;

namespace TraderVoyages.Application.Interfaces
{
    public interface ICityService
    {
        List<City> GetCities();
        List<CityGoods> GetCitiesGoods();
        List<CityGoods> GetCityGoods(int cityId);

    }
}
