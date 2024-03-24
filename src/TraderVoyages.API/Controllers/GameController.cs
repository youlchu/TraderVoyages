using Microsoft.AspNetCore.Mvc;
using TraderVoyages.Application.Interfaces;

namespace TraderVoyages.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {

        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("AllGames")]
        public IActionResult AllGames()
        {
            var games = _gameService.GetAllGames();
            return Ok(games);
        }


        // [HttpPost("CreateGame")]
        // public IActionResult CreateGame()
        // {

        //     _gameService.CreateGame(1, 2);
        //     return Ok();
        // }
    }
}