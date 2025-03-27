﻿// <auto-generated />
using System;
using Challenge.Suris.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Challenge.Suris.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Challenge.Suris.Domain.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Challenge.Suris.Domain.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduleId"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ScheduleId");

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            ScheduleId = 1,
                            DateTime = new DateTime(2025, 3, 31, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ScheduleId = 2,
                            DateTime = new DateTime(2025, 3, 31, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ScheduleId = 3,
                            DateTime = new DateTime(2025, 3, 31, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ScheduleId = 4,
                            DateTime = new DateTime(2025, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ScheduleId = 5,
                            DateTime = new DateTime(2025, 4, 1, 12, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ScheduleId = 6,
                            DateTime = new DateTime(2025, 4, 1, 14, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ScheduleId = 7,
                            DateTime = new DateTime(2025, 4, 2, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ScheduleId = 8,
                            DateTime = new DateTime(2025, 4, 2, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ScheduleId = 9,
                            DateTime = new DateTime(2025, 4, 2, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Challenge.Suris.Domain.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            ServiceId = 1,
                            Description = "Limpieza de Palier y Ascensores",
                            Name = "Limpieza"
                        },
                        new
                        {
                            ServiceId = 2,
                            Description = "Arreglos de fonatenería y destapaciones",
                            Name = "Plomería"
                        },
                        new
                        {
                            ServiceId = 3,
                            Description = "Instalaciones y reparaciones eléctricas de unidades departamentales",
                            Name = "Electricidad"
                        });
                });

            modelBuilder.Entity("Challenge.Suris.Domain.Models.ServiceSchedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("ScheduleId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("ServiceSchedules");

                    b.HasData(
                        new
                        {
                            ScheduleId = 1,
                            ServiceId = 1
                        },
                        new
                        {
                            ScheduleId = 2,
                            ServiceId = 1
                        },
                        new
                        {
                            ScheduleId = 3,
                            ServiceId = 1
                        },
                        new
                        {
                            ScheduleId = 4,
                            ServiceId = 2
                        },
                        new
                        {
                            ScheduleId = 5,
                            ServiceId = 2
                        },
                        new
                        {
                            ScheduleId = 6,
                            ServiceId = 3
                        },
                        new
                        {
                            ScheduleId = 7,
                            ServiceId = 3
                        },
                        new
                        {
                            ScheduleId = 8,
                            ServiceId = 3
                        },
                        new
                        {
                            ScheduleId = 9,
                            ServiceId = 3
                        });
                });

            modelBuilder.Entity("Challenge.Suris.Domain.Models.Reservation", b =>
                {
                    b.HasOne("Challenge.Suris.Domain.Models.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Challenge.Suris.Domain.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Challenge.Suris.Domain.Models.ServiceSchedule", b =>
                {
                    b.HasOne("Challenge.Suris.Domain.Models.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Challenge.Suris.Domain.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");

                    b.Navigation("Service");
                });
#pragma warning restore 612, 618
        }
    }
}
