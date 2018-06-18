﻿// <auto-generated />
using System;
using ConsoleApp4;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp4.Migrations
{
    [DbContext(typeof(EFCoreDemoContext))]
    partial class EFCoreDemoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp4.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("TravelId");

                    b.HasKey("Id");

                    b.HasIndex("TravelId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("ConsoleApp4.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsBusy");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("ConsoleApp4.Travel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DriverId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.ToTable("Travels");
                });

            modelBuilder.Entity("ConsoleApp4.Address", b =>
                {
                    b.HasOne("ConsoleApp4.Travel")
                        .WithMany("Address")
                        .HasForeignKey("TravelId");
                });

            modelBuilder.Entity("ConsoleApp4.Travel", b =>
                {
                    b.HasOne("ConsoleApp4.Driver")
                        .WithMany("Travels")
                        .HasForeignKey("DriverId");
                });
#pragma warning restore 612, 618
        }
    }
}
