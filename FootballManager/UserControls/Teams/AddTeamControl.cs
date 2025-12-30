using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;

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

            if (FootballData.StaffMembers != null)
            {
                var headCoaches = FootballData.StaffMembers
                                    .Where(s => s.Role == StaffPosition.HeadCoach)
                                    .Select(s => s.FullName)
                                    .ToArray();

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
            string coach = coachComboBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Team name is required!");
                return;
            }

            if (FootballData.Teams.Any(t => t.Name == name))
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
                country,
                selectedImagePath
            );

            FootballData.Teams.Add(newTeam);

            MessageBox.Show("Team added successfully!");
            nameTextBox.Clear();
            coachComboBox.SelectedIndex = -1;
            coachComboBox.Text = "";
            badgePictureBox.Image = null;
            selectedImagePath = "";
        }
    }
}