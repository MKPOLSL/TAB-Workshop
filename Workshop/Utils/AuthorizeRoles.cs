using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Enums;

namespace Workshop.Utils
{
    public class AuthorizeRoles : AuthorizeAttribute
    {
        public AuthorizeRoles(params Role[] roles)
        {
            Roles = string.Join(",", Enum.GetNames(typeof(Role)));
        }
    }
}
