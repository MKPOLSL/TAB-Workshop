using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Entities;

namespace Workshop.Utils
{
    //for ordering, sorting, getting not hidden entities
    public static class QueryExtensions
    {
        public static IQueryable<T> GetAllNotHidden<T>(this IQueryable<T> queryable) where T : HideableEntity => queryable.Where(e => !e.IsHidden);
    }
}
