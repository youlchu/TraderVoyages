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

        public ICollection<PlayerGood> PlayerGoods { get; set; }

    }
    public class PlayerGood
    {
        public int PlayerID { get; set; }
        public Player Player { get; set; }

        public int GoodID { get; set; }
        public Good Good { get; set; }

        public int Quantity { get; set; }
    }
}
