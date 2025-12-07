using System;
using System.Windows.Forms;

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
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            foreach (var s in FootballData.StaffMembers)
            {
                dataGridView1.Rows.Add(s.FullName, s.Country, s.Role);
            }
        }
    }
}