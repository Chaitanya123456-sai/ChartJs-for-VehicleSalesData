﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleAPI.Data;

#nullable disable

namespace VehicleAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250318124724_AddAppointmentCloseRate")]
    partial class AddAppointmentCloseRate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("VehicleAPI.Models.VehicleData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AppointmentCloseRate")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("AppointmentSetRate")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("InventoryLevels")
                        .HasColumnType("int");

                    b.Property<string>("Month")
                        .HasColumnType("longtext");

                    b.Property<int>("NewVehicleSales")
                        .HasColumnType("int");

                    b.Property<int>("UsedVehicleSales")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VehicleData");
                });
#pragma warning restore 612, 618
        }
    }
}
