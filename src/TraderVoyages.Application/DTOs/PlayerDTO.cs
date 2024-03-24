// src/TraderVoyages.Application/DTOs/PlayerDTO.cs
namespace TraderVoyages.Application.DTOs
{
    public class PlayerDTO
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public decimal Money { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public int CurrentCityID { get; set; }
        public int MountTypeID { get; set; }
    }

    public class CreatePlayerDto
    {
        public string Name { get; set; }
        public int CurrentCityID { get; set; }
        public int MountTypeID { get; set; }

    }
}




