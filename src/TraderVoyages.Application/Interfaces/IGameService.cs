using System.Collections.Generic;
using TraderVoyages.Application.DTOs;
using TraderVoyages.Domain.Entities;

namespace TraderVoyages.Application.Interfaces
{
    public interface IGameService
    {
        List<GameDTO> GetAllGames();
        void CreateGame(int player1ID, int player2ID);
        void EndGame(int gameID);
        void StartGame(int gameID);


        void Move();
        void BuyGood(int goodID, int quantity);
        void SellGood(int goodID, int quantity);


    }
}