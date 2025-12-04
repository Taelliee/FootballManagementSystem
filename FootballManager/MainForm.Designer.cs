namespace FootballManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            contentPanel = new Panel();
            welcomeLabel = new Label();
            gifPictureBox = new PictureBox();
            topNavigationPanel = new Panel();
            mainLogo = new Label();
            mainLogoPictureBox = new PictureBox();
            listButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            playersButton = new Button();
            teamsButton = new Button();
            competitionsButton = new Button();
            staffButton = new Button();
            stadiumsButton = new Button();
            queriesButton = new Button();
            leftNavigationSplitContainer = new SplitContainer();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gifPictureBox).BeginInit();
            topNavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainLogoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftNavigationSplitContainer).BeginInit();
            leftNavigationSplitContainer.Panel1.SuspendLayout();
            leftNavigationSplitContainer.Panel2.SuspendLayout();
            leftNavigationSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(welcomeLabel);
            contentPanel.Controls.Add(gifPictureBox);
            contentPanel.Location = new Point(154, 72);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(830, 580);
            contentPanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = Color.White;
            welcomeLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            welcomeLabel.ForeColor = Color.DarkRed;
            welcomeLabel.Location = new Point(81, 457);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(669, 81);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "Welcome to the game!";
            // 
            // gifPictureBox
            // 
            gifPictureBox.Image = Properties.Resources.ball_dribbles;
            gifPictureBox.Location = new Point(15, 0);
            gifPictureBox.Name = "gifPictureBox";
            gifPictureBox.Size = new Size(800, 600);
            gifPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            gifPictureBox.TabIndex = 0;
            gifPictureBox.TabStop = false;
            // 
            // topNavigationPanel
            // 
            topNavigationPanel.BackColor = Color.DarkSlateGray;
            topNavigationPanel.Controls.Add(mainLogo);
            topNavigationPanel.Controls.Add(mainLogoPictureBox);
            topNavigationPanel.Controls.Add(listButton);
            topNavigationPanel.Controls.Add(deleteButton);
            topNavigationPanel.Controls.Add(editButton);
            topNavigationPanel.Controls.Add(addButton);
            topNavigationPanel.Location = new Point(3, 2);
            topNavigationPanel.Name = "topNavigationPanel";
            topNavigationPanel.Size = new Size(981, 64);
            topNavigationPanel.TabIndex = 1;
            // 
            // mainLogo
            // 
            mainLogo.AutoSize = true;
            mainLogo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mainLogo.ForeColor = Color.White;
            mainLogo.Location = new Point(128, 14);
            mainLogo.Name = "mainLogo";
            mainLogo.Size = new Size(204, 31);
            mainLogo.TabIndex = 6;
            mainLogo.Text = "Football Manager";
            mainLogo.Click += mainLogo_Click;
            // 
            // mainLogoPictureBox
            // 
            mainLogoPictureBox.Image = Properties.Resources.ball_icon;
            mainLogoPictureBox.Location = new Point(21, 6);
            mainLogoPictureBox.Name = "mainLogoPictureBox";
            mainLogoPictureBox.Size = new Size(101, 55);
            mainLogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            mainLogoPictureBox.TabIndex = 5;
            mainLogoPictureBox.TabStop = false;
            mainLogoPictureBox.Click += mainLogoPictureBox_Click;
            // 
            // listButton
            // 
            listButton.BackColor = Color.WhiteSmoke;
            listButton.Cursor = Cursors.Hand;
            listButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            listButton.ForeColor = Color.DarkSlateGray;
            listButton.Location = new Point(846, 13);
            listButton.Name = "listButton";
            listButton.Size = new Size(115, 40);
            listButton.TabIndex = 4;
            listButton.Text = "List";
            listButton.UseVisualStyleBackColor = false;
            listButton.Click += listButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.WhiteSmoke;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteButton.ForeColor = Color.DarkSlateGray;
            deleteButton.Location = new Point(694, 13);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(115, 40);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.WhiteSmoke;
            editButton.Cursor = Cursors.Hand;
            editButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            editButton.ForeColor = Color.DarkSlateGray;
            editButton.Location = new Point(537, 13);
            editButton.Name = "editButton";
            editButton.Size = new Size(115, 40);
            editButton.TabIndex = 2;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.WhiteSmoke;
            addButton.Cursor = Cursors.Hand;
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addButton.ForeColor = Color.DarkSlateGray;
            addButton.Location = new Point(380, 13);
            addButton.Name = "addButton";
            addButton.Size = new Size(115, 40);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // playersButton
            // 
            playersButton.Anchor = AnchorStyles.None;
            playersButton.BackColor = Color.WhiteSmoke;
            playersButton.Cursor = Cursors.Hand;
            playersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            playersButton.ForeColor = Color.DarkRed;
            playersButton.Location = new Point(15, 49);
            playersButton.Name = "playersButton";
            playersButton.Size = new Size(115, 40);
            playersButton.TabIndex = 0;
            playersButton.Text = "Players";
            playersButton.UseVisualStyleBackColor = false;
            playersButton.Click += playersButton_Click;
            // 
            // teamsButton
            // 
            teamsButton.Anchor = AnchorStyles.None;
            teamsButton.BackColor = Color.WhiteSmoke;
            teamsButton.Cursor = Cursors.Hand;
            teamsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            teamsButton.ForeColor = Color.DarkRed;
            teamsButton.Location = new Point(15, 138);
            teamsButton.Name = "teamsButton";
            teamsButton.Size = new Size(115, 40);
            teamsButton.TabIndex = 1;
            teamsButton.Text = "Teams";
            teamsButton.UseVisualStyleBackColor = false;
            teamsButton.Click += teamsButton_Click;
            // 
            // competitionsButton
            // 
            competitionsButton.Anchor = AnchorStyles.None;
            competitionsButton.BackColor = Color.WhiteSmoke;
            competitionsButton.Cursor = Cursors.Hand;
            competitionsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            competitionsButton.ForeColor = Color.DarkRed;
            competitionsButton.Location = new Point(15, 302);
            competitionsButton.Name = "competitionsButton";
            competitionsButton.Size = new Size(115, 40);
            competitionsButton.TabIndex = 3;
            competitionsButton.Text = "Competitions";
            competitionsButton.UseVisualStyleBackColor = false;
            competitionsButton.Click += competitionsButton_Click;
            // 
            // staffButton
            // 
            staffButton.Anchor = AnchorStyles.None;
            staffButton.BackColor = Color.WhiteSmoke;
            staffButton.Cursor = Cursors.Hand;
            staffButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            staffButton.ForeColor = Color.DarkRed;
            staffButton.Location = new Point(15, 220);
            staffButton.Name = "staffButton";
            staffButton.Size = new Size(115, 40);
            staffButton.TabIndex = 2;
            staffButton.Text = "Staff";
            staffButton.UseVisualStyleBackColor = false;
            staffButton.Click += staffButton_Click;
            // 
            // stadiumsButton
            // 
            stadiumsButton.Anchor = AnchorStyles.None;
            stadiumsButton.BackColor = Color.WhiteSmoke;
            stadiumsButton.Cursor = Cursors.Hand;
            stadiumsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            stadiumsButton.ForeColor = Color.DarkRed;
            stadiumsButton.Location = new Point(15, 386);
            stadiumsButton.Name = "stadiumsButton";
            stadiumsButton.Size = new Size(115, 40);
            stadiumsButton.TabIndex = 4;
            stadiumsButton.Text = "Stadiums";
            stadiumsButton.UseVisualStyleBackColor = false;
            stadiumsButton.Click += stadiumsButton_Click;
            // 
            // queriesButton
            // 
            queriesButton.BackColor = Color.WhiteSmoke;
            queriesButton.Cursor = Cursors.Hand;
            queriesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            queriesButton.ForeColor = Color.Peru;
            queriesButton.Location = new Point(14, 27);
            queriesButton.Name = "queriesButton";
            queriesButton.Size = new Size(115, 40);
            queriesButton.TabIndex = 6;
            queriesButton.Text = "Queries";
            queriesButton.UseVisualStyleBackColor = false;
            queriesButton.Click += queriesButton_Click;
            // 
            // leftNavigationSplitContainer
            // 
            leftNavigationSplitContainer.Location = new Point(3, 72);
            leftNavigationSplitContainer.Name = "leftNavigationSplitContainer";
            leftNavigationSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // leftNavigationSplitContainer.Panel1
            // 
            leftNavigationSplitContainer.Panel1.BackColor = Color.DarkRed;
            leftNavigationSplitContainer.Panel1.Controls.Add(stadiumsButton);
            leftNavigationSplitContainer.Panel1.Controls.Add(playersButton);
            leftNavigationSplitContainer.Panel1.Controls.Add(teamsButton);
            leftNavigationSplitContainer.Panel1.Controls.Add(competitionsButton);
            leftNavigationSplitContainer.Panel1.Controls.Add(staffButton);
            // 
            // leftNavigationSplitContainer.Panel2
            // 
            leftNavigationSplitContainer.Panel2.BackColor = Color.Peru;
            leftNavigationSplitContainer.Panel2.Controls.Add(queriesButton);
            leftNavigationSplitContainer.Size = new Size(145, 580);
            leftNavigationSplitContainer.SplitterDistance = 478;
            leftNavigationSplitContainer.SplitterWidth = 6;
            leftNavigationSplitContainer.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(987, 655);
            Controls.Add(leftNavigationSplitContainer);
            Controls.Add(topNavigationPanel);
            Controls.Add(contentPanel);
            Name = "MainForm";
            Text = "Football Manager";
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gifPictureBox).EndInit();
            topNavigationPanel.ResumeLayout(false);
            topNavigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainLogoPictureBox).EndInit();
            leftNavigationSplitContainer.Panel1.ResumeLayout(false);
            leftNavigationSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)leftNavigationSplitContainer).EndInit();
            leftNavigationSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel contentPanel;
        private Panel topNavigationPanel;
        private Button playersButton;
        private Button teamsButton;
        private Button stadiumsButton;
        private Button competitionsButton;
        private Button staffButton;
        private Button queriesButton;
        private SplitContainer leftNavigationSplitContainer;
        private Button listButton;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private PictureBox gifPictureBox;
        private Label welcomeLabel;
        private PictureBox mainLogoPictureBox;
        private Label mainLogo;
    }
}
