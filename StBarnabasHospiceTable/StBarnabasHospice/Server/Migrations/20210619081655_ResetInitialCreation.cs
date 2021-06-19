using Microsoft.EntityFrameworkCore.Migrations;

namespace StBarnabasHospice.Server.Migrations
{
    public partial class ResetInitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Image", "Name" },
                values: new object[,]
                {
                    { 2, "A cup of tea, drink. With or without milk and sugar.", "https://www.google.fr/url?sa=i&url=https%3A%2F%2Fwhittockconsulting.co.uk%2Fhow-to-make-a-cup-of-tea%2F&psig=AOvVaw2bUKdi5eIZt1EuZ8qEsd_4&ust=1597851497342000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCKDVr-qKpesCFQAAAAAdAAAAABAK", "Tea" },
                    { 3, "The need to go to the bathroom and use the toilet.", "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.thenounproject.com%2Fpng%2F26699-200.png&imgrefurl=https%3A%2F%2Fthenounproject.com%2Fterm%2Ftoilet%2F&tbnid=7GxdVNovZBUOAM&vet=12ahUKEwjEtPDji6XrAhVFLxoKHVBXDeYQMygVegUIARCYAg..i&docid=t0BzIWpzrYICkM&w=200&h=200&q=toilet%20icon&ved=2ahUKEwjEtPDji6XrAhVFLxoKHVBXDeYQMygVegUIARCYAg", "Toilet" },
                    { 4, "The need for some food and to eat.", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.iconfinder.com%2Ficons%2F3382571%2Ffood_restaurant_travel_icon&psig=AOvVaw2HqX5KUvcvix38EhOy2qDF&ust=1597851829268000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCIj8lYiMpesCFQAAAAAdAAAAABAE", "Food" },
                    { 5, "Cat food.", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.iconfinder.com%2Ficons%2F3382571%2Ffood_restaurant_travel_icon&psig=AOvVaw2HqX5KUvcvix38EhOy2qDF&ust=1597851829268000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCIj8lYiMpesCFQAAAAAdAAAAABAE", "Pet Food" },
                    { 6, "Kitty cat food.", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.iconfinder.com%2Ficons%2F3382571%2Ffood_restaurant_travel_icon&psig=AOvVaw2HqX5KUvcvix38EhOy2qDF&ust=1597851829268000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCIj8lYiMpesCFQAAAAAdAAAAABAE", "Kitty Cat Food" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
