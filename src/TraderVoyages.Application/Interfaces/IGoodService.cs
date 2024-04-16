using System.Collections.Generic;
using TraderVoyages.Application.DTOs;
using TraderVoyages.Domain.Entities;

namespace TraderVoyages.Application.Interfaces
{
    public interface IGoodService
    {
        List<GoodDto> GetGoods();

    }
}