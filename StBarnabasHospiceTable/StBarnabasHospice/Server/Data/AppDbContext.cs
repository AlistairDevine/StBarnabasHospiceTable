using Microsoft.EntityFrameworkCore;
using StBarnabasHospice.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace StBarnabasHospice.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //DbSet, Database tables
        public DbSet<Item> Items { get; set; }

        //Dummy, initial data input for static output page
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Categories
            //Button trigger for easy items to be placed in the table cell

            //Item entities
            modelBuilder.Entity<Item>().HasData(new List<Item>()
            {
                new Item()
                {
                    //Item values
                    Name = "Tea",
                    Id = 2,
                    Description = "A cup of tea, drink. With or without milk and sugar.",
                    Image = "https://www.google.fr/url?sa=i&url=https%3A%2F%2Fwhittockconsulting.co.uk%2Fhow-to-make-a-cup-of-tea%2F&psig=AOvVaw2bUKdi5eIZt1EuZ8qEsd_4&ust=1597851497342000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCKDVr-qKpesCFQAAAAAdAAAAABAK"
                },
                new Item()
                {
                    //Item values
                    Name = "Toilet",
                    Id = 3,
                    Description = "The need to go to the bathroom and use the toilet.",
                    Image = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.thenounproject.com%2Fpng%2F26699-200.png&imgrefurl=https%3A%2F%2Fthenounproject.com%2Fterm%2Ftoilet%2F&tbnid=7GxdVNovZBUOAM&vet=12ahUKEwjEtPDji6XrAhVFLxoKHVBXDeYQMygVegUIARCYAg..i&docid=t0BzIWpzrYICkM&w=200&h=200&q=toilet%20icon&ved=2ahUKEwjEtPDji6XrAhVFLxoKHVBXDeYQMygVegUIARCYAg"
                },
                new Item()
                {
                    //Item values
                    Name = "Food",
                    Id = 4,
                    Description = "The need for some food and to eat.",
                    Image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.iconfinder.com%2Ficons%2F3382571%2Ffood_restaurant_travel_icon&psig=AOvVaw2HqX5KUvcvix38EhOy2qDF&ust=1597851829268000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCIj8lYiMpesCFQAAAAAdAAAAABAE"
                },
                new Item()
                {
                    //Item values
                    Name = "Pet Food",
                    Id = 5,
                    Description = "Cat food.",
                    Image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.iconfinder.com%2Ficons%2F3382571%2Ffood_restaurant_travel_icon&psig=AOvVaw2HqX5KUvcvix38EhOy2qDF&ust=1597851829268000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCIj8lYiMpesCFQAAAAAdAAAAABAE"
                },
                new Item()
                {
                    //Item values
                    Name = "Kitty Cat Food",
                    Id = 6,
                    Description = "Kitty cat food.",
                    Image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.iconfinder.com%2Ficons%2F3382571%2Ffood_restaurant_travel_icon&psig=AOvVaw2HqX5KUvcvix38EhOy2qDF&ust=1597851829268000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCIj8lYiMpesCFQAAAAAdAAAAABAE"
                },
            });
        }
    }
}
