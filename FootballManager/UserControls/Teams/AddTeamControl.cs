using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using FootballManager.Services;

namespace FootballManager.UserControls.Teams
{
    public partial class AddTeamControl : UserControl
    {
        private string selectedImagePath = "";

        public AddTeamControl()
        {
            InitializeComponent();
            badgePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            countryComboBox.DataSource = Enum.GetValues(typeof(Country));

            LoadCoaches();
        }

        public void LoadCoaches()
        {
            coachComboBox.Items.Clear();
            coachComboBox.DisplayMember = "FullName";

            //var headCoaches = FootballData.StaffMembers
            var headCoaches = FootballDataService.GetStaff()
                                .Where(s => s.Role == StaffPosition.HeadCoach)
                                .ToArray();

            //if (FootballData.StaffMembers != null)
            if (headCoaches.Any())
            {
                coachComboBox.Items.AddRange(headCoaches);
            }
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
                    selectedImagePath = openFileDialog.FileName;

                    badgePictureBox.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            Models.Staff selectedCoach = (Models.Staff)coachComboBox.SelectedItem;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Team name is required!");
                return;
            }

            if (selectedCoach == null)
            {
                MessageBox.Show("Please select a coach!");
                return;
            }

            if (FootballDataService.GetTeams().Any(t => t.Name == name))
            {
                MessageBox.Show("Team already exists!");
                return;
            }

            Country country = (Country)countryComboBox.SelectedItem;

            Team newTeam = new Team
            (
                name,
                selectedCoach.Id, // Use the Coach's ID
                country,
                selectedImagePath
            );

            string confirmMessage = $"Confirm Team Data:\n\n" +
                                  $"Name: {newTeam.Name}\n" +
                                  $"Coach: {selectedCoach.FullName}\n" +
                                  $"Country: {newTeam.Country}\n";

            var result = MessageBox.Show(confirmMessage, "Confirm Add", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                FootballDataService.AddTeam(newTeam);

                MessageBox.Show("Team added successfully!");
                nameTextBox.Clear();
                coachComboBox.SelectedIndex = -1;
                coachComboBox.Text = "";
                badgePictureBox.Image = null;
                selectedImagePath = "";
            }
        }
    }
}