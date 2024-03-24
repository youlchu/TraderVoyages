using System;
using TraderVoyages.Application.DTOs;
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

        public void CreateGame(int player1ID, int player2ID)
        {
            throw new NotImplementedException();
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