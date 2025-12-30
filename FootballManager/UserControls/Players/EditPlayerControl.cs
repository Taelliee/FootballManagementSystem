using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using FootballManager.Models;
using FootballManager.Enums;

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

            teamComboBox.Items.Clear();
            teamComboBox.DisplayMember = "Name";
            if (FootballData.Teams.Count > 0)
                teamComboBox.Items.AddRange(FootballData.Teams.ToArray());

            fullNameComboBox.Items.Clear();
            foreach (var p in FootballData.Players)
            {
                fullNameComboBox.Items.Add(p.FullName);
            }

            newNameTextBox.Clear();
        }

        private void fullNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fullNameComboBox.SelectedItem == null) return;

            string name = fullNameComboBox.SelectedItem.ToString();

            selectedPlayer = FootballData.Players.FirstOrDefault(p => p.FullName == name);

            if (selectedPlayer != null)
            {
                newNameTextBox.Text = selectedPlayer.FullName;
                shirtNumberTextBox.Text = selectedPlayer.ShirtNumber.ToString();

                if (selectedPlayer.TeamId != 0)
                {
                    var team = FootballData.Teams.FirstOrDefault(t => t.Id == selectedPlayer.TeamId);
                    teamComboBox.SelectedItem = team;
                }
                else
                {
                    teamComboBox.SelectedItem = null;
                }

                countryComboBox.SelectedItem = selectedPlayer.Country;
                playerPositionComboBox.SelectedItem = selectedPlayer.Position;
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

            selectedPlayer.FullName = newName;
            selectedPlayer.Team = newTeam;
            selectedPlayer.Country = (Country)countryComboBox.SelectedItem;
            selectedPlayer.Position = (PlayerPosition)playerPositionComboBox.SelectedItem;
            selectedPlayer.ShirtNumber = int.Parse(newShirtStr);

            if (!FootballData.Teams.Contains(newTeam))
            {
                Team t = new Team { Name = newTeam.Name, Country = selectedPlayer.Country };
                FootballData.Teams.Add(t);
            }

            // save
            if (MessageBox.Show("Save changes?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FootballData.SaveData();
                FootballData.ActionHistory.Push($"Edited player: {selectedPlayer.FullName}");
                MessageBox.Show("Player updated successfully!");

                LoadData();

                ClearFields();
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