using System.Windows.Forms.DataVisualization.Charting;
using FootballManager.Enums;
using FootballManager.UserControls.Competitions;
using FootballManager.UserControls.Players;
using FootballManager.UserControls.Queries;
using FootballManager.UserControls.Stadiums;
using FootballManager.UserControls.Staff;
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
            FootballData.LoadData();
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

                case EntityType.Competitions:
                    switch (currentAction)
                    {
                        case ActionType.Add:
                            control = new AddCompetitionControl();
                            break;
                        case ActionType.Edit:
                            control = new EditCompetitionControl();
                            break;
                        case ActionType.Delete:
                            control = new DeleteCompetitionControl();
                            break;
                        case ActionType.List:
                            control = new ListCompetitionsControl();
                            break;
                    }
                    break;

                case EntityType.Staff:
                    switch (currentAction)
                    {
                        case ActionType.Add:
                            control = new AddStaffControl();
                            break;
                        case ActionType.Edit:
                            control = new EditStaffControl();
                            break;
                        case ActionType.Delete:
                            control = new DeleteStaffControl();
                            break;
                        case ActionType.List:
                            control = new ListStaffControl();
                            break;
                    }
                    break;

                case EntityType.Stadiums:
                    switch (currentAction)
                    {
                        case ActionType.Add:
                            control = new AddStadiumControl();
                            break;
                        case ActionType.Edit:
                            control = new EditStadiumControl();
                            break;
                        case ActionType.Delete:
                            control = new DeleteStadiumControl();
                            break;
                        case ActionType.List:
                            control = new ListStadiumsControl();
                            break;
                    }
                    break;


            }

            if (control != null)
            {
                control.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(control);
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
            contentPanel.Controls.Clear();
            UserControl control = new QueriesControl();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
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

        /*private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FootballData.SaveData();
        }*/
    }
}
