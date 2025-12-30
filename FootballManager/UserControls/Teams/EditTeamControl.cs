using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using System.IO;

namespace FootballManager.UserControls.Teams
{
    public partial class EditTeamControl : UserControl
    {
        private Team selectedTeam;
        private string originalTeamName;
        private string currentImagePath = "";

        public EditTeamControl()
        {
            InitializeComponent();
            badgePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LoadData();
            teamComboBox.SelectedIndexChanged += teamComboBox_SelectedIndexChanged;
        }

        private void LoadData()
        {
            //countryComboBox.DataSource = Enum.GetValues(typeof(Country));

            teamComboBox.Items.Clear();
            if (FootballData.Teams.Count > 0)
                teamComboBox.Items.AddRange(FootballData.Teams.Select(t => t.Name).ToArray());

            LoadCoaches();
        }

        private void LoadCoaches()
        {
            coachComboBox.Items.Clear();

            if (FootballData.StaffMembers != null)
            {
                var headCoaches = FootballData.StaffMembers
                                    .Where(s => s.Role == StaffPosition.HeadCoach)
                                    .Select(s => s.FullName)
                                    .ToArray();

                coachComboBox.Items.AddRange(headCoaches);
            }
        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teamComboBox.SelectedItem == null) return;

            string teamName = teamComboBox.SelectedItem.ToString();

            selectedTeam = FootballData.Teams.FirstOrDefault(t => t.Name == teamName);

            if (selectedTeam != null)
            {
                originalTeamName = teamName;

                nameTextBox.Text = selectedTeam.Name;
                coachComboBox.SelectedItem = selectedTeam.CoachName;
                countryComboBox.SelectedItem = selectedTeam.Country;

                if (!string.IsNullOrEmpty(selectedTeam.ImagePath) && File.Exists(selectedTeam.ImagePath))
                {
                    badgePictureBox.Image = Image.FromFile(selectedTeam.ImagePath);
                    currentImagePath = selectedTeam.ImagePath;
                }
                else
                {
                    badgePictureBox.Image = null;
                    currentImagePath = "";
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedTeam == null)
            {
                MessageBox.Show("Select a team first!");
                return;
            }

            string newName = nameTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Team name required!");
                return;
            }

            selectedTeam.Name = newName;
            selectedTeam.CoachName = coachComboBox.Text.Trim();
            selectedTeam.Country = (Country)countryComboBox.SelectedItem;
            selectedTeam.ImagePath = currentImagePath;

            FootballData.SaveData();
            FootballData.ActionHistory.Push($"Edited team: {selectedTeam.Name}");

            MessageBox.Show("Team updated successfully!");
            LoadData();
        }

        // uploading image
        private void uploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // filter - only images
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select Team Badge";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentImagePath = openFileDialog.FileName;

                    badgePictureBox.Image = Image.FromFile(currentImagePath);
                }
            }
        }
    }
}