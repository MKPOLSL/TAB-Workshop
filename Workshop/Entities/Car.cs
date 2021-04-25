using System;
using System.Collections.Generic;
using Workshop.Enums;

namespace Workshop.Entities
{
    public class Car : Entity
    {
        public Guid Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public CarType CarType { get; set; }

        public virtual Client Client { get; set; }
        public virtual IEnumerable<Request> Requests { get; set; }
    }
}