using Microsoft.EntityFrameworkCore.Migrations;
using RadRiderWebApp.Models;

#nullable disable

namespace RadRiderWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InsertDataIntoTheBrandTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new SkateDbContext();
            context.Brand.AddRange(GetInitialLoadFromBrandTable());
            context.SaveChanges();
        }

        private IList<Brand> GetInitialLoadFromBrandTable()
        {
            return new List<Brand>()
            {
                new Brand() { Name = "RadRider" },
                new Brand() { Name = "Primor Skateboards" },
                new Brand() { Name = "Revenge" },
                new Brand() { Name = "Thunder Trucks" },
                new Brand() { Name = "Core" },
                new Brand() { Name = "Champion" },
                new Brand() { Name = "Seven" }
            };
        }
    }
}