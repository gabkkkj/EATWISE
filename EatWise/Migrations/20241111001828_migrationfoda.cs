using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EatWise.Migrations
{
    /// <inheritdoc />
    public partial class migrationfoda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "tbusuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "tbusuario");
        }
    }
}
