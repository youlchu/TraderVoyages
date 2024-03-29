using Microsoft.AspNetCore.Mvc;
using TraderVoyages.Application.Interfaces;

namespace TraderVoyages.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase

    {
        private readonly ICityService _cityService;

        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }


        [HttpGet]
        public ActionResult<IEnumerable<string>> GetCities()
        {
            var cities = _cityService.GetCities();
            return Ok(cities);
        }

        [HttpGet("Goods")]
        public ActionResult<string> GetCitiesGoods()
        {
            var citiesGoods = _cityService.GetCitiesGoods();
            return Ok(citiesGoods);
        }


        [HttpGet("Goods/{cityId}")]
        public ActionResult<string> GetCityGoods(int cityId)
        {
            var cityGoods = _cityService.GetCityGoods(cityId);
            return Ok(cityGoods);
        }

    }
}