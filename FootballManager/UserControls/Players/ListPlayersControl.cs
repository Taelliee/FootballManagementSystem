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

namespace FootballManager.UserControls.Players
{
    public partial class ListPlayersControl : UserControl
    {
        public ListPlayersControl()
        {
            InitializeComponent();

            teamRadioButton.CheckedChanged += FilterChanged;
            countryRadioButton.CheckedChanged += FilterChanged;
            positionRadioButton.CheckedChanged += FilterChanged;

            // default
            teamRadioButton.Checked = true;
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            if (FootballData.Players == null) return;

            List<Player> sortedList = FootballData.Players.ToList();

            if (teamRadioButton.Checked)
            {
                // Sort by Team.Name (via navigation property or lookup)
                sortedList = sortedList
                    .OrderBy(p => p.Team != null ? p.Team.Name : FootballData.Teams.FirstOrDefault(t => t.Id == p.TeamId)?.Name ?? "No Team")
                    .ThenBy(p => p.FullName)
                    .ToList();
            }
            else if (countryRadioButton.Checked)
            {
                sortedList = sortedList
                    .OrderBy(p => p.Country)
                    .ThenBy(p => p.Position)
                    .ToList();
            }
            else if (positionRadioButton.Checked)
            {
                sortedList = sortedList
                    .OrderBy(p => p.Position)
                    .ThenBy(p => p.FullName)
                    .ToList();
            }

            PopulateGrid(sortedList);
        }

        private void PopulateGrid(List<Player> players)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            foreach (var p in players)
            {
                // Get team name via navigation property or lookup
                string teamName = p.Team != null
                    ? p.Team.Name
                    : FootballData.Teams.FirstOrDefault(t => t.Id == p.TeamId)?.Name ?? "No Team";

                dataGridView1.Rows.Add(
                    p.FullName,
                    teamName,
                    p.Country,
                    p.ShirtNumber,
                    p.Position
                );
            }
        }

        public void Reload()
        {
            FilterChanged(null, null);
        }
    }
}
