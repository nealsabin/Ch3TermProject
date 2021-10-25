﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TermProject.Models;

namespace TermProject.Migrations
{
    [DbContext(typeof(RideContext))]
    [Migration("20211025003720_Difficulty")]
    partial class Difficulty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<int?>("Days")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DifficultyId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Miles")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RideId");

                    b.HasIndex("DifficultyId");

                    b.ToTable("Rides");

                    b.HasData(
                        new
                        {
                            RideId = 1,
                            Days = 16,
                            Description = "This bikepacking trip takes your around the largest lake by surface in the world.",
                            DifficultyId = "3",
                            Miles = 1200,
                            Name = "Around Superior"
                        },
                        new
                        {
                            RideId = 2,
                            Days = 3,
                            Description = "A trip around the scenic Leelanau Peninsula.",
                            DifficultyId = "1",
                            Miles = 180,
                            Name = "Leelanau Peninsula"
                        },
                        new
                        {
                            RideId = 3,
                            Days = 4,
                            Description = "A rugged, remote trip awaits with this route around the Huron Mountains, in the Upper Peninsula of Michigan.",
                            DifficultyId = "2",
                            Miles = 210,
                            Name = "Huron Mountains"
                        },
                        new
                        {
                            RideId = 4,
                            Days = 5,
                            Description = "You will encounter some of the most beautiful coastline Michigan has to offer in this trip.",
                            DifficultyId = "2",
                            Miles = 220,
                            Name = "Keweenaw Peninsula"
                        });
                });

            modelBuilder.Entity("TermProject.Models.Ride", b =>
                {
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
