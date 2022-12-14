// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sklep.Models;

#nullable disable

namespace Sklep.Migrations
{
    [DbContext(typeof(DbSklep))]
    [Migration("20221215194352_pierwsze")]
    partial class pierwsze
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sklep.Models.Towar", b =>
                {
                    b.Property<int>("TowarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TowarId"));

                    b.Property<decimal>("Cena")
                        .HasColumnType("DECIMAL");

                    b.Property<int>("Ilosc")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Producent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TowarId");

                    b.ToTable("Towary");
                });
#pragma warning restore 612, 618
        }
    }
}
