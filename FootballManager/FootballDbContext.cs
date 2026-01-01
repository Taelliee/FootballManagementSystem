using FootballManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballManager.Enums;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Convert all enums to strings in the database
            modelBuilder.Entity<Player>()
                .Property(p => p.Position)
                .HasConversion<string>();

            modelBuilder.Entity<Player>()
                .Property(p => p.Country)
                .HasConversion<string>();

            modelBuilder.Entity<Staff>()
                .Property(s => s.Role)
                .HasConversion<string>();

            modelBuilder.Entity<Staff>()
                .Property(s => s.Country)
                .HasConversion<string>();

            modelBuilder.Entity<Team>()
                .Property(t => t.Country)
                .HasConversion<string>();

            modelBuilder.Entity<Stadium>()
                .Property(s => s.Country)
                .HasConversion<string>();

            modelBuilder.Entity<Competition>()
                .Property(c => c.HostCountry)
                .HasConversion<string>();

            modelBuilder.Entity<Team>()
                .HasOne(t => t.Coach) // A Team has one Coach
                .WithOne(s => s.CoachedTeam) // A Staff member (Coach) has one Team
                .HasForeignKey<Team>(t => t.CoachId) // The foreign key is in the Team table
                .OnDelete(DeleteBehavior.SetNull); // If a coach is deleted, set Team.CoachId to null

            modelBuilder.Entity<Team>()
                .HasOne(t => t.Stadium)
                .WithOne(s => s.Team)
                .HasForeignKey<Stadium>(s => s.TeamId);
        }
    }
}
