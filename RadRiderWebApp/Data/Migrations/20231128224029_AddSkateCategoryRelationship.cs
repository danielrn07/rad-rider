using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RadRiderWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSkateCategoryRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Skate");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Skate",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skate_CategoryId",
                table: "Skate",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skate_Category_CategoryId",
                table: "Skate",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skate_Category_CategoryId",
                table: "Skate");

            migrationBuilder.DropIndex(
                name: "IX_Skate_CategoryId",
                table: "Skate");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Skate");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Skate",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
