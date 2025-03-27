using Challenge.Suris.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Suris.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Service> Services { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<ServiceSchedule> ServiceSchedules { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Schedules
            modelBuilder.Entity<Schedule>().HasData(new Schedule
            {
                ScheduleId = 1,
                DateTime = new DateTime(new DateOnly(2025, 3, 31), new TimeOnly(8, 0))
            });

            modelBuilder.Entity<Schedule>().HasData(new Schedule
            {
                ScheduleId = 2,
                DateTime = new DateTime(new DateOnly(2025, 3, 31), new TimeOnly(9, 0))
            });

            modelBuilder.Entity<Schedule>().HasData(new Schedule
            {
                ScheduleId = 3,
                DateTime = new DateTime(new DateOnly(2025, 3, 31), new TimeOnly(10, 0))
            });

            modelBuilder.Entity<Schedule>().HasData(new Schedule
            {
                ScheduleId = 4,
                DateTime = new DateTime(new DateOnly(2025, 4, 1), new TimeOnly(8, 0))
            });

            modelBuilder.Entity<Schedule>().HasData(new Schedule
            {
                ScheduleId = 5,
                DateTime = new DateTime(new DateOnly(2025, 4, 1), new TimeOnly(12, 30))
            });

            modelBuilder.Entity<Schedule>().HasData(new Schedule
            {
                ScheduleId = 6,
                DateTime = new DateTime(new DateOnly(2025, 4, 1), new TimeOnly(14, 30))
            });

            modelBuilder.Entity<Schedule>().HasData(new Schedule
            {
                ScheduleId = 7,
                DateTime = new DateTime(new DateOnly(2025, 4, 2), new TimeOnly(9, 0))
            });

            modelBuilder.Entity<Schedule>().HasData(new Schedule
            {
                ScheduleId = 8,
                DateTime = new DateTime(new DateOnly(2025, 4, 2), new TimeOnly(11, 00))
            });

            modelBuilder.Entity<Schedule>().HasData(new Schedule
            {
                ScheduleId = 9,
                DateTime = new DateTime(new DateOnly(2025, 4, 2), new TimeOnly(13, 00))
            });

            //Seed Services
            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 1,
                Name = "Limpieza",
                Description = "Limpieza de Palier y Ascensores"
            });

            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 2,
                Name = "Plomería",
                Description = "Arreglos de fonatenería y destapaciones"
            });

            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceId = 3,
                Name = "Electricidad",
                Description = "Instalaciones y reparaciones eléctricas de unidades departamentales"
            });

            //Seed Service Schedules
            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 1,
                ServiceId = 1
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 2,
                ServiceId = 1
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 3,
                ServiceId = 1
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 4,
                ServiceId = 2
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 5,
                ServiceId = 2
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 6,
                ServiceId = 3
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 7,
                ServiceId = 3
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 8,
                ServiceId = 3
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 9,
                ServiceId = 3
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 2,
                ServiceId = 2
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 3,
                ServiceId = 2
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 4,
                ServiceId = 1
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 5,
                ServiceId = 1
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 6,
                ServiceId = 2
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 7,
                ServiceId = 2
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 8,
                ServiceId = 2
            });

            modelBuilder.Entity<ServiceSchedule>().HasData(new ServiceSchedule
            {
                ScheduleId = 9,
                ServiceId = 2
            });
        }
    }
}
