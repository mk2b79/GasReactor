using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GasReact.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Refactoring_Table_records_To_node : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_indicators_records_record_id",
                schema: "public",
                table: "indicators");

            migrationBuilder.DropTable(
                name: "records",
                schema: "public");

            migrationBuilder.CreateTable(
                name: "node",
                schema: "public",
                columns: table => new
                {
                    record_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fermentator_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_node", x => x.record_id);
                    table.ForeignKey(
                        name: "FK_node_fermentators_fermentator_id",
                        column: x => x.fermentator_id,
                        principalSchema: "public",
                        principalTable: "fermentators",
                        principalColumn: "fermentator_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_node_fermentator_id",
                schema: "public",
                table: "node",
                column: "fermentator_id");

            migrationBuilder.AddForeignKey(
                name: "FK_indicators_node_record_id",
                schema: "public",
                table: "indicators",
                column: "record_id",
                principalSchema: "public",
                principalTable: "node",
                principalColumn: "record_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_indicators_node_record_id",
                schema: "public",
                table: "indicators");

            migrationBuilder.DropTable(
                name: "node",
                schema: "public");

            migrationBuilder.CreateTable(
                name: "records",
                schema: "public",
                columns: table => new
                {
                    record_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fermentator_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_records", x => x.record_id);
                    table.ForeignKey(
                        name: "FK_records_fermentators_fermentator_id",
                        column: x => x.fermentator_id,
                        principalSchema: "public",
                        principalTable: "fermentators",
                        principalColumn: "fermentator_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_records_fermentator_id",
                schema: "public",
                table: "records",
                column: "fermentator_id");

            migrationBuilder.AddForeignKey(
                name: "FK_indicators_records_record_id",
                schema: "public",
                table: "indicators",
                column: "record_id",
                principalSchema: "public",
                principalTable: "records",
                principalColumn: "record_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
