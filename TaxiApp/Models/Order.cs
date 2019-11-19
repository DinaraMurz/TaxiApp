using System;

namespace TaxiApp.Models
{
    public enum OrderState
    {
        Open,
        InProcess,
        Closed
    }
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Client Client { get; set; }
        public Location LocationFrom { get; set; }
        public Location LocationTo { get; set; }
        public double Price { get; set; }
        public string Number { get; set; }
        public OrderState State { get; set; }
        public Driver Driver { get; set; }
    }
}
