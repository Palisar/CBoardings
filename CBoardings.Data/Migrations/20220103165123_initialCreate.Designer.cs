﻿// <auto-generated />
using System;
using CBoardings.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CBoardings.Data.Migrations
{
    [DbContext(typeof(BoardingDbContext))]
    [Migration("20220103165123_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CBoardings.Core.Boarding", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BoardingTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsArrested")
                        .HasColumnType("bit");

                    b.Property<int>("LatDeg")
                        .HasColumnType("int");

                    b.Property<int>("LatMin")
                        .HasColumnType("int");

                    b.Property<int>("LongDeg")
                        .HasColumnType("int");

                    b.Property<int>("LongMin")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Boardings");
                });
#pragma warning restore 612, 618
        }
    }
}
