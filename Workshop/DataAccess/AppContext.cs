﻿using Microsoft.EntityFrameworkCore;

namespace Workshop.DataAccess
{
    public class AppContext : DbContext
    {
        public AppContext() { }

        public AppContext(DbContextOptions<AppContext> options) : base(options) { }
    }
}
