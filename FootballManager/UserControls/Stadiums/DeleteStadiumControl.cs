using System;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using System.Linq;
using System.Data;

namespace FootballManager.UserControls.Stadiums
{
    public partial class DeleteStadiumControl : UserControl
    {
        public DeleteStadiumControl()
        {
            InitializeComponent();

            // Populate countryComboBox with "- All Countries -" first, then all countries
            countryComboBox.Items.Clear();
            countryComboBox.Items.Add("- All Countries -");
            foreach (var country in Enum.GetValues(typeof(Country)))
            {
                countryComboBox.Items.Add(country);
            }

            countryComboBox.SelectedIndexChanged += countryComboBox_SelectedIndexChanged;
            countryComboBox.SelectedIndex = 0;
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stadiumComboBox.Items.Clear();
            stadiumComboBox.Text = "";

            if (countryComboBox.SelectedIndex == 0)
            {
                // Show all stadiums if "- All Countries -" is selected
                stadiumComboBox.Items.AddRange(FootballData.Stadiums.Select(s => s.Name).ToArray());
                if (stadiumComboBox.Items.Count > 0)
                    stadiumComboBox.SelectedIndex = 0;
                return;
            }



            if (countryComboBox.SelectedItem == null) return;

            Country selectedCountry = (Country)countryComboBox.SelectedItem;

            var stadiumsInCountry = FootballData.Stadiums
                                .Where(s => s.Country == selectedCountry)
                                .Select(s => s.Name)
                                .ToArray();

            stadiumComboBox.Items.AddRange(stadiumsInCountry);
        }

        private void LoadStadiums()
        {
            stadiumComboBox.Items.Clear();
            if (FootballData.Stadiums.Count > 0)
                stadiumComboBox.Items.AddRange(FootballData.Stadiums.Select(s => s.Name).ToArray());
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (stadiumComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select a stadium first!");
                return;
            }

            string selectedStadiumName = stadiumComboBox.SelectedItem.ToString();
            var stadiumToDelete = FootballData.Stadiums.FirstOrDefault(s => s.Name == selectedStadiumName);

            if (stadiumToDelete == null)
            {
                MessageBox.Show("Stadium not found!");
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete the stadium {stadiumToDelete.Name}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                FootballData.Stadiums.Remove(stadiumToDelete);
                FootballData.SaveData();

                MessageBox.Show("Stadium deleted successfully!");
                LoadStadiums();
            }
        }
    }
}