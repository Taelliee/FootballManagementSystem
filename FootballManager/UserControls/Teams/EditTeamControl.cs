using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using System.IO;
using FootballManager.Services;

namespace FootballManager.UserControls.Teams
{
    public partial class EditTeamControl : UserControl
    {
        private Team selectedTeam;
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
            countryComboBox.DataSource = Enum.GetValues(typeof(Country));

            // Load teams into the teamComboBox
            teamComboBox.Items.Clear();
            teamComboBox.DisplayMember = "Name";
            var teams = FootballDataService.GetTeams();
            if (teams.Any())
            {
                teamComboBox.Items.AddRange(teams.ToArray());
            }

            LoadCoaches();
        }

        private void LoadCoaches()
        {
            // Load coaches into the coachComboBox
            coachComboBox.Items.Clear();
            coachComboBox.DisplayMember = "FullName";
            var headCoaches = FootballDataService.GetStaff()
                                .Where(s => s.Role == StaffPosition.HeadCoach)
                                .ToArray();

            if (headCoaches.Any())
            {
                coachComboBox.Items.AddRange(headCoaches);
            }
        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teamComboBox.SelectedItem is not Team team) return;

            selectedTeam = team;

            nameTextBox.Text = selectedTeam.Name;
            countryComboBox.SelectedItem = selectedTeam.Country;

            // Select the correct coach in the coachComboBox
            var coach = coachComboBox.Items.OfType<Models.Staff>().FirstOrDefault(s => s.Id == selectedTeam.CoachId);
            if (coach != null)
            {
                coachComboBox.SelectedItem = coach;
            }
            else
            {
                coachComboBox.SelectedIndex = -1;
            }

            // Handle image display
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

            // Update the selected team object
            selectedTeam.Name = newName;
            selectedTeam.Country = (Country)countryComboBox.SelectedItem;
            selectedTeam.ImagePath = currentImagePath;

            if (coachComboBox.SelectedItem is Models.Staff selectedCoach)
            {
                selectedTeam.CoachId = selectedCoach.Id;
            }
            else
            {
                selectedTeam.CoachId = null; // A team can exist without a coach
            }

            // Save changes to the database
            FootballDataService.UpdateTeam(selectedTeam);

            MessageBox.Show("Team updated successfully!");

            // Refresh the data in the form
            int selectedIndex = teamComboBox.SelectedIndex;
            LoadData();
            teamComboBox.SelectedIndex = selectedIndex;
        }

        // uploading image
        private void uploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select Team Badge";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentImagePath = openFileDialog.FileName;
                    badgePictureBox.Image = Image.FromFile(currentImagePath);
                }
            }
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}