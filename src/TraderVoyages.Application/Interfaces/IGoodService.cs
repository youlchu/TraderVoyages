using System.Collections.Generic;
using TraderVoyages.Domain.Entities;

namespace TraderVoyages.Application.Interfaces
{
    public interface IGoodService
    {
        List<Good> GetGoods();

    }
}