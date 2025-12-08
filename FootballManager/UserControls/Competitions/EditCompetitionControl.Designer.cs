namespace FootballManager.UserControls.Competitions
{
    partial class EditCompetitionControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            matchSelectorComboBox = new ComboBox();
            stadiumComboBox = new ComboBox();
            playerComboBox = new ComboBox();
            staffComboBox = new ComboBox();
            goalsScoredTextBox = new TextBox();
            countryComboBox = new ComboBox();
            matchDateTimePicker = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            countryLabel = new Label();
            teamLabel = new Label();
            editButton = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(278, 191);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 68;
            label6.Text = "Competition";
            // 
            // matchSelectorComboBox
            // 
            matchSelectorComboBox.FormattingEnabled = true;
            matchSelectorComboBox.Location = new Point(404, 188);
            matchSelectorComboBox.Name = "matchSelectorComboBox";
            matchSelectorComboBox.Size = new Size(359, 28);
            matchSelectorComboBox.TabIndex = 67;
            // 
            // stadiumComboBox
            // 
            stadiumComboBox.FormattingEnabled = true;
            stadiumComboBox.Location = new Point(583, 336);
            stadiumComboBox.Name = "stadiumComboBox";
            stadiumComboBox.Size = new Size(180, 28);
            stadiumComboBox.TabIndex = 66;
            // 
            // playerComboBox
            // 
            playerComboBox.FormattingEnabled = true;
            playerComboBox.Location = new Point(223, 339);
            playerComboBox.Name = "playerComboBox";
            playerComboBox.Size = new Size(182, 28);
            playerComboBox.TabIndex = 65;
            // 
            // staffComboBox
            // 
            staffComboBox.FormattingEnabled = true;
            staffComboBox.Location = new Point(224, 266);
            staffComboBox.Name = "staffComboBox";
            staffComboBox.Size = new Size(181, 28);
            staffComboBox.TabIndex = 64;
            // 
            // goalsScoredTextBox
            // 
            goalsScoredTextBox.Location = new Point(583, 411);
            goalsScoredTextBox.Name = "goalsScoredTextBox";
            goalsScoredTextBox.Size = new Size(180, 27);
            goalsScoredTextBox.TabIndex = 63;
            // 
            // countryComboBox
            // 
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(583, 263);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(180, 28);
            countryComboBox.TabIndex = 62;
            // 
            // matchDateTimePicker
            // 
            matchDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            matchDateTimePicker.Format = DateTimePickerFormat.Custom;
            matchDateTimePicker.Location = new Point(223, 413);
            matchDateTimePicker.Name = "matchDateTimePicker";
            matchDateTimePicker.Size = new Size(182, 27);
            matchDateTimePicker.TabIndex = 61;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(461, 413);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 60;
            label5.Text = "Goals scored";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(491, 339);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 59;
            label4.Text = "Stadium";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(491, 266);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 58;
            label3.Text = "Country";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(91, 418);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 57;
            label2.Text = "Date of match";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(214, 61);
            label1.Name = "label1";
            label1.Size = new Size(511, 81);
            label1.TabIndex = 56;
            label1.Text = "Edit Competition";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            countryLabel.ForeColor = Color.DarkRed;
            countryLabel.Location = new Point(150, 269);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(40, 20);
            countryLabel.TabIndex = 55;
            countryLabel.Text = "Staff";
            // 
            // teamLabel
            // 
            teamLabel.AutoSize = true;
            teamLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            teamLabel.ForeColor = Color.DarkRed;
            teamLabel.Location = new Point(138, 342);
            teamLabel.Name = "teamLabel";
            teamLabel.Size = new Size(52, 20);
            teamLabel.TabIndex = 54;
            teamLabel.Text = "Player";
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            editButton.ForeColor = Color.DarkRed;
            editButton.Location = new Point(381, 503);
            editButton.Name = "editButton";
            editButton.Size = new Size(115, 40);
            editButton.TabIndex = 53;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // EditCompetitionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(label6);
            Controls.Add(matchSelectorComboBox);
            Controls.Add(stadiumComboBox);
            Controls.Add(playerComboBox);
            Controls.Add(staffComboBox);
            Controls.Add(goalsScoredTextBox);
            Controls.Add(countryComboBox);
            Controls.Add(matchDateTimePicker);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(countryLabel);
            Controls.Add(teamLabel);
            Controls.Add(editButton);
            Name = "EditCompetitionControl";
            Size = new Size(855, 605);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ComboBox matchSelectorComboBox;
        private ComboBox stadiumComboBox;
        private ComboBox playerComboBox;
        private ComboBox staffComboBox;
        private TextBox goalsScoredTextBox;
        private ComboBox countryComboBox;
        private DateTimePicker matchDateTimePicker;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label countryLabel;
        private Label teamLabel;
        private Button editButton;
    }
}
