using TraderVoyages.Application.DTOs;
using TraderVoyages.Application.Entities;
using TraderVoyages.Application.Interfaces;
using TraderVoyages.Infrastructure.Data;


namespace TraderVoyages.Application.Services
{
    public class GameService : IGameService
    {
        private readonly ApplicationDbContext _context;

        public GameService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<GameDTO> GetAllGames()
        {
            return _context.Games.Select(g => new GameDTO
            {
                GameId = g.GameId,
                StartTime = g.StartTime,
                EndTime = g.EndTime,
                Status = g.Status,
                Player1Id = g.Player1Id,
                Player2Id = g.Player2Id,
                TurnId = g.TurnId,
                Player1 = g.Player1,
                Player2 = g.Player2
            }).ToList();
        }

        public GetPlayerDto GetPlayer(int playerId)
        {
            var player = _context.Players.FirstOrDefault(p => p.PlayerID == playerId);

            if (player == null)
            {
                throw new Exception("Oyuncu bulunamadı.");
            }

            return new GetPlayerDto
            {
                Name = player.Name,
                CurrentCityID = player.CurrentCityID,
                MountTypeID = player.MountTypeID
            };
        }

        public void CreateGame(int player1ID, int player2ID)
        {
            var game = new Game
            {
                StartTime = DateTime.Now,
                Status = "Active",
                Player1Id = player1ID,
                Player2Id = player2ID,
                TurnId = player1ID
            };
            try
            {
                _context.Games.Add(game);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Oyun oluşturulurken bir hata oluştu.", ex);
            }
        }

        public void EndGame(int gameID)
        {
            throw new NotImplementedException();
        }

        public void StartGame(int gameID)
        {
            throw new NotImplementedException();
        }
        public void Move()
        {
            throw new NotImplementedException();
        }
        public void BuyGood(int goodID, int quantity)
        {
            throw new NotImplementedException();
        }

        public void SellGood(int goodID, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}