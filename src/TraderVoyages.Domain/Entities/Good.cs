using System.ComponentModel.DataAnnotations.Schema;

namespace TraderVoyages.Domain.Entities
{
    public class Good

    {
        public int GoodID { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public ICollection<PlayerGood> PlayerGoods { get; set; }
        public ICollection<CityGood> CityGoods { get; set; }

    }
}
