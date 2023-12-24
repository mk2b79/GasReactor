using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GasReact.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTypeNameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "type_name",
                schema: "public",
                table: "types_indicators",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "type_name",
                schema: "public",
                table: "types_indicators",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
