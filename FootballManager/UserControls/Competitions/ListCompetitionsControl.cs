using System;
using System.Windows.Forms;
using FootballManager.Models;
using System.Linq;
using FootballManager.Services;

namespace FootballManager.UserControls.Competitions
{
    public partial class ListCompetitionsControl : UserControl
    {
        public ListCompetitionsControl()
        {
            InitializeComponent();
            LoadGrid();
        }

        public void LoadGrid()
        {
            competitionsDataGridView.AllowUserToAddRows = false;
            competitionsDataGridView.Rows.Clear();

            var competitions = FootballDataService.GetCompetitions(includeAll: true);

            foreach (var c in competitions)
            {
                string playerName = c.Player?.FullName ?? "Unknown";
                string staffName = c.Staff?.FullName ?? "Unknown";
                string stadiumName = c.Stadium?.Name ?? "Unknown";

                competitionsDataGridView.Rows.Add(
                    playerName,
                    staffName,
                    c.MatchDate.ToString("dd.MM.yyyy HH:mm"),
                    c.HostCountry.ToString(),
                    stadiumName,
                    c.GoalsScored
                );
            }
        }
    }
}