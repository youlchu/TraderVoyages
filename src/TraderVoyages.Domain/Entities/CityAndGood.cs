

namespace TraderVoyages.Domain.Entities
{

    public class City
    {
        public int CityID { get; set; }
        public string Name { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public ICollection<CityGood> CityGoods { get; set; }
    }

    public class CityGood
    {
        public int CityGoodID { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }
        public int GoodID { get; set; }
        public Good Good { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Quantity { get; set; }
    }

}
