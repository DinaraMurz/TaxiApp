using System;

namespace TaxiApp.Models
{
    public class Client
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
    }
}
