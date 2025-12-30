using FootballManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    public class FootballDbContext : DbContext
    {
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Staff> StaffMembers { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VLMAI0N;Database=FootballManager;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Configure relationships explicitly if needed
        //    modelBuilder.Entity<Competition>()
        //        .HasOne(c => c.Staff)
        //        .WithMany(s => s.Competitions)
        //        .HasForeignKey(c => c.StaffId);

        //    modelBuilder.Entity<Competition>()
        //        .HasOne(c => c.Player)
        //        .WithMany(p => p.Competitions)
        //        .HasForeignKey(c => c.PlayerId);

        //    modelBuilder.Entity<Competition>()
        //        .HasOne(c => c.Stadium)
        //        .WithMany(s => s.Competitions)
        //        .HasForeignKey(c => c.StadiumId);

        //    // Add additional configurations if necessary
        //}
    }
}
