using Microsoft.EntityFrameworkCore.Migrations;
using RadRiderWebApp.Models;

#nullable disable

namespace RadRiderWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InsertDataIntoTheSkateModelTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new SkateDbContext();
            context.SkateModel.AddRange(GetInitialLoadFromSkateModelTable());
            context.SaveChanges();
        }

        private IList<SkateModel> GetInitialLoadFromSkateModelTable()
        {
            return new List<SkateModel>()
            {
                new SkateModel() { Name = "Skateboard" },
                new SkateModel() { Name = "Longboard" },
                new SkateModel() { Name = "Cruiser" },
                new SkateModel() { Name = "Waveboard" }
            };
        }
    }
}
