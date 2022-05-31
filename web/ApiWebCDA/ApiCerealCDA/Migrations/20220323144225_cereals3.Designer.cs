﻿// <auto-generated />
using ApiCerealCDA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiCerealCDA.Migrations
{
    [DbContext(typeof(CerealDbContext))]
    [Migration("20220323144225_cereals3")]
    partial class cereals3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiCerealCDA.Models.Cereal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte>("Calories")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Carbo")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Fiber")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<short>("Potass")
                        .HasColumnType("smallint");

                    b.Property<byte>("Protein")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(5,2)");

                    b.Property<short>("Sodium")
                        .HasColumnType("smallint");

                    b.Property<byte>("Sugars")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Vitamins")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("tata");
                });
#pragma warning restore 612, 618
        }
    }
}