using TraderVoyages.Application.Interfaces;
using TraderVoyages.Domain.Entities;
using TraderVoyages.Infrastructure.Data;

public class MountTypeService : IMountTypeService
{
    private readonly ApplicationDbContext _context;

    public MountTypeService(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<MountType> GetMountTypes()
    {
        return _context.MountTypes.ToList();
    }
}
