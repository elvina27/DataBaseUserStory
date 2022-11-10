﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Приемная_комиссия;

namespace Приемная_комиссия.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Приемная_комиссия.Haracteristika.Abiturient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormaObucheniya")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<decimal>("Inf")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Matem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Rus")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("AbiturientsDB");
                });
#pragma warning restore 612, 618
        }
    }
}