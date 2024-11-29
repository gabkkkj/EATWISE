using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EatWise.Migrations
{
    /// <inheritdoc />
    public partial class migFf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Nutricionista",
                table: "Nutricionista");

            migrationBuilder.RenameTable(
                name: "Nutricionista",
                newName: "tbNutricionistas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbNutricionistas",
                table: "tbNutricionistas",
                column: "NutricionistaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbNutricionistas",
                table: "tbNutricionistas");

            migrationBuilder.RenameTable(
                name: "tbNutricionistas",
                newName: "Nutricionista");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nutricionista",
                table: "Nutricionista",
                column: "NutricionistaId");
        }
    }
}
