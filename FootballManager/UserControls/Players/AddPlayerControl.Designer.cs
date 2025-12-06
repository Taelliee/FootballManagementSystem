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
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(213, 427);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 23;
            label2.Text = "Position";
            // 
            // playerPositionComboBox
            // 
            playerPositionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            playerPositionComboBox.FormattingEnabled = true;
            playerPositionComboBox.Location = new Point(317, 424);
            playerPositionComboBox.Name = "playerPositionComboBox";
            playerPositionComboBox.Size = new Size(150, 28);
            playerPositionComboBox.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(240, 37);
            label1.Name = "label1";
            label1.Size = new Size(345, 81);
            label1.TabIndex = 21;
            label1.Text = "Add Player";
            // 
            // shirtNumberLabel
            // 
            shirtNumberLabel.AutoSize = true;
            shirtNumberLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            shirtNumberLabel.ForeColor = Color.DarkRed;
            shirtNumberLabel.Location = new Point(216, 360);
            shirtNumberLabel.Name = "shirtNumberLabel";
            shirtNumberLabel.Size = new Size(62, 20);
            shirtNumberLabel.TabIndex = 20;
            shirtNumberLabel.Text = "Shirt №";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            countryLabel.ForeColor = Color.DarkRed;
            countryLabel.Location = new Point(216, 295);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(65, 20);
            countryLabel.TabIndex = 19;
            countryLabel.Text = "Country";
            // 
            // teamLabel
            // 
            teamLabel.AutoSize = true;
            teamLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            teamLabel.ForeColor = Color.DarkRed;
            teamLabel.Location = new Point(231, 230);
            teamLabel.Name = "teamLabel";
            teamLabel.Size = new Size(45, 20);
            teamLabel.TabIndex = 18;
            teamLabel.Text = "Team";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            fullNameLabel.ForeColor = Color.DarkRed;
            fullNameLabel.Location = new Point(200, 169);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(79, 20);
            fullNameLabel.TabIndex = 17;
            fullNameLabel.Text = "Full Name";
            // 
            // teamComboBox
            // 
            teamComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            teamComboBox.FormattingEnabled = true;
            teamComboBox.Location = new Point(317, 227);
            teamComboBox.Name = "teamComboBox";
            teamComboBox.Size = new Size(200, 28);
            teamComboBox.TabIndex = 16;
            // 
            // countryComboBox
            // 
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(317, 292);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(200, 28);
            countryComboBox.TabIndex = 15;
            // 
            // shirtNumberTextBox
            // 
            shirtNumberTextBox.Location = new Point(317, 357);
            shirtNumberTextBox.Name = "shirtNumberTextBox";
            shirtNumberTextBox.Size = new Size(100, 27);
            shirtNumberTextBox.TabIndex = 14;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(317, 166);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(314, 27);
            fullNameTextBox.TabIndex = 13;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.ForeColor = Color.DarkRed;
            addButton.Location = new Point(317, 504);
            addButton.Name = "addButton";
            addButton.Size = new Size(115, 40);
            addButton.TabIndex = 12;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // AddPlayerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
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
            Size = new Size(830, 580);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
