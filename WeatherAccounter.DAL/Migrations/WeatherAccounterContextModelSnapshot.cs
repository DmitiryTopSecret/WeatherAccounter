﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherAccounter.DAL;

namespace WeatherAccounter.DAL.Migrations
{
    [DbContext(typeof(WeatherAccounterContext))]
    partial class WeatherAccounterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WeatherAccounter.Models.Entites.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WeatherId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("WeatherId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("WeatherAccounter.Models.Entites.Weather", b =>
                {
                    b.Property<int>("WeatherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaxTemperature")
                        .HasColumnType("int");

                    b.Property<int>("MinTemperature")
                        .HasColumnType("int");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("WeatherId");

                    b.ToTable("Weather");
                });

            modelBuilder.Entity("WeatherAccounter.Models.Entites.City", b =>
                {
                    b.HasOne("WeatherAccounter.Models.Entites.Weather", "Weather")
                        .WithMany()
                        .HasForeignKey("WeatherId");
                });
#pragma warning restore 612, 618
        }
    }
}
