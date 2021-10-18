
using Gama.Locadora.Shared.Entities;

namespace Gama.Locadora.Comercial.Entities
{
    public class Car : Entity
    {
        public CarModel Model { get; set; }
        public int YearModel { get; set; }
        public int YearManufactured { get; set; }
        public string Color { get; set; }
        public string LicensePlate { get; set; }
        public bool IsRented { get; set; }
        public decimal DiaryPrice { get; set; }
    }
}