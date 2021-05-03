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

        public CarContext(DbContextOptions<CarContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasIndex(b => b.Username)
                .IsUnique();

            modelBuilder.Entity<Car>()
                .HasIndex(b => b.RegistrationNumber)
                .IsUnique();
        }
    }
}
