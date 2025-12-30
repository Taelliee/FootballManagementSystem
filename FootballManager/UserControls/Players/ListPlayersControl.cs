using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Services;

namespace FootballManager.UserControls.Players
{
    public partial class ListPlayersControl : UserControl
    {
        public ListPlayersControl()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void LoadGrid()
        {
            // Fetch players and their team information from the database
            var players = FootballDataService.GetPlayers(includeTeam: true);
            PopulateGrid(players);
        }

        private void PopulateGrid(List<Player> players)
        {
            playersDataGridView.DataSource = null;
            playersDataGridView.Rows.Clear();
            playersDataGridView.AllowUserToAddRows = false;

            if (players == null) return;

            foreach (var p in players)
            {
                // The p.Team navigation property is loaded by GetPlayers(includeTeam: true)
                string teamName = p.Team?.Name ?? "No Team";

                playersDataGridView.Rows.Add(
                    p.FullName,
                    teamName,
                    p.Country.ToString(),
                    p.ShirtNumber,
                    p.Position.ToString()
                );
            }
        }

        public void Reload()
        {
            LoadGrid();
        }
    }
}
