using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GasReact.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Refactoring_Table_node_To_nodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_indicators_node_record_id",
                schema: "public",
                table: "indicators");

            migrationBuilder.DropForeignKey(
                name: "FK_node_fermentators_fermentator_id",
                schema: "public",
                table: "node");

            migrationBuilder.DropPrimaryKey(
                name: "PK_node",
                schema: "public",
                table: "node");

            migrationBuilder.RenameTable(
                name: "node",
                schema: "public",
                newName: "nodes",
                newSchema: "public");

            migrationBuilder.RenameIndex(
                name: "IX_node_fermentator_id",
                schema: "public",
                table: "nodes",
                newName: "IX_nodes_fermentator_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nodes",
                schema: "public",
                table: "nodes",
                column: "record_id");

            migrationBuilder.AddForeignKey(
                name: "FK_indicators_nodes_record_id",
                schema: "public",
                table: "indicators",
                column: "record_id",
                principalSchema: "public",
                principalTable: "nodes",
                principalColumn: "record_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_nodes_fermentators_fermentator_id",
                schema: "public",
                table: "nodes",
                column: "fermentator_id",
                principalSchema: "public",
                principalTable: "fermentators",
                principalColumn: "fermentator_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_indicators_nodes_record_id",
                schema: "public",
                table: "indicators");

            migrationBuilder.DropForeignKey(
                name: "FK_nodes_fermentators_fermentator_id",
                schema: "public",
                table: "nodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_nodes",
                schema: "public",
                table: "nodes");

            migrationBuilder.RenameTable(
                name: "nodes",
                schema: "public",
                newName: "node",
                newSchema: "public");

            migrationBuilder.RenameIndex(
                name: "IX_nodes_fermentator_id",
                schema: "public",
                table: "node",
                newName: "IX_node_fermentator_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_node",
                schema: "public",
                table: "node",
                column: "record_id");

            migrationBuilder.AddForeignKey(
                name: "FK_indicators_node_record_id",
                schema: "public",
                table: "indicators",
                column: "record_id",
                principalSchema: "public",
                principalTable: "node",
                principalColumn: "record_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_node_fermentators_fermentator_id",
                schema: "public",
                table: "node",
                column: "fermentator_id",
                principalSchema: "public",
                principalTable: "fermentators",
                principalColumn: "fermentator_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
