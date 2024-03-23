namespace TraderVoyages.Domain.Entities
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public decimal Money { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public int CurrentCityID { get; set; }
        public int MountTypeID { get; set; }
    }

}
