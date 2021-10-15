using Gama.Locadora.Shared.Entities;
using System;

namespace Gama.Locadora.Comercial.Entities
{
    public class Rent : Entity
    {
        public decimal TotalPrice => Car.DiaryPrice * Days * Tax;
        public decimal Tax { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Days => (EndDate.Subtract(StartDate)).Days;
        public Customer Customer { get; set; }
        public Car Car { get; set; }
    }
}