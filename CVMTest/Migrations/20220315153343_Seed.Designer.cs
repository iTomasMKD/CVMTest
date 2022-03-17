﻿// <auto-generated />
using CVMTest.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CVMTest.Migrations
{
    [DbContext(typeof(CoffeeDbContext))]
    [Migration("20220315153343_Seed")]
    partial class Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CVMTest.Models.Coffee", b =>
                {
                    b.Property<int>("CofeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Characteristics")
                        .HasColumnType("int");

                    b.Property<int>("CofeeType")
                        .HasColumnType("int");

                    b.Property<int>("CoffeeDecoratrion")
                        .HasColumnType("int");

                    b.HasKey("CofeeId");

                    b.ToTable("Coffies");

                    b.HasData(
                        new
                        {
                            CofeeId = 1,
                            Characteristics = 3,
                            CofeeType = 0,
                            CoffeeDecoratrion = 1
                        },
                        new
                        {
                            CofeeId = 2,
                            Characteristics = 2,
                            CofeeType = 2,
                            CoffeeDecoratrion = 1
                        },
                        new
                        {
                            CofeeId = 3,
                            Characteristics = 1,
                            CofeeType = 1,
                            CoffeeDecoratrion = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}