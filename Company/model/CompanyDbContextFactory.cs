using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Company.model
{
    public class CompanyContextFactory : IDesignTimeDbContextFactory<CompanyDbContext> {
        public CompanyDbContext CreateDbContext(string[] args) {
            var properties = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var optionsBuilder = new DbContextOptionsBuilder<CompanyDbContext>();

            optionsBuilder
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                .UseMySql(
                    properties["ConnectionStrings:DefaultConnection"],
                    new MySqlServerVersion(new Version(8,0,23)),
                    null
                );

            return new CompanyDbContext(optionsBuilder.Options);
        }
    }
}