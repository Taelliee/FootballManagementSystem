using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FootballManager.Enums;
using FootballManager.Models;

namespace FootballManager.UserControls.Teams
{
    public partial class DeleteTeamControl : UserControl
    {
        public DeleteTeamControl()
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

            // LINQ
            var teamsInCountry = FootballData.Teams.Values
                .Where(t => t.Country == selectedCountry)
                .Select(t => t.Name)
                .ToArray();

            nameComboBox.Items.AddRange(teamsInCountry);

            if (nameComboBox.Items.Count > 0)
                nameComboBox.SelectedIndex = 0;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameComboBox.Text))
            {
                MessageBox.Show("Select a team to delete!");
                return;
            }

            string teamName = nameComboBox.Text;

            // save
            var result = MessageBox.Show(
                $"Are you sure you want to delete team '{teamName}'?\nThis cannot be undone.",
                "Confirm Team Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                FootballData.RemoveTeam(teamName);
                FootballData.SaveData();

                MessageBox.Show("Team deleted successfully!");

                countryComboBox_SelectedIndexChanged(sender, e);
            }
        }
    }
}