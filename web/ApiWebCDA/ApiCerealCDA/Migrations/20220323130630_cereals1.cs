using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCerealCDA.Migrations
{
    public partial class cereals1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Calories",
                table: "tata",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "Carbo",
                table: "tata",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "Fiber",
                table: "tata",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<short>(
                name: "Potass",
                table: "tata",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<byte>(
                name: "Protein",
                table: "tata",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "tata",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<short>(
                name: "Sodium",
                table: "tata",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<byte>(
                name: "Sugars",
                table: "tata",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "Vitamins",
                table: "tata",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calories",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Carbo",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Fiber",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Potass",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Protein",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Sodium",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Sugars",
                table: "tata");

            migrationBuilder.DropColumn(
                name: "Vitamins",
                table: "tata");
        }
    }
}
