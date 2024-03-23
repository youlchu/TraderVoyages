namespace TraderVoyages.Domain.Entities
{
    public class City
    {
        public int CityID { get; set; }
        public string Name { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        // public ICollection<CityGood> CityGoods { get; set; }
    }

}
