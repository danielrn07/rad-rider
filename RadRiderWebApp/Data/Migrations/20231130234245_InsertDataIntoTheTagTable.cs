using Microsoft.EntityFrameworkCore.Migrations;
using RadRiderWebApp.Models;

#nullable disable

namespace RadRiderWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InsertDataIntoTheTagTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new SkateDbContext();
            context.Tag.AddRange(GetInitialLoadFromTagTable());
            context.SaveChanges();
        }

        private IList<Tag> GetInitialLoadFromTagTable()
        {
            return new List<Tag>()
            {
                new Tag() { Name = "LimitedEdition" },
                new Tag() { Name = "BestSeller" },
                new Tag() { Name = "EcoFriendly" },
                new Tag() { Name = "Premium" }
            };
        }
    }
}
