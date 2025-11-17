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
            shirtNumberLabel = new Label();
            countryLabel = new Label();
            teamLabel = new Label();
            fullNameLabel = new Label();
            teamComboBox = new ComboBox();
            countryComboBox = new ComboBox();
            shirtNumberTextBox = new TextBox();
            fullNameTextBox = new TextBox();
            editButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(242, 57);
            label1.Name = "label1";
            label1.Size = new Size(341, 81);
            label1.TabIndex = 19;
            label1.Text = "Edit Player";
            // 
            // shirtNumberLabel
            // 
            shirtNumberLabel.AutoSize = true;
            shirtNumberLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            shirtNumberLabel.ForeColor = Color.DarkRed;
            shirtNumberLabel.Location = new Point(242, 387);
            shirtNumberLabel.Name = "shirtNumberLabel";
            shirtNumberLabel.Size = new Size(62, 20);
            shirtNumberLabel.TabIndex = 18;
            shirtNumberLabel.Text = "Shirt №";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            countryLabel.ForeColor = Color.DarkRed;
            countryLabel.Location = new Point(242, 322);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(65, 20);
            countryLabel.TabIndex = 17;
            countryLabel.Text = "Country";
            // 
            // teamLabel
            // 
            teamLabel.AutoSize = true;
            teamLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            teamLabel.ForeColor = Color.DarkRed;
            teamLabel.Location = new Point(257, 257);
            teamLabel.Name = "teamLabel";
            teamLabel.Size = new Size(45, 20);
            teamLabel.TabIndex = 16;
            teamLabel.Text = "Team";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            fullNameLabel.ForeColor = Color.DarkRed;
            fullNameLabel.Location = new Point(226, 196);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(79, 20);
            fullNameLabel.TabIndex = 15;
            fullNameLabel.Text = "Full Name";
            // 
            // teamComboBox
            // 
            teamComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            teamComboBox.FormattingEnabled = true;
            teamComboBox.Location = new Point(343, 254);
            teamComboBox.Name = "teamComboBox";
            teamComboBox.Size = new Size(200, 28);
            teamComboBox.TabIndex = 14;
            // 
            // countryComboBox
            // 
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(343, 319);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(200, 28);
            countryComboBox.TabIndex = 13;
            // 
            // shirtNumberTextBox
            // 
            shirtNumberTextBox.Location = new Point(343, 384);
            shirtNumberTextBox.Name = "shirtNumberTextBox";
            shirtNumberTextBox.Size = new Size(125, 27);
            shirtNumberTextBox.TabIndex = 12;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(343, 193);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(314, 27);
            fullNameTextBox.TabIndex = 11;
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            editButton.ForeColor = Color.DarkRed;
            editButton.Location = new Point(327, 472);
            editButton.Name = "editButton";
            editButton.Size = new Size(115, 40);
            editButton.TabIndex = 10;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // EditPlayerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(label1);
            Controls.Add(shirtNumberLabel);
            Controls.Add(countryLabel);
            Controls.Add(teamLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(teamComboBox);
            Controls.Add(countryComboBox);
            Controls.Add(shirtNumberTextBox);
            Controls.Add(fullNameTextBox);
            Controls.Add(editButton);
            Name = "EditPlayerControl";
            Size = new Size(830, 580);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label shirtNumberLabel;
        private Label countryLabel;
        private Label teamLabel;
        private Label fullNameLabel;
        private ComboBox teamComboBox;
        private ComboBox countryComboBox;
        private TextBox shirtNumberTextBox;
        private TextBox fullNameTextBox;
        private Button editButton;
    }
}
