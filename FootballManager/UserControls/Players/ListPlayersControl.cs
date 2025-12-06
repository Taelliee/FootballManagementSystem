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
                sortedList = sortedList
                    .OrderBy(p => p.TeamName)
                    .ThenBy(p => p.FullName)
                    .ToList();
            }
            // GK->Def->Mid->Fwd
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
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            foreach (var p in players)
            {
                dataGridView1.Rows.Add(
                    p.FullName,
                    p.TeamName,
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
