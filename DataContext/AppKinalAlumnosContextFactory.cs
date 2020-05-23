using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace  AppKinalAlumnos.DataContext

{
    public class AppKinalAlumnosContextFactory
    {
         public AppKinalAlumnosDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var optionBuilder = new DbContextOptionsBuilder<AppKinalAlumnosDbContext>();            
            optionBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));               
            return new AppKinalAlumnosDbContext(optionBuilder.Options);
        }
    }
}