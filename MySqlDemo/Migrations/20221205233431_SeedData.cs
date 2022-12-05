using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySqlDemo.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Brand1" },
                    { 2, "Brand2" },
                    { 3, "Brand3" },
                    { 4, "Brand4" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorHex", "ColorName" },
                values: new object[,]
                {
                    { 1, "ColorHex1", "ColorName1" },
                    { 2, "ColorHex2", "ColorName2" },
                    { 3, "ColorHex3", "ColorName3" },
                    { 4, "ColorHex4", "ColorName4" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BrandId", "ColorId", "Name" },
                values: new object[,]
                {
                    { 1, 1, 1, "Car1" },
                    { 2, 2, 2, "Car2" },
                    { 3, 3, 3, "Car3" },
                    { 4, 4, 4, "Car4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
