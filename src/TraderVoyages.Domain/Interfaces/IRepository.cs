
namespace TraderVoyages.Domain.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task AddAsync(T entity);
    }
}
