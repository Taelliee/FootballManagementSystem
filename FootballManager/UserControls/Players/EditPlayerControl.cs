using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using FootballManager.Models;
using FootballManager.Enums;
using FootballManager.Services;

namespace FootballManager.UserControls.Players
{
    public partial class EditPlayerControl : UserControl
    {
        private Player selectedPlayer;

        public EditPlayerControl()
        {
            InitializeComponent();
            LoadData();

            fullNameComboBox.SelectedIndexChanged += fullNameComboBox_SelectedIndexChanged;
            shirtNumberTextBox.KeyPress += (s, e) => { if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true; };
        }

        private void LoadData()
        {
            countryComboBox.DataSource = Enum.GetValues(typeof(Country));
            playerPositionComboBox.DataSource = Enum.GetValues(typeof(PlayerPosition));

            // Load Teams
            teamComboBox.Items.Clear();
            teamComboBox.DisplayMember = "Name";
            var teams = FootballDataService.GetTeams();
            if (teams.Any())
            {
                teamComboBox.Items.AddRange(teams.ToArray());
            }

            // Load Players
            fullNameComboBox.Items.Clear();
            fullNameComboBox.DisplayMember = "FullName";
            var players = FootballDataService.GetPlayers();
            if (players.Any())
            {
                fullNameComboBox.Items.AddRange(players.ToArray());
            }

            ClearFields();
        }

        private void fullNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fullNameComboBox.SelectedItem is not Player player) return;

            selectedPlayer = player;

            newNameTextBox.Text = selectedPlayer.FullName;
            shirtNumberTextBox.Text = selectedPlayer.ShirtNumber.ToString();
            countryComboBox.SelectedItem = selectedPlayer.Country;
            playerPositionComboBox.SelectedItem = selectedPlayer.Position;

            // Find and select the player's team
            var team = teamComboBox.Items.OfType<Team>().FirstOrDefault(t => t.Id == selectedPlayer.TeamId);
            if (team != null)
            {
                teamComboBox.SelectedItem = team;
            }
            else
            {
                teamComboBox.SelectedIndex = -1;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedPlayer == null)
            {
                MessageBox.Show("Please select a player to edit first!");
                return;
            }

            string newName = newNameTextBox.Text.Trim();
            Team newTeam = (Team)teamComboBox.SelectedItem;
            string newShirtStr = shirtNumberTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName) || newTeam == null || string.IsNullOrWhiteSpace(newShirtStr))
            {
                MessageBox.Show("All fields (Name, Team, Shirt) are required!");
                return;
            }

            if (newName.Any(char.IsDigit))
            {
                MessageBox.Show("Name must contain only letters!");
                return;
            }

            // Update the selected player object
            selectedPlayer.FullName = newName;
            selectedPlayer.TeamId = newTeam.Id; // Assign the Team's ID
            selectedPlayer.Country = (Country)countryComboBox.SelectedItem;
            selectedPlayer.Position = (PlayerPosition)playerPositionComboBox.SelectedItem;
            selectedPlayer.ShirtNumber = int.Parse(newShirtStr);

            // Save changes to the database
            if (MessageBox.Show("Save changes?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FootballDataService.UpdatePlayer(selectedPlayer);
                MessageBox.Show("Player updated successfully!");

                // Refresh the form
                int selectedIndex = fullNameComboBox.SelectedIndex;
                LoadData();
                fullNameComboBox.SelectedIndex = selectedIndex;
            }
        }

        private void ClearFields()
        {
            fullNameComboBox.Text = "";
            newNameTextBox.Clear();
            shirtNumberTextBox.Clear();
            teamComboBox.Text = "";
            selectedPlayer = null;
        }
    }
}