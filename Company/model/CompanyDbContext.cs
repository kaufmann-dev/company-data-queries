using Microsoft.EntityFrameworkCore;

namespace Company.model
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options){}
        
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // The Entity Framework Core Fluent API HasIndex method is used to create a database index on the column mapped to the specified entity property.
            builder.Entity<Company>()
                .HasIndex(e => e.Name)
                .IsUnique();

            builder.Entity<Product>()
                .HasIndex(e => e.Name)
                .IsUnique();
            
            // Ein Employee hat einen Vorgesetzten
            // Ein Employee kann für mehrere andere Employee Vorgesetzter sein
            builder.Entity<Employee>()
                .HasOne(e => e.Superior)
                .WithMany()
                .HasForeignKey(e=>e.SuperiorId);
        }
    }
}