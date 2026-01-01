using System;
using System.Windows.Forms;
using System.Linq;
using FootballManager.Models;
using FootballManager.Services;

namespace FootballManager.UserControls.Staff
{
    public partial class DeleteStaffControl : UserControl
    {
        public DeleteStaffControl()
        {
            InitializeComponent();
            LoadStaffList();
        }

        private void LoadStaffList()
        {
            nameComboBox.Items.Clear();
            //nameComboBox.DisplayMember = "FullName";
            var staffList = FootballDataService.GetStaff();
            if (staffList.Any())
            {
                nameComboBox.Items.AddRange(staffList.ToArray());
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedItem is not Models.Staff staffToDelete)
            {
                MessageBox.Show("Select a staff member to delete!");
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete {staffToDelete.FullName}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FootballDataService.RemoveStaff(staffToDelete.Id);
                MessageBox.Show("Deleted successfully!");

                // Refresh the list
                nameComboBox.Text = "";
                LoadStaffList();
            }
        }
    }
}