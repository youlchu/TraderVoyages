

using TraderVoyages.Domain.Entities;

namespace TraderVoyages.Domain.Repository
{
    public interface ICityRepository
    {
        List<City> GetAllCities();
        City GetCityById(int cityId);
    }

    public interface IGoodRepository
    {
        List<Good> GetAllGoods();
        Good GetGoodById(int goodId);
    }

    public interface ICityGoodRepository
    {
        List<CityGood> GetCityGoods();
        List<CityGood> GetCityGoods(int cityId);
    }
}
