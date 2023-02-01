using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Geo.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Points",
                table: "Points");

            migrationBuilder.RenameTable(
                name: "Points",
                newName: "points");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "points",
                newName: "location");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "points",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "voivodeship_id",
                table: "points",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "pk_points",
                table: "points",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "ix_points_voivodeship_id",
                table: "points",
                column: "voivodeship_id");

            migrationBuilder.AddForeignKey(
                name: "fk_points_voivodeships_voivodeship_id",
                table: "points",
                column: "voivodeship_id",
                principalTable: "wojewodztwa",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_points_voivodeships_voivodeship_id",
                table: "points");

            migrationBuilder.DropPrimaryKey(
                name: "pk_points",
                table: "points");

            migrationBuilder.DropIndex(
                name: "ix_points_voivodeship_id",
                table: "points");

            migrationBuilder.DropColumn(
                name: "voivodeship_id",
                table: "points");

            migrationBuilder.RenameTable(
                name: "points",
                newName: "Points");

            migrationBuilder.RenameColumn(
                name: "location",
                table: "Points",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Points",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Points",
                table: "Points",
                column: "Id");
        }
    }
}
