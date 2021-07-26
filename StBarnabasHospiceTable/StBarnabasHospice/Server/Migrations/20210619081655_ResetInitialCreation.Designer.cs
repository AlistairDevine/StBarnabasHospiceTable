﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StBarnabasHospice.Server.Data;

namespace StBarnabasHospice.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210619081655_ResetInitialCreation")]
    partial class ResetInitialCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StBarnabasHospice.Shared.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Description = "A cup of tea, drink. With or without milk and sugar.",
                            Image = "https://www.google.fr/url?sa=i&url=https%3A%2F%2Fwhittockconsulting.co.uk%2Fhow-to-make-a-cup-of-tea%2F&psig=AOvVaw2bUKdi5eIZt1EuZ8qEsd_4&ust=1597851497342000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCKDVr-qKpesCFQAAAAAdAAAAABAK",
                            Name = "Tea"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The need to go to the bathroom and use the toilet.",
                            Image = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.thenounproject.com%2Fpng%2F26699-200.png&imgrefurl=https%3A%2F%2Fthenounproject.com%2Fterm%2Ftoilet%2F&tbnid=7GxdVNovZBUOAM&vet=12ahUKEwjEtPDji6XrAhVFLxoKHVBXDeYQMygVegUIARCYAg..i&docid=t0BzIWpzrYICkM&w=200&h=200&q=toilet%20icon&ved=2ahUKEwjEtPDji6XrAhVFLxoKHVBXDeYQMygVegUIARCYAg",
                            Name = "Toilet"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The need for some food and to eat.",
                            Image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.iconfinder.com%2Ficons%2F3382571%2Ffood_restaurant_travel_icon&psig=AOvVaw2HqX5KUvcvix38EhOy2qDF&ust=1597851829268000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCIj8lYiMpesCFQAAAAAdAAAAABAE",
                            Name = "Food"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Cat food.",
                            Image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.iconfinder.com%2Ficons%2F3382571%2Ffood_restaurant_travel_icon&psig=AOvVaw2HqX5KUvcvix38EhOy2qDF&ust=1597851829268000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCIj8lYiMpesCFQAAAAAdAAAAABAE",
                            Name = "Pet Food"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Kitty cat food.",
                            Image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.iconfinder.com%2Ficons%2F3382571%2Ffood_restaurant_travel_icon&psig=AOvVaw2HqX5KUvcvix38EhOy2qDF&ust=1597851829268000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCIj8lYiMpesCFQAAAAAdAAAAABAE",
                            Name = "Kitty Cat Food"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}