﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoteOne.Persistence;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NoteOne.Persistence.Migrations
{
    [DbContext(typeof(NoteOneDBContext))]
    [Migration("20220925234415_refactoryCategories")]
    partial class refactoryCategories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("NoteOne.Domain.Category", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserGuid")
                        .HasColumnType("uuid");

                    b.HasKey("Guid");

                    b.HasIndex("UserGuid");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NoteOne.Domain.Note", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Guid?>("PageGuid")
                        .HasColumnType("uuid");

                    b.HasKey("Guid");

                    b.HasIndex("PageGuid");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("NoteOne.Domain.Page", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CategoryGuid")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PageName")
                        .HasColumnType("text");

                    b.Property<string>("PageTitle")
                        .HasColumnType("text");

                    b.HasKey("Guid");

                    b.HasIndex("CategoryGuid");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("NoteOne.Domain.Tag", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.HasKey("Guid");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("NoteOne.Domain.User", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Guid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NoteOne.Domain.Category", b =>
                {
                    b.HasOne("NoteOne.Domain.User", null)
                        .WithMany("Categorys")
                        .HasForeignKey("UserGuid");
                });

            modelBuilder.Entity("NoteOne.Domain.Note", b =>
                {
                    b.HasOne("NoteOne.Domain.Page", null)
                        .WithMany("Notes")
                        .HasForeignKey("PageGuid");
                });

            modelBuilder.Entity("NoteOne.Domain.Page", b =>
                {
                    b.HasOne("NoteOne.Domain.Category", null)
                        .WithMany("Pages")
                        .HasForeignKey("CategoryGuid");
                });

            modelBuilder.Entity("NoteOne.Domain.Category", b =>
                {
                    b.Navigation("Pages");
                });

            modelBuilder.Entity("NoteOne.Domain.Page", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("NoteOne.Domain.User", b =>
                {
                    b.Navigation("Categorys");
                });
#pragma warning restore 612, 618
        }
    }
}
