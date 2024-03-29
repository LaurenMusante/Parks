﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parks.Models;

namespace Parks.Migrations
{
    [DbContext(typeof(ParksContext))]
    [Migration("20191101171534_MoreSeedData")]
    partial class MoreSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Parks.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Rating");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("StateOrNational")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Name = "Samuel P. Taylor",
                            Rating = 10,
                            State = "CA",
                            StateOrNational = "State"
                        },
                        new
                        {
                            ParkId = 2,
                            Name = "Denali",
                            Rating = 10,
                            State = "AK",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 3,
                            Name = "Grand Canyon",
                            Rating = 9,
                            State = "AZ",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 4,
                            Name = "Joshua Tree",
                            Rating = 10,
                            State = "CA",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 5,
                            Name = "Lake Tahoe",
                            Rating = 10,
                            State = "NV",
                            StateOrNational = "State"
                        },
                        new
                        {
                            ParkId = 6,
                            Name = "Rocky Mounatin",
                            Rating = 10,
                            State = "CO",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 7,
                            Name = "Yellowstone",
                            Rating = 10,
                            State = "ID",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 8,
                            Name = "Haleakala",
                            Rating = 8,
                            State = "HI",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 9,
                            Name = "Mammoth Cave",
                            Rating = 10,
                            State = "KY",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 10,
                            Name = "Glacier",
                            Rating = 10,
                            State = "MT",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 11,
                            Name = "Goblin Valley",
                            Rating = 10,
                            State = "UT",
                            StateOrNational = "State"
                        },
                        new
                        {
                            ParkId = 12,
                            Name = "Arches",
                            Rating = 10,
                            State = "UT",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 13,
                            Name = "BadLands",
                            Rating = 9,
                            State = "SD",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 14,
                            Name = "Bryce Canyon",
                            Rating = 10,
                            State = "UT",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 15,
                            Name = "Carlsbad Caverns",
                            Rating = 8,
                            State = "NM",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 16,
                            Name = "Grand Teton",
                            Rating = 10,
                            State = "WY",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 17,
                            Name = "Congaree",
                            Rating = 7,
                            State = "SC",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 18,
                            Name = "Crater Lake",
                            Rating = 10,
                            State = "OR",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 19,
                            Name = "Great Smoky Mountains",
                            Rating = 9,
                            State = "TN",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 20,
                            Name = "Guadalupe Mountains",
                            Rating = 7,
                            State = "TX",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 21,
                            Name = "Voyageurs",
                            Rating = 8,
                            State = "MN",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 22,
                            Name = "Big Creek",
                            Rating = 7,
                            State = "IA",
                            StateOrNational = "State"
                        },
                        new
                        {
                            ParkId = 23,
                            Name = "Cheboygan",
                            Rating = 9,
                            State = "MI",
                            StateOrNational = "State"
                        },
                        new
                        {
                            ParkId = 24,
                            Name = "Joaquin Miller",
                            Rating = 10,
                            State = "CA",
                            StateOrNational = "State"
                        },
                        new
                        {
                            ParkId = 25,
                            Name = "Carlsbad Caverns",
                            Rating = 8,
                            State = "NM",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 26,
                            Name = "Zion",
                            Rating = 10,
                            State = "UT",
                            StateOrNational = "National"
                        },
                        new
                        {
                            ParkId = 27,
                            Name = "Arrowhead",
                            Rating = 7,
                            State = "OK",
                            StateOrNational = "State"
                        },
                        new
                        {
                            ParkId = 28,
                            Name = "Tombigbee",
                            Rating = 10,
                            State = "MS",
                            StateOrNational = "State"
                        },
                        new
                        {
                            ParkId = 29,
                            Name = "Little Missouri",
                            Rating = 8,
                            State = "MO",
                            StateOrNational = "State"
                        },
                        new
                        {
                            ParkId = 30,
                            Name = "Shenandoah",
                            Rating = 8,
                            State = "VA",
                            StateOrNational = "National"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
