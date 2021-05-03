using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.DataAccess;
using Workshop.Entities;
using Workshop.Interfaces.Repositories;
using Workshop.Repositories.Base;

namespace Workshop.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(CarContext context) : base(context) { }
    }
}
