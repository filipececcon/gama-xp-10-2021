
using System;
using System.Collections.Generic;
using Gama.Locadora.Comercial.ValueObjects;
using Gama.Locadora.Shared.Entities;

namespace Gama.Locadora.Comercial.Entities
{
    public class Car : Entity
    {
        private Car()
        {

        }

        public Car(Guid modelId, int yearModel, int yearManufactured, string color, LicensePlate licensePlate, bool isRented, decimal diaryPrice)
        {
            
            ModelId = modelId;
            YearModel = yearModel;
            YearManufactured = yearManufactured;
            Color = color;
            LicensePlate = licensePlate;
            IsRented = isRented;
            DiaryPrice = diaryPrice;
            
        }

        public CarModel Model { get; set; }
        public Guid ModelId { get; set; }

        public int YearModel { get; set; }
        public int YearManufactured { get; set; }
        public string Color { get; set; }

        public LicensePlate LicensePlate { get; set; }

        public bool IsRented { get; set; }
        public decimal DiaryPrice { get; set; }

        public List<Rent> Rents { get; set; }
    }
}