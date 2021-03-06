using Microsoft.EntityFrameworkCore;
using Workshop.Entities;

namespace Workshop.DataAccess
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Request> Requests { get; set; }
        public Employee currentUser { get; set; }

        public CarContext(DbContextOptions<CarContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasIndex(b => b.Username)
                .IsUnique();

            modelBuilder.Entity<Car>()
                .HasIndex(b => b.RegistrationNumber)
                .IsUnique();

            modelBuilder.Entity<Request>()
                .HasOne(r => r.Manager)
                .WithMany(e => e.Requests)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Requests)
                .WithOne(r => r.Manager)
                .OnDelete(DeleteBehavior.NoAction);

            AddFilters(modelBuilder);
        }

        private static void AddFilters(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasQueryFilter(p => p.IsHidden == false);
            modelBuilder.Entity<Car>().HasQueryFilter(p => p.IsHidden == false);
            modelBuilder.Entity<Request>().HasQueryFilter(p => p.IsHidden == false);
            modelBuilder.Entity<Activity>().HasQueryFilter(p => p.IsHidden == false);
            modelBuilder.Entity<ActivityType>().HasQueryFilter(p => p.IsHidden == false);
            modelBuilder.Entity<CarType>().HasQueryFilter(p => p.IsHidden == false);
            modelBuilder.Entity<Client>().HasQueryFilter(p => p.IsHidden == false);
            modelBuilder.Entity<Request>().HasQueryFilter(p => p.IsHidden == false);
        }

    }
}
