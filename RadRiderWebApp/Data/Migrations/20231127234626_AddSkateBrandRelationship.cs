using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RadRiderWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSkateBrandRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Skate",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skate_BrandId",
                table: "Skate",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skate_Brand_BrandId",
                table: "Skate",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "BrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skate_Brand_BrandId",
                table: "Skate");

            migrationBuilder.DropIndex(
                name: "IX_Skate_BrandId",
                table: "Skate");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Skate");
        }
    }
}
