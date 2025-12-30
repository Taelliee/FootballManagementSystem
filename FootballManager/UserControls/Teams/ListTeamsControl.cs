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

            if (dataGridView1.Columns["Image"] is DataGridViewImageColumn imgCol)
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

            dataGridView1.RowTemplate.Height = 45;

            LoadTeams();
        }

        public void LoadTeams()
        {
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Rows.Clear();

            var teams = FootballData.Teams.ToList();

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
