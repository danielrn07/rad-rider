using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RadRiderWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSkateModelRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "Skate");

            migrationBuilder.RenameColumn(
                name: "ModelId",
                table: "SkateModel",
                newName: "SkateModelId");

            migrationBuilder.AddColumn<int>(
                name: "SkateModelId",
                table: "Skate",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skate_SkateModelId",
                table: "Skate",
                column: "SkateModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skate_SkateModel_SkateModelId",
                table: "Skate",
                column: "SkateModelId",
                principalTable: "SkateModel",
                principalColumn: "SkateModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skate_SkateModel_SkateModelId",
                table: "Skate");

            migrationBuilder.DropIndex(
                name: "IX_Skate_SkateModelId",
                table: "Skate");

            migrationBuilder.DropColumn(
                name: "SkateModelId",
                table: "Skate");

            migrationBuilder.RenameColumn(
                name: "SkateModelId",
                table: "SkateModel",
                newName: "ModelId");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Skate",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
