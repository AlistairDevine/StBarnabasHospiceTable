using Microsoft.EntityFrameworkCore.Migrations;

namespace StBarnabasHospiceTable.Server.Migrations
{
    public partial class DatabaseSeedInput : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://www.google.fr/url?sa=i&url=https%3A%2F%2Fwhittockconsulting.co.uk%2Fhow-to-make-a-cup-of-tea%2F&psig=AOvVaw2bUKdi5eIZt1EuZ8qEsd_4&ust=1597851497342000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCKDVr-qKpesCFQAAAAAdAAAAABAK");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.thenounproject.com%2Fpng%2F26699-200.png&imgrefurl=https%3A%2F%2Fthenounproject.com%2Fterm%2Ftoilet%2F&tbnid=7GxdVNovZBUOAM&vet=12ahUKEwjEtPDji6XrAhVFLxoKHVBXDeYQMygVegUIARCYAg..i&docid=t0BzIWpzrYICkM&w=200&h=200&q=toilet%20icon&ved=2ahUKEwjEtPDji6XrAhVFLxoKHVBXDeYQMygVegUIARCYAg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.iconfinder.com%2Ficons%2F3382571%2Ffood_restaurant_travel_icon&psig=AOvVaw2HqX5KUvcvix38EhOy2qDF&ust=1597851829268000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCIj8lYiMpesCFQAAAAAdAAAAABAE");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.iconfinder.com%2Ficons%2F3382571%2Ffood_restaurant_travel_icon&psig=AOvVaw2HqX5KUvcvix38EhOy2qDF&ust=1597851829268000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCIj8lYiMpesCFQAAAAAdAAAAABAE");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.iconfinder.com%2Ficons%2F3382571%2Ffood_restaurant_travel_icon&psig=AOvVaw2HqX5KUvcvix38EhOy2qDF&ust=1597851829268000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCIj8lYiMpesCFQAAAAAdAAAAABAE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "");
        }
    }
}
