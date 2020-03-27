using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TreatShop.Models
{
  public class TreatShopContextFactory : IDesignTimeDbContextFactory<TreatShopContext>
  {
    TreatShopContext IDesignTimeDbContextFactory<TreatShopContext>.CreateDbContext(string[] arg)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<TreatShopContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new TreatShopContext(builder.Options);
    }
  }
}