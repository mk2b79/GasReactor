﻿// <auto-generated />
using System;
using GasReact.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GasReact.DAL.Migrations
{
    [DbContext(typeof(GasReactorContext))]
    partial class GasReactorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GasReact.DAL.Entities.Fermentator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("fermentator_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FermentatorName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("fermentator_name");

                    b.HasKey("Id");

                    b.ToTable("fermentators", "public");
                });

            modelBuilder.Entity("GasReact.DAL.Entities.Indicator", b =>
                {
                    b.Property<int>("IndicatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("indicator_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IndicatorId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date");

                    b.Property<int>("RecordId")
                        .HasColumnType("integer")
                        .HasColumnName("record_id");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer")
                        .HasColumnName("type_id");

                    b.Property<decimal>("Value")
                        .HasColumnType("numeric")
                        .HasColumnName("value");

                    b.HasKey("IndicatorId");

                    b.HasIndex("RecordId");

                    b.HasIndex("TypeId");

                    b.ToTable("indicators", "public");
                });

            modelBuilder.Entity("GasReact.DAL.Entities.Record", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("record_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RecordId"));

                    b.Property<int>("FermentatorId")
                        .HasColumnType("integer")
                        .HasColumnName("fermentator_id");

                    b.HasKey("RecordId");

                    b.HasIndex("FermentatorId");

                    b.ToTable("records", "public");
                });

            modelBuilder.Entity("GasReact.DAL.Entities.TypesIndicators", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("type_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TypeId"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("type_name");

                    b.HasKey("TypeId");

                    b.ToTable("types_indicators", "public");
                });

            modelBuilder.Entity("GasReact.DAL.Entities.Indicator", b =>
                {
                    b.HasOne("GasReact.DAL.Entities.Record", "Record")
                        .WithMany("Indicators")
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GasReact.DAL.Entities.TypesIndicators", "Type")
                        .WithMany("Indicators")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Record");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("GasReact.DAL.Entities.Record", b =>
                {
                    b.HasOne("GasReact.DAL.Entities.Fermentator", "Fermentator")
                        .WithMany("Records")
                        .HasForeignKey("FermentatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fermentator");
                });

            modelBuilder.Entity("GasReact.DAL.Entities.Fermentator", b =>
                {
                    b.Navigation("Records");
                });

            modelBuilder.Entity("GasReact.DAL.Entities.Record", b =>
                {
                    b.Navigation("Indicators");
                });

            modelBuilder.Entity("GasReact.DAL.Entities.TypesIndicators", b =>
                {
                    b.Navigation("Indicators");
                });
#pragma warning restore 612, 618
        }
    }
}