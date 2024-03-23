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

        // get players
        [HttpGet("GetPlayers")]
        public IActionResult GetPlayers()
        {
            var players = _playerService.GetPlayers();
            return Ok(players);
        }

        [HttpPost("CreatePlayer")]
        public async Task<IActionResult> CreatePlayer([FromBody] CreatePlayerDto playerDto)
        {
            if (playerDto.MountTypeID == 0)
            {
                return BadRequest("Lütfen binek hayvanı seçiniz");
            }

            var player = new Player
            {
                Name = playerDto.Name,
                MountTypeID = playerDto.MountTypeID,
                CurrentCityID = playerDto.CurrentCityID,
            };

            await _playerService.AddPlayer(player);

            return Ok(player);
        }

    }
}
