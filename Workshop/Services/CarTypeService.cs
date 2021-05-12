using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.DataAccess;
using Workshop.Entities;
using Workshop.Interfaces;
using Workshop.Services.Base;
using Workshop.Utils;

namespace Workshop.Services
{
    public class CarTypeService : ServiceBase<CarType>, ICarTypeService
    {
        public CarTypeService(CarContext context) : base(context) { }

        public async Task<CarType> GetTypeByCode(string code)
        {
            return await Context
                .Set<CarType>()
                .GetAllNotHidden()
                .Where(ct => ct.Code == code)
                .FirstOrDefaultAsync();
        }
    }
}
