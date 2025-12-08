namespace FootballManager.UserControls.Teams
{
    partial class EditTeamControl
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
            label2 = new Label();
            label1 = new Label();
            countryLabel = new Label();
            teamLabel = new Label();
            teamComboBox = new ComboBox();
            countryComboBox = new ComboBox();
            editButton = new Button();
            uploadButton = new Button();
            badgePictureBox = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            nameTextBox = new TextBox();
            coachComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)badgePictureBox).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(236, 257);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 41;
            label2.Text = "Head Coach";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(271, 25);
            label1.Name = "label1";
            label1.Size = new Size(318, 81);
            label1.TabIndex = 39;
            label1.Text = "Edit Team";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            countryLabel.ForeColor = Color.DarkRed;
            countryLabel.Location = new Point(262, 140);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(65, 20);
            countryLabel.TabIndex = 38;
            countryLabel.Text = "Country";
            // 
            // teamLabel
            // 
            teamLabel.AutoSize = true;
            teamLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            teamLabel.ForeColor = Color.DarkRed;
            teamLabel.Location = new Point(277, 200);
            teamLabel.Name = "teamLabel";
            teamLabel.Size = new Size(45, 20);
            teamLabel.TabIndex = 37;
            teamLabel.Text = "Team";
            // 
            // teamComboBox
            // 
            teamComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            teamComboBox.FormattingEnabled = true;
            teamComboBox.Location = new Point(363, 197);
            teamComboBox.Name = "teamComboBox";
            teamComboBox.Size = new Size(200, 28);
            teamComboBox.TabIndex = 36;
            // 
            // countryComboBox
            // 
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(363, 137);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(200, 28);
            countryComboBox.TabIndex = 35;
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            editButton.ForeColor = Color.DarkRed;
            editButton.Location = new Point(353, 491);
            editButton.Name = "editButton";
            editButton.Size = new Size(115, 40);
            editButton.TabIndex = 34;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // uploadButton
            // 
            uploadButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            uploadButton.ForeColor = Color.DarkRed;
            uploadButton.Location = new Point(511, 395);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(84, 40);
            uploadButton.TabIndex = 54;
            uploadButton.Text = "Upload";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadButton_Click;
            // 
            // badgePictureBox
            // 
            badgePictureBox.BorderStyle = BorderStyle.FixedSingle;
            badgePictureBox.Location = new Point(363, 382);
            badgePictureBox.Name = "badgePictureBox";
            badgePictureBox.Size = new Size(115, 64);
            badgePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            badgePictureBox.TabIndex = 53;
            badgePictureBox.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(233, 405);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 52;
            label4.Text = "Team Badge";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(200, 324);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 43;
            label3.Text = "New Team name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(363, 321);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 27);
            nameTextBox.TabIndex = 42;
            // 
            // coachComboBox
            // 
            coachComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            coachComboBox.FormattingEnabled = true;
            coachComboBox.Location = new Point(363, 257);
            coachComboBox.Name = "coachComboBox";
            coachComboBox.Size = new Size(200, 28);
            coachComboBox.TabIndex = 55;
            // 
            // EditTeamControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(coachComboBox);
            Controls.Add(uploadButton);
            Controls.Add(badgePictureBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(countryLabel);
            Controls.Add(teamLabel);
            Controls.Add(teamComboBox);
            Controls.Add(countryComboBox);
            Controls.Add(editButton);
            Name = "EditTeamControl";
            Size = new Size(845, 605);
            ((System.ComponentModel.ISupportInitialize)badgePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label countryLabel;
        private Label teamLabel;
        private ComboBox teamComboBox;
        private ComboBox countryComboBox;
        private Button editButton;
        private Button uploadButton;
        private PictureBox badgePictureBox;
        private Label label4;
        private Label label3;
        private TextBox nameTextBox;
        private ComboBox coachComboBox;
    }
}
