﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NZWalks.API.Data;

#nullable disable

namespace NZWalks.API.Migrations
{
    [DbContext(typeof(NzWalksDbContext))]
    [Migration("20240917182816_second-migration")]
    partial class secondmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NZWalks.API.Models.Domain.Difficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cf46cf69-e0fa-4c03-9c31-7418618fb203"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("19f369b0-2d0d-4aa1-956a-6d26f713f3bb"),
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("5298b2f7-0ff4-4e0b-8b9f-cc82ca635f89"),
                            Name = "Hard"
                        });
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c2f1f0da-34a8-4b5d-b8ff-fb00e1a332d4"),
                            Code = "AKL",
                            Name = "Auckland",
                            RegionImageUrl = "https://picsum.photos/200"
                        },
                        new
                        {
                            Id = new Guid("7bded420-749a-426f-9d18-99e3b9b7ff87"),
                            Code = "WLG",
                            Name = "Wellington",
                            RegionImageUrl = "https://picsum.photos/201"
                        },
                        new
                        {
                            Id = new Guid("fbec72b6-b80a-44b1-bbaa-3ab21f4ffcd7"),
                            Code = "CHC",
                            Name = "Christchurch",
                            RegionImageUrl = "https://picsum.photos/202"
                        },
                        new
                        {
                            Id = new Guid("8c1b0f4b-5470-4fa6-98f1-25c4321dc64e"),
                            Code = "HAM",
                            Name = "Hamilton",
                            RegionImageUrl = "https://picsum.photos/203"
                        },
                        new
                        {
                            Id = new Guid("05bbedfd-7509-4c81-b495-9c3f3b6c6360"),
                            Code = "TRG",
                            Name = "Tauranga",
                            RegionImageUrl = "https://picsum.photos/204"
                        });
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("LenghtInKm")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalkImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Walk", b =>
                {
                    b.HasOne("NZWalks.API.Models.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NZWalks.API.Models.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
