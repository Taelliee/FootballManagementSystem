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
            label1 = new Label();
            editButton = new Button();
            label4 = new Label();
            newNameTextBox = new TextBox();
            fullNameComboBox = new ComboBox();
            uploadButton = new Button();
            badgePictureBox = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            playerPositionComboBox = new ComboBox();
            shirtNumberLabel = new Label();
            countryLabel = new Label();
            teamLabel = new Label();
            fullNameLabel = new Label();
            teamComboBox = new ComboBox();
            countryComboBox = new ComboBox();
            shirtNumberTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)badgePictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(264, 42);
            label1.Name = "label1";
            label1.Size = new Size(341, 81);
            label1.TabIndex = 39;
            label1.Text = "Edit Player";
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            editButton.ForeColor = Color.DarkRed;
            editButton.Location = new Point(357, 488);
            editButton.Name = "editButton";
            editButton.Size = new Size(115, 40);
            editButton.TabIndex = 31;
            editButton.Text = "Add";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(85, 241);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 54;
            label4.Text = "New Name";
            // 
            // newNameTextBox
            // 
            newNameTextBox.Location = new Point(209, 238);
            newNameTextBox.Name = "newNameTextBox";
            newNameTextBox.Size = new Size(232, 27);
            newNameTextBox.TabIndex = 53;
            // 
            // fullNameComboBox
            // 
            fullNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fullNameComboBox.FormattingEnabled = true;
            fullNameComboBox.Location = new Point(209, 186);
            fullNameComboBox.Name = "fullNameComboBox";
            fullNameComboBox.Size = new Size(232, 28);
            fullNameComboBox.TabIndex = 52;
            // 
            // uploadButton
            // 
            uploadButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            uploadButton.ForeColor = Color.DarkRed;
            uploadButton.Location = new Point(357, 362);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(84, 40);
            uploadButton.TabIndex = 51;
            uploadButton.Text = "Upload";
            uploadButton.UseVisualStyleBackColor = true;
            // 
            // badgePictureBox
            // 
            badgePictureBox.BorderStyle = BorderStyle.FixedSingle;
            badgePictureBox.Location = new Point(209, 349);
            badgePictureBox.Name = "badgePictureBox";
            badgePictureBox.Size = new Size(115, 64);
            badgePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            badgePictureBox.TabIndex = 50;
            badgePictureBox.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(79, 372);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 49;
            label3.Text = "Team Badge";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(499, 342);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 48;
            label2.Text = "Position";
            // 
            // playerPositionComboBox
            // 
            playerPositionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            playerPositionComboBox.FormattingEnabled = true;
            playerPositionComboBox.Location = new Point(601, 339);
            playerPositionComboBox.Name = "playerPositionComboBox";
            playerPositionComboBox.Size = new Size(150, 28);
            playerPositionComboBox.TabIndex = 47;
            // 
            // shirtNumberLabel
            // 
            shirtNumberLabel.AutoSize = true;
            shirtNumberLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            shirtNumberLabel.ForeColor = Color.DarkRed;
            shirtNumberLabel.Location = new Point(500, 282);
            shirtNumberLabel.Name = "shirtNumberLabel";
            shirtNumberLabel.Size = new Size(62, 20);
            shirtNumberLabel.TabIndex = 46;
            shirtNumberLabel.Text = "Shirt №";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            countryLabel.ForeColor = Color.DarkRed;
            countryLabel.Location = new Point(495, 222);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(65, 20);
            countryLabel.TabIndex = 45;
            countryLabel.Text = "Country";
            // 
            // teamLabel
            // 
            teamLabel.AutoSize = true;
            teamLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            teamLabel.ForeColor = Color.DarkRed;
            teamLabel.Location = new Point(123, 299);
            teamLabel.Name = "teamLabel";
            teamLabel.Size = new Size(45, 20);
            teamLabel.TabIndex = 44;
            teamLabel.Text = "Team";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            fullNameLabel.ForeColor = Color.DarkRed;
            fullNameLabel.Location = new Point(92, 189);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(79, 20);
            fullNameLabel.TabIndex = 43;
            fullNameLabel.Text = "Full Name";
            // 
            // teamComboBox
            // 
            teamComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            teamComboBox.FormattingEnabled = true;
            teamComboBox.Location = new Point(209, 296);
            teamComboBox.Name = "teamComboBox";
            teamComboBox.Size = new Size(200, 28);
            teamComboBox.TabIndex = 42;
            // 
            // countryComboBox
            // 
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(601, 219);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(150, 28);
            countryComboBox.TabIndex = 41;
            // 
            // shirtNumberTextBox
            // 
            shirtNumberTextBox.Location = new Point(601, 279);
            shirtNumberTextBox.Name = "shirtNumberTextBox";
            shirtNumberTextBox.Size = new Size(100, 27);
            shirtNumberTextBox.TabIndex = 40;
            // 
            // EditPlayerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(label4);
            Controls.Add(newNameTextBox);
            Controls.Add(fullNameComboBox);
            Controls.Add(uploadButton);
            Controls.Add(badgePictureBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(playerPositionComboBox);
            Controls.Add(shirtNumberLabel);
            Controls.Add(countryLabel);
            Controls.Add(teamLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(teamComboBox);
            Controls.Add(countryComboBox);
            Controls.Add(shirtNumberTextBox);
            Controls.Add(label1);
            Controls.Add(editButton);
            Name = "EditPlayerControl";
            Size = new Size(830, 598);
            ((System.ComponentModel.ISupportInitialize)badgePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button editButton;
        private Label label4;
        private TextBox newNameTextBox;
        private ComboBox fullNameComboBox;
        private Button uploadButton;
        private PictureBox badgePictureBox;
        private Label label3;
        private Label label2;
        private ComboBox playerPositionComboBox;
        private Label shirtNumberLabel;
        private Label countryLabel;
        private Label teamLabel;
        private Label fullNameLabel;
        private ComboBox teamComboBox;
        private ComboBox countryComboBox;
        private TextBox shirtNumberTextBox;
    }
}
