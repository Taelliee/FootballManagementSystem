using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FootballManager.Models;

namespace FootballManager.Services
{
    public static class FootballDataService
    {
        // --- Players ---
        public static List<Player> GetPlayers(bool includeTeam = false)
        {
            using var db = new FootballDbContext();
            var query = db.Players.AsQueryable();
            if (includeTeam)
                query = query.Include(p => p.Team);
            return query.ToList();
        }

        public static Player GetPlayer(int playerId, bool includeTeam = false)
        {
            using var db = new FootballDbContext();
            var query = db.Players.AsQueryable();
            if (includeTeam)
                query = query.Include(p => p.Team);
            return query.FirstOrDefault(p => p.Id == playerId);
        }

        public static void AddPlayer(Player player)
        {
            using var db = new FootballDbContext();
            db.Players.Add(player);
            db.SaveChanges();
        }

        public static void UpdatePlayer(Player player)
        {
            using var db = new FootballDbContext();
            db.Players.Update(player);
            db.SaveChanges();
        }

        public static void RemovePlayer(int playerId)
        {
            using var db = new FootballDbContext();
            var player = db.Players.Find(playerId);
            if (player != null)
            {
                db.Players.Remove(player);
                db.SaveChanges();
            }
        }

        // --- Teams ---
        public static List<Team> GetTeams(bool includePlayers = false, bool includeCoach = false)
        {
            using var db = new FootballDbContext();
            var query = db.Teams.AsQueryable();
            if (includePlayers)
                query = query.Include(t => t.Players);
            if (includeCoach)
                query = query.Include(t => t.Coach);
            return query.ToList();
        }

        public static Team GetTeam(int teamId, bool includePlayers = false, bool includeCoach = false)
        {
            using var db = new FootballDbContext();
            var query = db.Teams.AsQueryable();
            if (includePlayers)
                query = query.Include(t => t.Players);
            if (includeCoach)
                query = query.Include(t => t.Coach);
            return query.FirstOrDefault(t => t.Id == teamId);
        }

        public static void AddTeam(Team team)
        {
            using var db = new FootballDbContext();
            db.Teams.Add(team);
            db.SaveChanges();
        }

        public static void UpdateTeam(Team team)
        {
            using var db = new FootballDbContext();
            db.Teams.Update(team);
            db.SaveChanges();
        }

        public static void RemoveTeam(int teamId)
        {
            using var db = new FootballDbContext();
            var team = db.Teams.Find(teamId);
            if (team != null)
            {
                db.Teams.Remove(team);
                db.SaveChanges();
            }
        }

        // --- Staff ---
        public static List<Staff> GetStaff()
        {
            using var db = new FootballDbContext();
            return db.StaffMembers.ToList();
        }

        public static Staff GetStaff(int staffId)
        {
            using var db = new FootballDbContext();
            return db.StaffMembers.Find(staffId);
        }

        public static void AddStaff(Staff staff)
        {
            using var db = new FootballDbContext();
            db.StaffMembers.Add(staff);
            db.SaveChanges();
        }

        public static void UpdateStaff(Staff staff)
        {
            using var db = new FootballDbContext();
            db.StaffMembers.Update(staff);
            db.SaveChanges();
        }

        public static void RemoveStaff(int staffId)
        {
            using var db = new FootballDbContext();
            var staff = db.StaffMembers.Find(staffId);
            if (staff != null)
            {
                db.StaffMembers.Remove(staff);
                db.SaveChanges();
            }
        }

        // --- Stadiums ---
        public static List<Stadium> GetStadiums(bool includeTeam = false)
        {
            using var db = new FootballDbContext();
            var query = db.Stadiums.AsQueryable();
            if (includeTeam)
            {
                query = query.Include(s => s.Team);
            }
            return query.ToList();
        }

        public static Stadium GetStadium(int stadiumId, bool includeTeam = false)
        {
            using var db = new FootballDbContext();
            var query = db.Stadiums.AsQueryable();
            if (includeTeam)
            {
                query = query.Include(s => s.Team);
            }
            return query.FirstOrDefault(s => s.Id == stadiumId);
        }

        public static void AddStadium(Stadium stadium)
        {
            using var db = new FootballDbContext();
            db.Stadiums.Add(stadium);
            db.SaveChanges();
        }

        public static void UpdateStadium(Stadium stadium)
        {
            using var db = new FootballDbContext();
            db.Stadiums.Update(stadium);
            db.SaveChanges();
        }

        public static void RemoveStadium(int stadiumId)
        {
            using var db = new FootballDbContext();
            var stadium = db.Stadiums.Find(stadiumId);
            if (stadium != null)
            {
                db.Stadiums.Remove(stadium);
                db.SaveChanges();
            }
        }

        // --- Competitions ---
        public static List<Competition> GetCompetitions(bool includeAll = false)
        {
            using var db = new FootballDbContext();
            var query = db.Competitions.AsQueryable();
            if (includeAll)
            {
                query = query
                    .Include(c => c.Player)
                        .ThenInclude(p => p.Team) // Eagerly load the player's team
                    .Include(c => c.Staff)
                    .Include(c => c.Stadium);
            }
            return query.ToList();
        }

        public static Competition GetCompetition(int competitionId, bool includeAll = false)
        {
            using var db = new FootballDbContext();
            var query = db.Competitions.AsQueryable();
            if (includeAll)
            {
                query = query
                    .Include(c => c.Player)
                        .ThenInclude(p => p.Team)
                    .Include(c => c.Staff)
                    .Include(c => c.Stadium);
            }
            return query.FirstOrDefault(c => c.Id == competitionId);
        }

        public static void AddCompetition(Competition competition)
        {
            using var db = new FootballDbContext();
            db.Competitions.Add(competition);
            db.SaveChanges();
        }

        public static void UpdateCompetition(Competition competition)
        {
            using var db = new FootballDbContext();
            db.Entry(competition).State = EntityState.Modified;
            db.SaveChanges();
        }

        public static void RemoveCompetition(int competitionId)
        {
            using var db = new FootballDbContext();
            var competition = db.Competitions.Find(competitionId);
            if (competition != null)
            {
                db.Competitions.Remove(competition);
                db.SaveChanges();
            }
        }
    }
}