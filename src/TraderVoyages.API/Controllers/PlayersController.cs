using Microsoft.AspNetCore.Mvc;
using TraderVoyages.Domain.Entities;
using TraderVoyages.Application.Interfaces;
using TraderVoyages.Application.DTOs;


namespace TraderVoyages.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {

        private readonly IPlayerService _playerService; private readonly Random _random = new Random();


        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpPost("CreatePlayer")]
        public async Task<IActionResult> CreatePlayer([FromBody] CreatePlayerDto playerDto)
        {
            var player = new Player
            {
                Name = playerDto.Name,
                Money = 500,
                MountTypeID = playerDto.MountTypeID,
                CurrentCityID = playerDto.CurrentCityID,
                XCoordinate = _random.Next(0, 151),
                YCoordinate = _random.Next(0, 151)
            };

            await _playerService.AddPlayer(player);

            return Ok(player);
        }

    }
}
