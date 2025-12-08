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
                teamComboBox.Items.AddRange(FootballData.Teams.Keys.ToArray());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text.Trim();
            string teamName = teamComboBox.Text.Trim();
            string shirtNumText = shirtNumberTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(teamName) ||
                string.IsNullOrWhiteSpace(shirtNumText))
            {
                MessageBox.Show("Please fill in all required fields (Name, Team, Shirt Number)!");
                return;
            }

            if (fullName.Any(char.IsDigit))
            {
                MessageBox.Show("Name must verify contains only letters!");
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

            /*// validation for image
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Please upload a team badge!");
                return;
            }*/

            Country selectedCountry = (Country)countryComboBox.SelectedItem;
            PlayerPosition selectedPosition = (PlayerPosition)playerPositionComboBox.SelectedItem;

            int newId = FootballData.GetNextPlayerId();

            Player newPlayer = new Player(
                newId,
                fullName,
                selectedCountry,
                shirtNumber,
                teamName,
                //selectedImagePath,
                selectedPosition
            );

            // asks to save
            string debugMessage = $" PLEASE CONFIRM DATA:\n\n" +
                                  $"ID: {newPlayer.Id}\n" +
                                  $"Name: {newPlayer.FullName}\n" +
                                  $"Team: {newPlayer.TeamName}\n" +
                                  $"Country: {newPlayer.Country}\n" +
                                  $"Position: {newPlayer.Position}\n" +
                                  $"Shirt #: {newPlayer.ShirtNumber}\n";
                                  //$"Image: {(string.IsNullOrEmpty(selectedImagePath) ? "No Image" : "Image Selected")}";

            DialogResult result = MessageBox.Show(debugMessage, "Confirm Player", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                FootballData.AddPlayer(newPlayer);
                FootballData.SaveData();

                MessageBox.Show($"Player {fullName} added successfully to team {teamName}!");

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
