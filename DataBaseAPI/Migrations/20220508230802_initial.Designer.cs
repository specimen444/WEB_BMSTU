﻿// <auto-generated />
using System;
using DataBaseAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataBaseAPI.Migrations
{
    [DbContext(typeof(ImmigrationDbContext))]
    [Migration("20220508230802_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ClusterProfile", b =>
                {
                    b.Property<int>("ClustersId")
                        .HasColumnType("integer");

                    b.Property<int>("ProfilesId")
                        .HasColumnType("integer");

                    b.HasKey("ClustersId", "ProfilesId");

                    b.HasIndex("ProfilesId");

                    b.ToTable("ClusterProfile");
                });

            modelBuilder.Entity("DataBaseAPI.Data.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryName")
                        .HasColumnType("text");

                    b.Property<double?>("Lattitude")
                        .HasColumnType("double precision");

                    b.Property<double?>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("DataBaseAPI.Data.Models.Cluster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClusterAlgorithm")
                        .HasColumnType("text");

                    b.Property<int>("ClusterNumber")
                        .HasColumnType("integer");

                    b.Property<int>("ProfileCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Clusters");
                });

            modelBuilder.Entity("DataBaseAPI.Data.Models.Plot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Data")
                        .HasColumnType("jsonb");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Plots");
                });

            modelBuilder.Entity("DataBaseAPI.Data.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<int?>("CountryId")
                        .HasColumnType("integer");

                    b.Property<int?>("Graduation")
                        .HasColumnType("integer");

                    b.Property<string>("Hometown")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Sex")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<string>("University")
                        .HasColumnType("text");

                    b.Property<long>("VKId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("ClusterProfile", b =>
                {
                    b.HasOne("DataBaseAPI.Data.Models.Cluster", null)
                        .WithMany()
                        .HasForeignKey("ClustersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBaseAPI.Data.Models.Profile", null)
                        .WithMany()
                        .HasForeignKey("ProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataBaseAPI.Data.Models.Profile", b =>
                {
                    b.HasOne("DataBaseAPI.Data.Models.City", "City")
                        .WithMany("Profiles")
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("DataBaseAPI.Data.Models.City", b =>
                {
                    b.Navigation("Profiles");
                });
#pragma warning restore 612, 618
        }
    }
}
