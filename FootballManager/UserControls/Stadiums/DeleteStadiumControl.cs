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

            countryComboBox.DataSource = Enum.GetValues(typeof(Country));
            countryComboBox.SelectedIndexChanged += countryComboBox_SelectedIndexChanged;
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameComboBox.Items.Clear();
            nameComboBox.Text = "";

            if (countryComboBox.SelectedItem == null) return;

            Country selectedCountry = (Country)countryComboBox.SelectedItem;

            var stadiumsInCountry = FootballData.Stadiums
                                    .Where(s => s.Country == selectedCountry)
                                    .Select(s => s.Name)
                                    .ToArray();

            nameComboBox.Items.AddRange(stadiumsInCountry);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameComboBox.Text))
            {
                MessageBox.Show("Select a stadium!");
                return;
            }

            string name = nameComboBox.Text;
            var stadiumToDelete = FootballData.Stadiums.FirstOrDefault(s => s.Name == name);

            if (stadiumToDelete != null)
            {
                if (MessageBox.Show($"Delete {name}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    FootballData.RemoveStadium(stadiumToDelete);
                    FootballData.SaveData();
                    MessageBox.Show("Deleted!");

                    countryComboBox_SelectedIndexChanged(null, null);
                    nameComboBox.Text = "";
                }
            }
        }
    }
}