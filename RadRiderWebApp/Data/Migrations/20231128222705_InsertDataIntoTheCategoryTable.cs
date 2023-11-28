using Microsoft.EntityFrameworkCore.Migrations;
using RadRiderWebApp.Models;

#nullable disable

namespace RadRiderWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InsertDataIntoTheCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new SkateDbContext();
            context.Category.AddRange(GetInitialLoadFromCategoryTable());
            context.SaveChanges();
        }

        private IList<Category> GetInitialLoadFromCategoryTable()
        {
            return new List<Category>()
            {
                new Category() { Name = "Iniciante" },
                new Category() { Name = "Intermediário" },
                new Category() { Name = "Profissional" }
            };
        }
    }
}