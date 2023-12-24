using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GasReact.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "fermentators",
                schema: "public",
                columns: table => new
                {
                    fermentator_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fermentator_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fermentators", x => x.fermentator_id);
                });

            migrationBuilder.CreateTable(
                name: "types_indicators",
                schema: "public",
                columns: table => new
                {
                    type_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type_name = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_types_indicators", x => x.type_id);
                });

            migrationBuilder.CreateTable(
                name: "records",
                schema: "public",
                columns: table => new
                {
                    record_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fermentator_id = table.Column<int>(type: "integer", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "indicators",
                schema: "public",
                columns: table => new
                {
                    indicator_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type_id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<decimal>(type: "numeric", nullable: false),
                    record_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_indicators", x => x.indicator_id);
                    table.ForeignKey(
                        name: "FK_indicators_records_record_id",
                        column: x => x.record_id,
                        principalSchema: "public",
                        principalTable: "records",
                        principalColumn: "record_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_indicators_types_indicators_type_id",
                        column: x => x.type_id,
                        principalSchema: "public",
                        principalTable: "types_indicators",
                        principalColumn: "type_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_indicators_record_id",
                schema: "public",
                table: "indicators",
                column: "record_id");

            migrationBuilder.CreateIndex(
                name: "IX_indicators_type_id",
                schema: "public",
                table: "indicators",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_records_fermentator_id",
                schema: "public",
                table: "records",
                column: "fermentator_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "indicators",
                schema: "public");

            migrationBuilder.DropTable(
                name: "records",
                schema: "public");

            migrationBuilder.DropTable(
                name: "types_indicators",
                schema: "public");

            migrationBuilder.DropTable(
                name: "fermentators",
                schema: "public");
        }
    }
}
