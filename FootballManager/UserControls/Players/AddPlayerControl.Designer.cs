namespace FootballManager
{
    partial class AddPlayerControl
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
            fullNameTextBox = new TextBox();
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)badgePictureBox).BeginInit();
            SuspendLayout();
            // 
            // uploadButton
            // 
            uploadButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            uploadButton.ForeColor = Color.DarkRed;
            uploadButton.Location = new Point(499, 258);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(84, 40);
            uploadButton.TabIndex = 29;
            uploadButton.Text = "Upload";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadButton_Click;
            // 
            // badgePictureBox
            // 
            badgePictureBox.BorderStyle = BorderStyle.FixedSingle;
            badgePictureBox.Location = new Point(351, 245);
            badgePictureBox.Name = "badgePictureBox";
            badgePictureBox.Size = new Size(115, 64);
            badgePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            badgePictureBox.TabIndex = 28;
            badgePictureBox.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(221, 268);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 27;
            label3.Text = "Team Badge";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(247, 454);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 26;
            label2.Text = "Position";
            // 
            // playerPositionComboBox
            // 
            playerPositionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            playerPositionComboBox.FormattingEnabled = true;
            playerPositionComboBox.Location = new Point(351, 451);
            playerPositionComboBox.Name = "playerPositionComboBox";
            playerPositionComboBox.Size = new Size(150, 28);
            playerPositionComboBox.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(245, 17);
            label1.Name = "label1";
            label1.Size = new Size(345, 81);
            label1.TabIndex = 24;
            label1.Text = "Add Player";
            // 
            // shirtNumberLabel
            // 
            shirtNumberLabel.AutoSize = true;
            shirtNumberLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            shirtNumberLabel.ForeColor = Color.DarkRed;
            shirtNumberLabel.Location = new Point(250, 394);
            shirtNumberLabel.Name = "shirtNumberLabel";
            shirtNumberLabel.Size = new Size(62, 20);
            shirtNumberLabel.TabIndex = 23;
            shirtNumberLabel.Text = "Shirt №";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            countryLabel.ForeColor = Color.DarkRed;
            countryLabel.Location = new Point(245, 339);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(65, 20);
            countryLabel.TabIndex = 22;
            countryLabel.Text = "Country";
            // 
            // teamLabel
            // 
            teamLabel.AutoSize = true;
            teamLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            teamLabel.ForeColor = Color.DarkRed;
            teamLabel.Location = new Point(265, 195);
            teamLabel.Name = "teamLabel";
            teamLabel.Size = new Size(45, 20);
            teamLabel.TabIndex = 21;
            teamLabel.Text = "Team";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            fullNameLabel.ForeColor = Color.DarkRed;
            fullNameLabel.Location = new Point(234, 137);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(79, 20);
            fullNameLabel.TabIndex = 20;
            fullNameLabel.Text = "Full Name";
            // 
            // teamComboBox
            // 
            teamComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            teamComboBox.FormattingEnabled = true;
            teamComboBox.Location = new Point(351, 192);
            teamComboBox.Name = "teamComboBox";
            teamComboBox.Size = new Size(200, 28);
            teamComboBox.TabIndex = 19;
            // 
            // countryComboBox
            // 
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(351, 336);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(183, 28);
            countryComboBox.TabIndex = 18;
            // 
            // shirtNumberTextBox
            // 
            shirtNumberTextBox.Location = new Point(351, 391);
            shirtNumberTextBox.Name = "shirtNumberTextBox";
            shirtNumberTextBox.Size = new Size(100, 27);
            shirtNumberTextBox.TabIndex = 17;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(351, 135);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(247, 27);
            fullNameTextBox.TabIndex = 16;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.ForeColor = Color.DarkRed;
            addButton.Location = new Point(351, 519);
            addButton.Name = "addButton";
            addButton.Size = new Size(115, 40);
            addButton.TabIndex = 15;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // AddPlayerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
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
            Controls.Add(fullNameTextBox);
            Controls.Add(addButton);
            Name = "AddPlayerControl";
            Size = new Size(830, 591);
            ((System.ComponentModel.ISupportInitialize)badgePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private TextBox fullNameTextBox;
        private Button addButton;
    }
}
