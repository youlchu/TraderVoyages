using TraderVoyages.Application.Interfaces;
using TraderVoyages.Domain.Entities;
using TraderVoyages.Infrastructure.Data;

namespace TraderVoyages.Application.Services
{
    public class PlayerService : IPlayerService
    {

        private readonly ApplicationDbContext _context;

        public PlayerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Player> GetPlayers()
        {
            return _context.Players.ToList();
        }

        public async Task AddPlayer(Player player)
        {

            if (player.CurrentCityID == 0)
            {
                player.XCoordinate = new Random().Next(0, 100);
                player.YCoordinate = new Random().Next(0, 100);

            }
            else
            {
                var city = _context.Cities.FirstOrDefault(c => c.CityID == player.CurrentCityID);
                player.XCoordinate = city.XCoordinate;
                player.YCoordinate = city.YCoordinate;
            }
            player.Money = 500;
            _context.Players.Add(player);
            await _context.SaveChangesAsync();
        }
    }
}
