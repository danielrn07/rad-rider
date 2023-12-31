using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RadRiderWebApp.Models;

namespace RadRiderWebApp.Data;

public class SkateDbContext : IdentityDbContext
{
    public DbSet<Skate> Skate { get; set; }
    public DbSet<Brand> Brand { get; set; }
    public DbSet<SkateModel> SkateModel { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Tag> Tag { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var stringConn = config.GetConnectionString("StringConn");

        optionsBuilder.UseSqlite(stringConn);
    }
}