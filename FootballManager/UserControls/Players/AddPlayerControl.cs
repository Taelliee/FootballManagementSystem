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
using FootballManager.Enums;
using System.IO;
using FootballManager.Services;


namespace FootballManager
{
    public partial class AddPlayerControl : UserControl
    {
        public AddPlayerControl()
        {
            InitializeComponent();
            LoadFormData();
        }

        private void LoadFormData()
        {
            countryComboBox.DataSource = Enum.GetValues(typeof(Country));
            playerPositionComboBox.DataSource = Enum.GetValues(typeof(PlayerPosition));

            teamComboBox.Items.Clear();
            teamComboBox.DisplayMember = "Name";
            //if (FootballData.Teams.Count > 0)
            //{
            //    teamComboBox.Items.AddRange(FootballData.Teams.ToArray());
            //}

            if (FootballDataService.GetTeams().Count > 0)
            {
                teamComboBox.Items.AddRange(FootballDataService.GetTeams().ToArray());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text.Trim();
            string teamName = teamComboBox.Text.Trim();
            string shirtNumText = shirtNumberTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(shirtNumText))
            {
                MessageBox.Show("Please fill in all required fields (Name, Team, Shirt Number)!");
                return;
            }

            if (fullName.Any(char.IsDigit))
            {
                MessageBox.Show("Name must contain only letters!");
                return;
            }

            if (countryComboBox.SelectedItem == null || playerPositionComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select Country and Position!");
                return;
            }

            if (!int.TryParse(shirtNumText, out int shirtNumber))
            {
                MessageBox.Show("Shirt Number must be a valid integer!");
                return;
            }

            //Team selectedTeam = FootballData.Teams.FirstOrDefault(t => t.Name == teamName);
            Team selectedTeam = FootballDataService.GetTeams().FirstOrDefault(t => t.Name == teamName);
            if (selectedTeam == null)
            {
                MessageBox.Show("Selected team does not exist!");
                return;
            }

            Country selectedCountry = (Country)countryComboBox.SelectedItem;
            PlayerPosition selectedPosition = (PlayerPosition)playerPositionComboBox.SelectedItem;

            //int newId = FootballData.GetNextPlayerId();

            Player newPlayer = new Player(
                //newId,
                fullName,
                selectedCountry,
                shirtNumber,
                selectedTeam.Id,
                selectedPosition
            );

            string confirmMessage = $"Confirm Player Data:\n\n" +
                                  $"Name: {newPlayer.FullName}\n" +
                                  $"Team: {selectedTeam.Name}\n" +
                                  $"Country: {newPlayer.Country}\n" +
                                  $"Position: {newPlayer.Position}\n" +
                                  $"Shirt #: {newPlayer.ShirtNumber}\n";

            DialogResult result = MessageBox.Show(confirmMessage, "Confirm Player", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                //FootballData.AddPlayer(newPlayer);
                //FootballData.SaveData();
                FootballDataService.AddPlayer(newPlayer);

                MessageBox.Show($"Player {fullName} added successfully to team {selectedTeam.Name}!");

                ClearFields();
                LoadFormData();
            }
        }

        private void ClearFields()
        {
            fullNameTextBox.Clear();
            shirtNumberTextBox.Clear();
            teamComboBox.Text = "";
        }

        // only numbers
        private void shirtNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
