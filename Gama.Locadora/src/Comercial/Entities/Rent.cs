using Gama.Locadora.Shared.Entities;
using System;

namespace Gama.Locadora.Comercial.Entities
{
    public class Rent : Entity
    {
        private Rent()
        {

        }

        public Rent(decimal tax, DateTime startDate, DateTime endDate, Guid customerId, Guid carId)
        {
            Tax = tax;
            StartDate = startDate;
            EndDate = endDate;
            CustomerId = customerId;
            CarId = carId;
            CalcPrice();
        }

        public decimal Price { get; private set; }
        public decimal Tax { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Customer Customer { get; set; }

        public Guid CustomerId { get; set; }

        public Car Car { get; set; }

        public Guid CarId { get; set; }


        public decimal CalcPrice()
        {
            return Car.DiaryPrice * DiffDays() * Tax;
        }

        public int DiffDays()
        {
            return (EndDate.Subtract(StartDate)).Days;
        }        
    }
}