﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistences;

namespace Persistences.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200613192859_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("Domain.WeatherForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Summary")
                        .HasColumnType("TEXT");

                    b.Property<string>("TempC")
                        .HasColumnType("TEXT");

                    b.Property<string>("TempF")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecasts");
                });
#pragma warning restore 612, 618
        }
    }
}
