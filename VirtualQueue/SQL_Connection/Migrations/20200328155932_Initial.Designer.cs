﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQL_Connection;

namespace SQL_Connection.Migrations
{
    [DbContext(typeof(DB_Connection))]
    [Migration("20200328155932_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SQL_Connection.Entities.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("SQL_Connection.Entities.Queue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocationAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Queues");
                });

            modelBuilder.Entity("SQL_Connection.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MacAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QueueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QueueId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SQL_Connection.Entities.Queue", b =>
                {
                    b.HasOne("SQL_Connection.Entities.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");
                });

            modelBuilder.Entity("SQL_Connection.Entities.User", b =>
                {
                    b.HasOne("SQL_Connection.Entities.Queue", "Queue")
                        .WithMany("Users")
                        .HasForeignKey("QueueId");
                });
#pragma warning restore 612, 618
        }
    }
}
