﻿// <auto-generated />
using Czolgi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Czolgi.Migrations
{
    [DbContext(typeof(DbArmia))]
    [Migration("20221215213424_firste")]
    partial class firste
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Czolgi.Models.Czolg", b =>
                {
                    b.Property<int>("CzolgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CzolgId"));

                    b.Property<double>("Kaliber")
                        .HasColumnType("float");

                    b.Property<double>("Masa")
                        .HasColumnType("float");

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CzolgId");

                    b.ToTable("Czolgi");
                });
#pragma warning restore 612, 618
        }
    }
}
