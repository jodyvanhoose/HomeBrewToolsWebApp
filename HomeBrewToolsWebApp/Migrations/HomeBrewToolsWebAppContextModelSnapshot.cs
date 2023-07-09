﻿// <auto-generated />
using System;
using HomeBrewToolsWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HomeBrewToolsWebApp.Migrations
{
    [DbContext(typeof(HomeBrewToolsWebAppContext))]
    partial class HomeBrewToolsWebAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.7");

            modelBuilder.Entity("HomeBrewToolsWebApp.Models.HomeBrewLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("FinalGravity")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("StartingGravity")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("UpdatedGravity")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("HomeBrewLog");
                });
#pragma warning restore 612, 618
        }
    }
}