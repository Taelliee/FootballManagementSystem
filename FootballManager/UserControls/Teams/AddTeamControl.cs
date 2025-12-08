using System;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;

namespace FootballManager.UserControls.Teams
{
    public partial class AddTeamControl : UserControl
    {
        public AddTeamControl()
        {
            InitializeComponent();
            countryComboBox.DataSource = Enum.GetValues(typeof(Country));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string coach = coachTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Team name is required!");
                return;
            }

            // checking in Dictionary if team exists
            if (FootballData.Teams.ContainsKey(name))
            {
                MessageBox.Show("Team already exists!");
                return;
            }

            Country country = (Country)countryComboBox.SelectedItem;

            Team newTeam = new Team
            (
                FootballData.GetNextTeamId(),
                name,
                coach,
                country
            );

            // saving to Dictionary
            FootballData.Teams.Add(name, newTeam);

            MessageBox.Show("Team added successfully!");
            nameTextBox.Clear();
            coachTextBox.Clear();
        }
    }
}