using TraderVoyages.Domain.Entities;

namespace TraderVoyages.Application.Interfaces
{
    public interface IPlayerService
    {
        Task AddPlayer(Player player);
    }
}
