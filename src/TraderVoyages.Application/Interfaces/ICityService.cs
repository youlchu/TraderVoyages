
using TraderVoyages.Application.DTOs;
using TraderVoyages.Domain.Entities;

namespace TraderVoyages.Application.Interfaces
{
    public interface ICityService
    {
        List<CityDto> GetCities();
        List<CitiesWithGoodsDTO> GetCitiesGoods();
        List<GoodsOfCityDTO> GetCityGoods(int cityId);

    }
}
