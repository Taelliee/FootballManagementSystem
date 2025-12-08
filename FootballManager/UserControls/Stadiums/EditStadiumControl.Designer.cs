namespace FootballManager.UserControls.Stadiums
{
    partial class EditStadiumControl
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
            nameComboBox = new ComboBox();
            capacityTextBox = new TextBox();
            label3 = new Label();
            teamComboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            countryLabel = new Label();
            fullNameLabel = new Label();
            countryComboBox = new ComboBox();
            editButton = new Button();
            newNameTextBox = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // nameComboBox
            // 
            nameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            nameComboBox.FormattingEnabled = true;
            nameComboBox.Location = new Point(364, 152);
            nameComboBox.Name = "nameComboBox";
            nameComboBox.Size = new Size(200, 28);
            nameComboBox.TabIndex = 64;
            // 
            // capacityTextBox
            // 
            capacityTextBox.Location = new Point(364, 352);
            capacityTextBox.Name = "capacityTextBox";
            capacityTextBox.Size = new Size(200, 27);
            capacityTextBox.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(283, 220);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 62;
            label3.Text = "Team";
            // 
            // teamComboBox
            // 
            teamComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            teamComboBox.FormattingEnabled = true;
            teamComboBox.Location = new Point(364, 217);
            teamComboBox.Name = "teamComboBox";
            teamComboBox.Size = new Size(200, 28);
            teamComboBox.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(263, 355);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 60;
            label2.Text = "Capacity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(237, 35);
            label1.Name = "label1";
            label1.Size = new Size(398, 81);
            label1.TabIndex = 59;
            label1.Text = "Edit Stadium";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            countryLabel.ForeColor = Color.DarkRed;
            countryLabel.Location = new Point(263, 286);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(65, 20);
            countryLabel.TabIndex = 58;
            countryLabel.Text = "Country";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            fullNameLabel.ForeColor = Color.DarkRed;
            fullNameLabel.Location = new Point(278, 155);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(50, 20);
            fullNameLabel.TabIndex = 57;
            fullNameLabel.Text = "Name";
            // 
            // countryComboBox
            // 
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(364, 286);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(200, 28);
            countryComboBox.TabIndex = 56;
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            editButton.ForeColor = Color.DarkRed;
            editButton.Location = new Point(364, 495);
            editButton.Name = "editButton";
            editButton.Size = new Size(115, 40);
            editButton.TabIndex = 55;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // newNameTextBox
            // 
            newNameTextBox.Location = new Point(364, 424);
            newNameTextBox.Name = "newNameTextBox";
            newNameTextBox.Size = new Size(200, 27);
            newNameTextBox.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(243, 427);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 65;
            label4.Text = "New Name";
            // 
            // EditStadiumControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(newNameTextBox);
            Controls.Add(label4);
            Controls.Add(nameComboBox);
            Controls.Add(capacityTextBox);
            Controls.Add(label3);
            Controls.Add(teamComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(countryLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(countryComboBox);
            Controls.Add(editButton);
            Name = "EditStadiumControl";
            Size = new Size(827, 579);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox nameComboBox;
        private TextBox capacityTextBox;
        private Label label3;
        private ComboBox teamComboBox;
        private Label label2;
        private Label label1;
        private Label countryLabel;
        private Label fullNameLabel;
        private ComboBox countryComboBox;
        private Button editButton;
        private TextBox newNameTextBox;
        private Label label4;
    }
}
