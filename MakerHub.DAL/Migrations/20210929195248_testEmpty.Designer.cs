﻿// <auto-generated />
using MakerHub.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MakerHub.DAL.Migrations
{
    [DbContext(typeof(MakerHubDBContext))]
    [Migration("20210929195248_testEmpty")]
    partial class testEmpty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("MakerHub.DAL.Entities.Aggrometre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Humidity")
                        .HasColumnType("REAL");

                    b.Property<string>("test")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Humidity");
                });

            modelBuilder.Entity("MakerHub.DAL.Entities.Light", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Blue")
                        .HasColumnType("REAL");

                    b.Property<float>("Green")
                        .HasColumnType("REAL");

                    b.Property<float>("Red")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Light");
                });

            modelBuilder.Entity("MakerHub.DAL.Entities.Sound", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Intensity")
                        .HasColumnType("REAL");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Intensity");
                });

            modelBuilder.Entity("MakerHub.DAL.Entities.Temperature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Degrees")
                        .HasColumnType("REAL");

                    b.Property<float>("Farenheit")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Temperature");
                });
#pragma warning restore 612, 618
        }
    }
}
