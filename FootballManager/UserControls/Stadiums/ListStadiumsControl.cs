using System;
using System.Linq;
using System.Windows.Forms;
using FootballManager.Models;

namespace FootballManager.UserControls.Stadiums
{
    public partial class ListStadiumsControl : UserControl
    {
        public ListStadiumsControl()
        {
            InitializeComponent();
            LoadGrid();
        }

        public void LoadGrid()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            foreach (var s in FootballData.Stadiums)
            {
                dataGridView1.Rows.Add(s.Name, s.Country, s.Capacity);
            }
        }
    }
}