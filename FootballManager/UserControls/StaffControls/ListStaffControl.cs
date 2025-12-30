using System;
using System.Windows.Forms;
using FootballManager.Services;

namespace FootballManager.UserControls.Staff
{
    public partial class ListStaffControl : UserControl
    {
        public ListStaffControl()
        {
            InitializeComponent();
            LoadGrid();
        }

        public void LoadGrid()
        {
            staffDataGridView.AllowUserToAddRows = false;
            staffDataGridView.Rows.Clear();

            var staffList = FootballDataService.GetStaff();

            foreach (var s in staffList)
            {
                staffDataGridView.Rows.Add(s.FullName, s.Country.ToString(), s.Role.ToString());
            }
        }
    }
}