using TraderVoyages.Application.DTOs;
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

    public IEnumerable<MountTypeDTO> GetMountTypes()
    {
        return _context.MountTypes.Select(m => new MountTypeDTO
        {
            Name = m.Name,
            CarryCapacity = m.CarryCapacity,
            StepCapacity = m.StepCapacity
        }).ToList();
    }
}
