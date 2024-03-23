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

        public async Task AddPlayer(Player player)
        {
            player.XCoordinate = new Random().Next(0, 100);
            player.YCoordinate = new Random().Next(0, 100);

            _context.Players.Add(player);
            await _context.SaveChangesAsync();
        }
    }
}
