using System;
using System.Windows.Forms;
using FootballManager.Models;
using System.Linq;

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
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();


            foreach (var c in FootballData.Competitions)
            {
                var player = FootballData.Players.FirstOrDefault(p => p.Id == c.PlayerId);
                string playerName = player != null ? player.FullName : "Unknown";

                var staff = FootballData.StaffMembers.FirstOrDefault(s => s.Id == c.StaffId);
                string staffName = staff != null ? staff.FullName : "Unknown";

                dataGridView1.Rows.Add(
                    playerName,
                    staffName,
                    c.MatchDate.ToString("dd.MM.yyyy HH:mm"),
                    c.HostCountry,
                    c.Stadium,
                    c.GoalsScored
                );
            }
        }
    }
}