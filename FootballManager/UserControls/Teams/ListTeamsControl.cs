using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballManager.UserControls.Teams
{
    public partial class ListTeamsControl : UserControl
    {
        public ListTeamsControl()
        {
            InitializeComponent();
            LoadTeams();
        }

        public void LoadTeams()
        {
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Rows.Clear();

            // Dictionary -> .Values
            var teams = FootballData.Teams.Values.ToList();

            foreach (var team in teams)
            {
                Image badge = team.GetImageSafe();
                dataGridView1.Rows.Add(
                    team.Name,
                    team.Country,
                    team.CoachName,
                    badge
                );
            }
        }
    }
}
