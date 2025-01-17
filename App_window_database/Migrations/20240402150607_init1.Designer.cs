﻿// <auto-generated />
using App_window_database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App_window_database.Migrations
{
    [DbContext(typeof(dbConetxt))]
    [Migration("20240402150607_init1")]
    partial class init1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview.2.24128.4");

            modelBuilder.Entity("App_window_database.dbStructure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("currency")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("rate")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Rates");
                });
#pragma warning restore 612, 618
        }
    }
}
