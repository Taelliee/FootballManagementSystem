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
            topNavigationPanel = new Panel();
            listButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            playersButton = new Button();
            teamsButton = new Button();
            competitionsButton = new Button();
            staffButton = new Button();
            countriesButton = new Button();
            stadiumsButton = new Button();
            queriesButton = new Button();
            leftNavigationSplitContainer = new SplitContainer();
            topNavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)leftNavigationSplitContainer).BeginInit();
            leftNavigationSplitContainer.Panel1.SuspendLayout();
            leftNavigationSplitContainer.Panel2.SuspendLayout();
            leftNavigationSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Location = new Point(154, 72);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(830, 580);
            contentPanel.TabIndex = 0;
            // 
            // topNavigationPanel
            // 
            topNavigationPanel.BackColor = Color.DarkSlateGray;
            topNavigationPanel.Controls.Add(listButton);
            topNavigationPanel.Controls.Add(deleteButton);
            topNavigationPanel.Controls.Add(editButton);
            topNavigationPanel.Controls.Add(addButton);
            topNavigationPanel.Location = new Point(3, 2);
            topNavigationPanel.Name = "topNavigationPanel";
            topNavigationPanel.Size = new Size(981, 64);
            topNavigationPanel.TabIndex = 1;
            // 
            // listButton
            // 
            listButton.BackColor = Color.WhiteSmoke;
            listButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            listButton.ForeColor = Color.DarkSlateGray;
            listButton.Location = new Point(656, 12);
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
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteButton.ForeColor = Color.DarkSlateGray;
            deleteButton.Location = new Point(511, 12);
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
            editButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            editButton.ForeColor = Color.DarkSlateGray;
            editButton.Location = new Point(359, 12);
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
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addButton.ForeColor = Color.DarkSlateGray;
            addButton.Location = new Point(213, 12);
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
            playersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            playersButton.ForeColor = Color.DarkRed;
            playersButton.Location = new Point(15, 36);
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
            teamsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            teamsButton.ForeColor = Color.DarkRed;
            teamsButton.Location = new Point(15, 110);
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
            competitionsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            competitionsButton.ForeColor = Color.DarkRed;
            competitionsButton.Location = new Point(16, 257);
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
            staffButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            staffButton.ForeColor = Color.DarkRed;
            staffButton.Location = new Point(15, 184);
            staffButton.Name = "staffButton";
            staffButton.Size = new Size(115, 40);
            staffButton.TabIndex = 2;
            staffButton.Text = "Staff";
            staffButton.UseVisualStyleBackColor = false;
            staffButton.Click += staffButton_Click;
            // 
            // countriesButton
            // 
            countriesButton.Anchor = AnchorStyles.None;
            countriesButton.BackColor = Color.WhiteSmoke;
            countriesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            countriesButton.ForeColor = Color.DarkRed;
            countriesButton.Location = new Point(15, 401);
            countriesButton.Name = "countriesButton";
            countriesButton.Size = new Size(115, 40);
            countriesButton.TabIndex = 5;
            countriesButton.Text = "Countries";
            countriesButton.UseVisualStyleBackColor = false;
            countriesButton.Click += countriesButton_Click;
            // 
            // stadiumsButton
            // 
            stadiumsButton.Anchor = AnchorStyles.None;
            stadiumsButton.BackColor = Color.WhiteSmoke;
            stadiumsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            stadiumsButton.ForeColor = Color.DarkRed;
            stadiumsButton.Location = new Point(15, 327);
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
            leftNavigationSplitContainer.Panel1.Controls.Add(countriesButton);
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
            topNavigationPanel.ResumeLayout(false);
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
        private Button countriesButton;
        private Button stadiumsButton;
        private Button competitionsButton;
        private Button staffButton;
        private Button queriesButton;
        private SplitContainer leftNavigationSplitContainer;
        private Button listButton;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
    }
}
