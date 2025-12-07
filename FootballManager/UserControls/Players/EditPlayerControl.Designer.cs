namespace FootballManager.UserControls.Players
{
    partial class EditPlayerControl
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
            fullNameComboBox = new ComboBox();
            uploadButton = new Button();
            badgePictureBox = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            playerPositionComboBox = new ComboBox();
            label1 = new Label();
            shirtNumberLabel = new Label();
            countryLabel = new Label();
            teamLabel = new Label();
            fullNameLabel = new Label();
            teamComboBox = new ComboBox();
            countryComboBox = new ComboBox();
            shirtNumberTextBox = new TextBox();
            editButton = new Button();
            ((System.ComponentModel.ISupportInitialize)badgePictureBox).BeginInit();
            SuspendLayout();
            // 
            // fullNameComboBox
            // 
            fullNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fullNameComboBox.FormattingEnabled = true;
            fullNameComboBox.Location = new Point(362, 137);
            fullNameComboBox.Name = "fullNameComboBox";
            fullNameComboBox.Size = new Size(232, 28);
            fullNameComboBox.TabIndex = 45;
            // 
            // uploadButton
            // 
            uploadButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            uploadButton.ForeColor = Color.DarkRed;
            uploadButton.Location = new Point(510, 261);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(84, 40);
            uploadButton.TabIndex = 44;
            uploadButton.Text = "Upload";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadButton_Click;
            // 
            // badgePictureBox
            // 
            badgePictureBox.BorderStyle = BorderStyle.FixedSingle;
            badgePictureBox.Location = new Point(362, 248);
            badgePictureBox.Name = "badgePictureBox";
            badgePictureBox.Size = new Size(115, 64);
            badgePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            badgePictureBox.TabIndex = 43;
            badgePictureBox.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(232, 271);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 42;
            label3.Text = "Team Badge";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(258, 457);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 41;
            label2.Text = "Position";
            // 
            // playerPositionComboBox
            // 
            playerPositionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            playerPositionComboBox.FormattingEnabled = true;
            playerPositionComboBox.Location = new Point(362, 454);
            playerPositionComboBox.Name = "playerPositionComboBox";
            playerPositionComboBox.Size = new Size(150, 28);
            playerPositionComboBox.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(258, 19);
            label1.Name = "label1";
            label1.Size = new Size(341, 81);
            label1.TabIndex = 39;
            label1.Text = "Edit Player";
            // 
            // shirtNumberLabel
            // 
            shirtNumberLabel.AutoSize = true;
            shirtNumberLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            shirtNumberLabel.ForeColor = Color.DarkRed;
            shirtNumberLabel.Location = new Point(261, 397);
            shirtNumberLabel.Name = "shirtNumberLabel";
            shirtNumberLabel.Size = new Size(62, 20);
            shirtNumberLabel.TabIndex = 38;
            shirtNumberLabel.Text = "Shirt №";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            countryLabel.ForeColor = Color.DarkRed;
            countryLabel.Location = new Point(256, 342);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(65, 20);
            countryLabel.TabIndex = 37;
            countryLabel.Text = "Country";
            // 
            // teamLabel
            // 
            teamLabel.AutoSize = true;
            teamLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            teamLabel.ForeColor = Color.DarkRed;
            teamLabel.Location = new Point(276, 198);
            teamLabel.Name = "teamLabel";
            teamLabel.Size = new Size(45, 20);
            teamLabel.TabIndex = 36;
            teamLabel.Text = "Team";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            fullNameLabel.ForeColor = Color.DarkRed;
            fullNameLabel.Location = new Point(245, 140);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(79, 20);
            fullNameLabel.TabIndex = 35;
            fullNameLabel.Text = "Full Name";
            // 
            // teamComboBox
            // 
            teamComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            teamComboBox.FormattingEnabled = true;
            teamComboBox.Location = new Point(362, 195);
            teamComboBox.Name = "teamComboBox";
            teamComboBox.Size = new Size(200, 28);
            teamComboBox.TabIndex = 34;
            // 
            // countryComboBox
            // 
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(362, 339);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(183, 28);
            countryComboBox.TabIndex = 33;
            // 
            // shirtNumberTextBox
            // 
            shirtNumberTextBox.Location = new Point(362, 394);
            shirtNumberTextBox.Name = "shirtNumberTextBox";
            shirtNumberTextBox.Size = new Size(100, 27);
            shirtNumberTextBox.TabIndex = 32;
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            editButton.ForeColor = Color.DarkRed;
            editButton.Location = new Point(362, 522);
            editButton.Name = "editButton";
            editButton.Size = new Size(115, 40);
            editButton.TabIndex = 31;
            editButton.Text = "Add";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // EditPlayerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(fullNameComboBox);
            Controls.Add(uploadButton);
            Controls.Add(badgePictureBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(playerPositionComboBox);
            Controls.Add(label1);
            Controls.Add(shirtNumberLabel);
            Controls.Add(countryLabel);
            Controls.Add(teamLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(teamComboBox);
            Controls.Add(countryComboBox);
            Controls.Add(shirtNumberTextBox);
            Controls.Add(editButton);
            Name = "EditPlayerControl";
            Size = new Size(830, 598);
            ((System.ComponentModel.ISupportInitialize)badgePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox fullNameComboBox;
        private Button uploadButton;
        private PictureBox badgePictureBox;
        private Label label3;
        private Label label2;
        private ComboBox playerPositionComboBox;
        private Label label1;
        private Label shirtNumberLabel;
        private Label countryLabel;
        private Label teamLabel;
        private Label fullNameLabel;
        private ComboBox teamComboBox;
        private ComboBox countryComboBox;
        private TextBox shirtNumberTextBox;
        private Button editButton;
    }
}
