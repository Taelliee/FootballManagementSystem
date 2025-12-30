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
            if (FootballData.Teams.Count > 0)
            {
                teamComboBox.Items.AddRange(FootballData.Teams.Select(t => t.Name).ToArray());
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

            Team selectedTeam = FootballData.Teams.FirstOrDefault(t => t.Name == teamName);
            if (selectedTeam == null)
            {
                MessageBox.Show("Selected team does not exist!");
                return;
            }

            Country selectedCountry = (Country)countryComboBox.SelectedItem;
            PlayerPosition selectedPosition = (PlayerPosition)playerPositionComboBox.SelectedItem;

            int newId = FootballData.GetNextPlayerId();

            Player newPlayer = new Player(
                newId,
                fullName,
                selectedCountry,
                shirtNumber,
                selectedTeam.Id,
                selectedPosition
            );

            string debugMessage = $" PLEASE CONFIRM DATA:\n\n" +
                                  $"ID: {newPlayer.Id}\n" +
                                  $"Name: {newPlayer.FullName}\n" +
                                  $"Team: {selectedTeam.Name}\n" +
                                  $"Country: {newPlayer.Country}\n" +
                                  $"Position: {newPlayer.Position}\n" +
                                  $"Shirt #: {newPlayer.ShirtNumber}\n";

            DialogResult result = MessageBox.Show(debugMessage, "Confirm Player", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                FootballData.AddPlayer(newPlayer);
                FootballData.SaveData();

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
            //badgePictureBox.Image = null;
            //selectedImagePath = "";
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
