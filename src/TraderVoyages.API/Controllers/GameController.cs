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

        [HttpPost("CreateGame")]
        public IActionResult CreateGame(int player1Id, int player2Id)
        {
            var player1 = _gameService.GetPlayer(player1Id);
            var player2 = _gameService.GetPlayer(player2Id);

            if (player1 == null || player2 == null)
            {
                return BadRequest("Bir veya her iki oyuncu bulunamadı.");
            }
            _gameService.CreateGame(player1Id, player2Id);
            return Ok("Oyun Başlatıldı");
        }
    }
}

