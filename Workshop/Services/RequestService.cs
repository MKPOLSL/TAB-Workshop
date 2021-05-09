using Workshop.DataAccess;
using Workshop.Entities;
using Workshop.Interfaces.Services;
using Workshop.Services.Base;

namespace Workshop.Services
{
    public class RequestService : ServiceBase<Request>, IRequestService
    {
        public RequestService(CarContext context) : base(context) { }
    }
}
