using System;
using System.Windows.Forms;
using FootballManager.Models;
using FootballManager.Enums;
using FootballManager.Services;

namespace FootballManager.UserControls.Staff
{
    public partial class AddStaffControl : UserControl
    {
        public AddStaffControl()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            countryComboBox.DataSource = Enum.GetValues(typeof(Country));

            positionComboBox.DataSource = Enum.GetValues(typeof(StaffPosition));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required!");
                return;
            }

            Models.Staff newStaff = new Models.Staff
            (
                //FootballData.GetNextStaffId(),
                name,
                (Country)countryComboBox.SelectedItem,
                (StaffPosition)positionComboBox.SelectedItem
            );

            string msg = $"Confirm Staff Data:\n" +
                $"\nName: {newStaff.FullName}" +
                $"\nRole: {newStaff.Role}" +
                $"\nCountry: {newStaff.Country}";

            if (MessageBox.Show(msg, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //FootballData.AddStaff(newStaff);
                //FootballData.SaveData();
                FootballDataService.AddStaff(newStaff);

                MessageBox.Show("Staff member added successfully!");
                nameTextBox.Clear();
            }
        }
    }
}