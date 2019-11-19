using System;

namespace TaxiApp.Models
{
    public class Location
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
