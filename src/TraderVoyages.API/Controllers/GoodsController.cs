using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TraderVoyages.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GoodsController : ControllerBase
    {
        private readonly Application.Interfaces.IGoodService _goodService;
        public GoodsController(Application.Interfaces.IGoodService goodService)
        {
            _goodService = goodService;
        }

        [HttpGet]
        public IActionResult GetGoods()
        {
            var goods = _goodService.GetGoods();
            return Ok(goods);
        }
    }
}