﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TermProject.Models;

namespace TermProject.Migrations
{
    [DbContext(typeof(RideContext))]
    partial class RideContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TermProject.Models.Bike", b =>
                {
                    b.Property<int>("BikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnName("Bike Make")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<double>("WheelSize")
                        .HasColumnType("float");

                    b.HasKey("BikeId");

                    b.ToTable("Bike");

                    b.HasData(
                        new
                        {
                            BikeId = 1,
                            Make = "Specialized",
                            Model = "Sequoia",
                            WheelSize = 0.0
                        },
                        new
                        {
                            BikeId = 2,
                            Make = "Surly",
                            Model = "Pugsly",
                            WheelSize = 0.0
                        },
                        new
                        {
                            BikeId = 3,
                            Make = "Kona",
                            Model = "Unit X",
                            WheelSize = 0.0
                        });
                });

            modelBuilder.Entity("TermProject.Models.Difficulty", b =>
                {
                    b.Property<string>("DifficultyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DifficultyId");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            DifficultyId = "1",
                            Rating = "Easy"
                        },
                        new
                        {
                            DifficultyId = "2",
                            Rating = "Medium"
                        },
                        new
                        {
                            DifficultyId = "3",
                            Rating = "Hard"
                        });
                });

            modelBuilder.Entity("TermProject.Models.Ride", b =>
                {
                    b.Property<int>("RideId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BikeId")
                        .HasColumnType("int");

                    b.Property<int?>("Days")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("DifficultyId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Miles")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnName("Ride Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RideId");

                    b.HasIndex("BikeId");

                    b.HasIndex("DifficultyId");

                    b.ToTable("Rides");

                    b.HasData(
                        new
                        {
                            RideId = 1,
                            BikeId = 1,
                            Days = 16,
                            Description = "This bikepacking trip takes your around the largest lake by surface in the world.",
                            DifficultyId = "3",
                            Miles = 1200,
                            Name = "Around Superior",
                            StartDate = new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            State = "MI"
                        },
                        new
                        {
                            RideId = 2,
                            BikeId = 1,
                            Days = 3,
                            Description = "A trip around the scenic Leelanau Peninsula.",
                            DifficultyId = "1",
                            Miles = 180,
                            Name = "Leelanau Peninsula",
                            StartDate = new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            State = "MI"
                        },
                        new
                        {
                            RideId = 3,
                            BikeId = 2,
                            Days = 4,
                            Description = "A rugged, remote trip awaits with this route around the Huron Mountains, in the Upper Peninsula of Michigan.",
                            DifficultyId = "2",
                            Miles = 210,
                            Name = "Huron Mountains",
                            StartDate = new DateTime(2018, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            State = "MI"
                        },
                        new
                        {
                            RideId = 4,
                            BikeId = 3,
                            Days = 5,
                            Description = "You will encounter some of the most beautiful coastline Michigan has to offer in this trip.",
                            DifficultyId = "2",
                            Miles = 220,
                            Name = "Keweenaw Peninsula",
                            StartDate = new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            State = "MI"
                        });
                });

            modelBuilder.Entity("TermProject.Models.Ride", b =>
                {
                    b.HasOne("TermProject.Models.Bike", "Bike")
                        .WithMany()
                        .HasForeignKey("BikeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TermProject.Models.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
