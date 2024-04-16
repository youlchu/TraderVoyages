using System.Collections.Generic;
using TraderVoyages.Application.DTOs;
using TraderVoyages.Domain.Entities;

namespace TraderVoyages.Application.Interfaces
{
    public interface IMountTypeService
    {
        IEnumerable<MountTypeDTO> GetMountTypes();
    }

}