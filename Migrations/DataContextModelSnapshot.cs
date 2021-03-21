﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RfidAPI.Data;

namespace RfidAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("RfidAPI.Models.Equipment", b =>
                {
                    b.Property<int>("deviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("deviceName")
                        .HasColumnType("TEXT");

                    b.Property<int>("status")
                        .HasColumnType("INTEGER");

                    b.HasKey("deviceId");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("RfidAPI.Models.Log", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("from_id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("from_time")
                        .HasColumnType("TEXT");

                    b.Property<string>("log")
                        .HasColumnType("TEXT");

                    b.Property<int>("requestStatus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("to_id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("to_time")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("RfidAPI.Models.Permission", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("role_name")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("RfidAPI.Models.Repo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("info")
                        .HasColumnType("TEXT");

                    b.Property<int>("managerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Repo");
                });

            modelBuilder.Entity("RfidAPI.Models.User", b =>
                {
                    b.Property<int>("key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("faceInfo")
                        .HasColumnType("TEXT");

                    b.Property<bool>("gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<int>("permission")
                        .HasColumnType("INTEGER");

                    b.HasKey("key");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
