using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Enums;

namespace Workshop.Utils
{
    public static class Badges
    {
        public static string GetBadge(Status status) => status switch
        {
            Status.Pending => "secondary",
            Status.InProgress => "warning",
            Status.Finished => "success",
            Status.Canceled => "danger",
            _ => "dark"
        };

        public static string GetBadge(Role role) => role switch
        {
            Role.Administrator => "secondary",
            Role.Manager => "warning",
            Role.Worker => "success",
            _ => "dark"
        };
    }
}
