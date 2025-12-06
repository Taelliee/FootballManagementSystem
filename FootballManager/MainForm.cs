using System.Windows.Forms.DataVisualization.Charting;
using FootballManager.Enums;
using FootballManager.UserControls.Players;
using FootballManager.UserControls.Teams;

namespace FootballManager
{
    public partial class MainForm : Form
    {
        // by default - players controls
        private EntityType currentEntity = EntityType.Players;
        private ActionType currentAction = ActionType.Add;
        public MainForm()
        {
            InitializeComponent();
            UpdateCenterPanel();
        }

        private void UpdateCenterPanel()
        {
            contentPanel.Controls.Clear();
            UserControl control = null;

            switch (currentEntity)
            {
                case EntityType.Players:
                    switch (currentAction)
                    {
                        case ActionType.Add:
                            control = new AddPlayerControl();
                            break;
                        case ActionType.Edit:
                            control = new EditPlayerControl();
                            break;
                        case ActionType.Delete:
                            control = new DeletePlayerControl();
                            break;
                        case ActionType.List:
                            control = new ListPlayersControl();
                            break;
                    }
                    break;

                case EntityType.Teams:
                    switch (currentAction)
                    {
                        case ActionType.Add:
                            control = new AddTeamControl();
                            break;
                        case ActionType.Edit:
                            control = new EditTeamControl();
                            break;
                        case ActionType.Delete:
                            control = new DeleteTeamControl();
                            break;
                        case ActionType.List:
                            control = new ListTeamsControl();
                            break;
                    }
                    break;

                case EntityType.Staff:
                    // ... staff ...
                    break;

                    // ... the other entities ...
            }

            if (control != null)
            {
                control.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(control);
            }
            else
            {
                // message working on it
                Label label = new Label();
                label.Text = $"{currentEntity} - {currentAction} is coming soon...";
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(20, 20);
                label.Font = new System.Drawing.Font("Arial", 14);
                contentPanel.Controls.Add(label);
            }
        }

        //entity buttons
        private void playersButton_Click(object sender, EventArgs e)
        {
            currentEntity = EntityType.Players;
            UpdateCenterPanel();
        }

        private void teamsButton_Click(object sender, EventArgs e)
        {
            currentEntity = EntityType.Teams;
            UpdateCenterPanel();
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            currentEntity = EntityType.Staff;
            UpdateCenterPanel();
        }

        private void competitionsButton_Click(object sender, EventArgs e)
        {
            currentEntity = EntityType.Competitions;
            UpdateCenterPanel();
        }

        private void stadiumsButton_Click(object sender, EventArgs e)
        {
            currentEntity = EntityType.Stadiums;
            UpdateCenterPanel();
        }

        private void countriesButton_Click(object sender, EventArgs e)
        {
            currentEntity = EntityType.Countries;
            UpdateCenterPanel();
        }

        //action buttons
        private void addButton_Click(object sender, EventArgs e)
        {
            currentAction = ActionType.Add;
            UpdateCenterPanel();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            currentAction = ActionType.Edit;
            UpdateCenterPanel();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            currentAction = ActionType.Delete;
            UpdateCenterPanel();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            currentAction = ActionType.List;
            UpdateCenterPanel();
        }





        private void queriesButton_Click(object sender, EventArgs e)
        {
            //disbale action buttons/panel?
        }

        //private void mainLogo_Click(object sender, EventArgs e)
        //{
        //    gifPictureBox.BringToFront();
        //    welcomeLabel.BringToFront();
        //}

        private void mainLogoPictureBox_Click(object sender, EventArgs e)
        {
            gifPictureBox.BringToFront();
            welcomeLabel.BringToFront();
        }

        private void mainLogo_Click(object sender, EventArgs e)
        {
            gifPictureBox.BringToFront();
            welcomeLabel.BringToFront();
        }

        //private void CreateChart()
        //{
        //    var chart = new Chart
        //    {
        //        Dock = DockStyle.Fill
        //    };
        //    this.Controls.Add(chart);

        //    var chartArea = new ChartArea("MainArea");
        //    chart.ChartAreas.Add(chartArea);

        //    var series = new Series("Goals")
        //    {
        //        ChartType = SeriesChartType.Column
        //    };

        //    // Example data
        //    series.Points.AddXY("Messi", 35);
        //    series.Points.AddXY("Ronaldo", 30);
        //    series.Points.AddXY("Mbappe", 28);
        //    series.Points.AddXY("Haaland", 26);
        //    series.Points.AddXY("Lewandowski", 22);

        //    chart.Series.Add(series);

        //    chart.Titles.Add("Top Scorers");
        //}
    }
}
