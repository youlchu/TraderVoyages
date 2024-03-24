using TraderVoyages.Domain.Entities;

namespace TraderVoyages.Application.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Status { get; set; }
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public int TurnId { get; set; }

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

    }
}