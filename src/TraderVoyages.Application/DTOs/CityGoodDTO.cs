// src/TraderVoyages.Application/DTOs/PlayerDTO.cs
using TraderVoyages.Domain.Entities;

namespace TraderVoyages.Application.DTOs
{
    public class CityGoodDto
    {
        public int CityGoodID { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }
        public int GoodID { get; set; }
        public Good Good { get; set; } // Bu satırı ekleyin
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
    }

    public class CityGoodsDTO
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public List<GoodPriceDTO> Goods { get; set; }
    }

    public class GoodPriceDTO
    {
        public int GoodID { get; set; }
        public string GoodName { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
    }
}
