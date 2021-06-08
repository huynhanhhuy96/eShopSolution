namespace eShopSolution.Data.EF
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.Extensions.Configuration;
    using System.IO;

    public class EShopSolutionDbContextFactory : IDesignTimeDbContextFactory<EShopDbContext>
    {
        public EShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("eShopSolutionDb");

            var optionBuilder = new DbContextOptionsBuilder<EShopDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new EShopDbContext(optionBuilder.Options);
        }
    }
}
