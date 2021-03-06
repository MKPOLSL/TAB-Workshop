// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Workshop.DataAccess;

namespace Workshop.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20210420224247_databaseModel")]
    partial class databaseModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Workshop.Entities.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ActivityType")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FinishedOrCancelled")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Reqistered")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("RequestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("WorkerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("Workshop.Entities.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarType")
                        .HasColumnType("int");

                    b.Property<Guid?>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductionYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Workshop.Entities.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Workshop.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Workshop.Entities.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FinishedOrCancelled")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Reqistered")
                        .HasColumnType("datetime2");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("Workshop.Entities.Activity", b =>
                {
                    b.HasOne("Workshop.Entities.Request", "Request")
                        .WithMany("Activities")
                        .HasForeignKey("RequestId");

                    b.HasOne("Workshop.Entities.Employee", "Worker")
                        .WithMany("Activities")
                        .HasForeignKey("WorkerId");
                });

            modelBuilder.Entity("Workshop.Entities.Car", b =>
                {
                    b.HasOne("Workshop.Entities.Client", "Client")
                        .WithMany("Cars")
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("Workshop.Entities.Request", b =>
                {
                    b.HasOne("Workshop.Entities.Car", "Car")
                        .WithMany("Requests")
                        .HasForeignKey("CarId");

                    b.HasOne("Workshop.Entities.Employee", "Manager")
                        .WithMany("Requests")
                        .HasForeignKey("ManagerId");
                });
#pragma warning restore 612, 618
        }
    }
}
