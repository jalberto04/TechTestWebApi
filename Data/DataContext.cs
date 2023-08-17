using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using TechTestWebApi.Models;

namespace TechTestWebApi.Data
{
  public class DataContext : DbContext
  {
    public DbSet<Product> Products => Set<Product>();

    public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().HasData(GetProducts());
    }

    private static IEnumerable<Product> GetProducts()
    {
        string[] p = { Directory.GetCurrentDirectory(), "Data/Seed", "products.csv" };
        var csvFilePath = Path.Combine(p);

        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
          PrepareHeaderForMatch = args => args.Header.ToLower(),
        };

        var data = new List<Product>().AsEnumerable();
        using (var reader = new StreamReader(csvFilePath))
        {
          using (var csvReader = new CsvReader(reader, config))
          {
            data = (csvReader.GetRecords<Product>()).ToList();
          }
        }
        return data;
    }
  }
}