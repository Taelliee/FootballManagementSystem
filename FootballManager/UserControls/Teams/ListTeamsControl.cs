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

namespace FootballManager.UserControls.Teams
{
    public partial class ListTeamsControl : UserControl
    {
        public ListTeamsControl()
        {
            InitializeComponent();

            if (teamsDataGridView.Columns["Image"] is DataGridViewImageColumn imgCol)
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

            teamsDataGridView.RowTemplate.Height = 45;

            LoadTeams();
        }

        public void LoadTeams()
        {
            teamsDataGridView.AllowUserToAddRows = false;
            teamsDataGridView.Rows.Clear();

            // Get teams and include their coach information
            var teams = FootballDataService.GetTeams(includeCoach: true);

            foreach (var team in teams)
            {
                Image badge = team.GetImageSafe();
                string coachName = team.Coach?.FullName ?? "No Coach"; // Safely get coach name

                teamsDataGridView.Rows.Add(
                    team.Name,
                    team.Country.ToString(),
                    coachName,
                    badge
                );
            }
        }
    }
}
