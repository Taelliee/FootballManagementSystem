using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;

namespace FootballManager.UserControls.Players
{
    public partial class EditPlayerControl : UserControl
    {
        private Player selectedPlayer; // old info for player
        private string currentImagePath = "";

        public EditPlayerControl()
        {
            InitializeComponent();

            badgePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            uploadButton.Click += uploadButton_Click;

            LoadData();

            fullNameComboBox.SelectedIndexChanged += fullNameComboBox_SelectedIndexChanged;
            shirtNumberTextBox.KeyPress += (s, e) => { if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true; };
        }

        private void LoadData()
        {
            countryComboBox.DataSource = Enum.GetValues(typeof(Country));
            playerPositionComboBox.DataSource = Enum.GetValues(typeof(PlayerPosition));

            teamComboBox.Items.Clear();
            if (FootballData.Teams.Count > 0)
                teamComboBox.Items.AddRange(FootballData.Teams.Keys.ToArray());
            teamComboBox.DropDownStyle = ComboBoxStyle.DropDown;

            fullNameComboBox.Items.Clear();
            foreach (var p in FootballData.Players)
            {
                fullNameComboBox.Items.Add(p.FullName); // add id?
            }
        }

        private void fullNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fullNameComboBox.SelectedItem == null) return;

            string name = fullNameComboBox.SelectedItem.ToString();

            selectedPlayer = FootballData.Players.FirstOrDefault(p => p.FullName == name);

            if (selectedPlayer != null)
            {
                // filling old info
                shirtNumberTextBox.Text = selectedPlayer.ShirtNumber.ToString();
                teamComboBox.Text = selectedPlayer.TeamName;
                countryComboBox.SelectedItem = selectedPlayer.Country;
                playerPositionComboBox.SelectedItem = selectedPlayer.Position;


                // image
                if (!string.IsNullOrEmpty(selectedPlayer.ImagePath) && File.Exists(selectedPlayer.ImagePath))
                {
                    badgePictureBox.Image = Image.FromFile(selectedPlayer.ImagePath);
                    currentImagePath = selectedPlayer.ImagePath;
                }
                else
                {
                    badgePictureBox.Image = null;
                    currentImagePath = "";
                }
            }
        }
        // new image upload
        private void uploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select New Badge";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentImagePath = openFileDialog.FileName;
                    badgePictureBox.Image = Image.FromFile(currentImagePath);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedPlayer == null)
            {
                MessageBox.Show("Please select a player to edit first!");
                return;
            }

            string newTeam = teamComboBox.Text.Trim();
            string newShirtStr = shirtNumberTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newTeam) || string.IsNullOrWhiteSpace(newShirtStr))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            // updating object - directly in memory
            selectedPlayer.TeamName = newTeam;
            selectedPlayer.Country = (Country)countryComboBox.SelectedItem;
            selectedPlayer.Position = (PlayerPosition)playerPositionComboBox.SelectedItem;
            selectedPlayer.ShirtNumber = int.Parse(newShirtStr);
            selectedPlayer.ImagePath = currentImagePath;

            if (!FootballData.Teams.ContainsKey(newTeam))
            {
                Team t = new Team { Name = newTeam, Country = selectedPlayer.Country };
                FootballData.Teams.Add(newTeam, t);
            }

            // save
            if (MessageBox.Show("Save changes?", "Confirm Edit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FootballData.SaveData();
                FootballData.ActionHistory.Push($"Edited player: {selectedPlayer.FullName}");
                MessageBox.Show("Player updated successfully!");

                LoadData();

                fullNameComboBox.Text = "";
                badgePictureBox.Image = null;
                ClearFields();
            }
        }
        private void ClearFields()
        {
            shirtNumberTextBox.Clear();
            teamComboBox.Text = "";
            badgePictureBox.Image = null;
            selectedPlayer = null;
        }
    }
}