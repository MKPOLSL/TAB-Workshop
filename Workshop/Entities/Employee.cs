using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Enums;

namespace Workshop.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }

        public virtual IEnumerable<Request> Requests { get; set; }
        public virtual IEnumerable<Activity> Activities { get; set; }
    }
}
