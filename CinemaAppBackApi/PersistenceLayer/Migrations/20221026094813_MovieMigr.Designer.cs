﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersistenceLayer;

#nullable disable

namespace PersistenceLayer.Migrations
{
    [DbContext(typeof(RepositoryDbContext))]
    [Migration("20221026094813_MovieMigr")]
    partial class MovieMigr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DomainLayer.Models.Genre", b =>
                {
                    b.Property<long>("genreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("genreId"), 1L, 1);

                    b.Property<bool>("deleted")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated")
                        .HasColumnType("datetime2");

                    b.HasKey("genreId");

                    b.ToTable("Genre", (string)null);
                });

            modelBuilder.Entity("DomainLayer.Models.Movie", b =>
                {
                    b.Property<long>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("movieId"), 1L, 1);

                    b.Property<bool>("deleted")
                        .HasColumnType("bit");

                    b.Property<int>("duration")
                        .HasColumnType("int");

                    b.Property<string>("nameLocal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameOriginal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trailer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("movieId");

                    b.ToTable("Movie", (string)null);
                });

            modelBuilder.Entity("DomainLayer.Models.User", b =>
                {
                    b.Property<long>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("userId"), 1L, 1);

                    b.Property<string>("PasswordResetToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("birthday")
                        .HasColumnType("datetime2");

                    b.Property<bool>("blocked")
                        .HasColumnType("bit");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("verified")
                        .HasColumnType("bit");

                    b.HasKey("userId");

                    b.HasAlternateKey("email");

                    b.ToTable("User", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
