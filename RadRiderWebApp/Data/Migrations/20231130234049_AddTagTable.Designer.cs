﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RadRiderWebApp.Data;

#nullable disable

namespace RadRiderWebApp.Data.Migrations
{
    [DbContext(typeof(SkateDbContext))]
    [Migration("20231130234049_AddTagTable")]
    partial class AddTagTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("RadRiderWebApp.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BrandId");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("RadRiderWebApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("RadRiderWebApp.Models.Skate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BrandId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LimitedEdition")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<double>("ProductReview")
                        .HasColumnType("REAL");

                    b.Property<double>("Size")
                        .HasColumnType("REAL");

                    b.Property<int?>("SkateModelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SkateModelId");

                    b.ToTable("Skate");
                });

            modelBuilder.Entity("RadRiderWebApp.Models.SkateModel", b =>
                {
                    b.Property<int>("SkateModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SkateModelId");

                    b.ToTable("SkateModel");
                });

            modelBuilder.Entity("RadRiderWebApp.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TagId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("RadRiderWebApp.Models.Skate", b =>
                {
                    b.HasOne("RadRiderWebApp.Models.Brand", null)
                        .WithMany("Skates")
                        .HasForeignKey("BrandId");

                    b.HasOne("RadRiderWebApp.Models.Category", null)
                        .WithMany("Skates")
                        .HasForeignKey("CategoryId");

                    b.HasOne("RadRiderWebApp.Models.SkateModel", null)
                        .WithMany("Skates")
                        .HasForeignKey("SkateModelId");
                });

            modelBuilder.Entity("RadRiderWebApp.Models.Brand", b =>
                {
                    b.Navigation("Skates");
                });

            modelBuilder.Entity("RadRiderWebApp.Models.Category", b =>
                {
                    b.Navigation("Skates");
                });

            modelBuilder.Entity("RadRiderWebApp.Models.SkateModel", b =>
                {
                    b.Navigation("Skates");
                });
#pragma warning restore 612, 618
        }
    }
}
