

namespace TraderVoyages.Domain.Entities
{
    public class CityGood
    {
        public int CityGoodID { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }
        public int GoodID { get; set; }
        public Good Good { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
    }


    public class CityGoods
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public List<GoodPrice> Goods { get; set; }
    }

    public class GoodPrice
    {
        public int GoodID { get; set; }
        public string GoodName { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
    }

}
