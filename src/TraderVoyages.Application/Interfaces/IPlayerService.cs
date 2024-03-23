using TraderVoyages.Domain.Entities;

namespace TraderVoyages.Application.Interfaces
{
    public interface IPlayerService
    {
        List<Player> GetPlayers();
        Task AddPlayer(Player player);
    }
}
