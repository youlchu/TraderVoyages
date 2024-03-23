using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TraderVoyages.Application.Interfaces;

namespace TraderVoyages.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MountTypeController : ControllerBase
    {
        private readonly IMountTypeService _mountTypeService;

        public MountTypeController(IMountTypeService mountTypeService)
        {
            _mountTypeService = mountTypeService;
        }

        [HttpGet]
        public IActionResult GetMountTypes()
        {
            var mountTypes = _mountTypeService.GetMountTypes();
            return Ok(mountTypes);
        }
    }
}