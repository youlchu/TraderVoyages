using TraderVoyages.Infrastructure.Data;
using TraderVoyages.Domain.Interfaces;


namespace TraderVoyages.Infrastructure.Repositories
{

    public class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }
    }
}
