namespace FootballManager.UserControls.Staff
{
    partial class AddStaffControl
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
            positionComboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            countryLabel = new Label();
            fullNameLabel = new Label();
            countryComboBox = new ComboBox();
            nameTextBox = new TextBox();
            addButton = new Button();
            SuspendLayout();
            // 
            // positionComboBox
            // 
            positionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            positionComboBox.FormattingEnabled = true;
            positionComboBox.Location = new Point(373, 382);
            positionComboBox.Name = "positionComboBox";
            positionComboBox.Size = new Size(200, 28);
            positionComboBox.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(274, 385);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 39;
            label2.Text = "Position";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(287, 64);
            label1.Name = "label1";
            label1.Size = new Size(302, 81);
            label1.TabIndex = 38;
            label1.Text = "Add Staff";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            countryLabel.ForeColor = Color.DarkRed;
            countryLabel.Location = new Point(272, 304);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(65, 20);
            countryLabel.TabIndex = 37;
            countryLabel.Text = "Country";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            fullNameLabel.ForeColor = Color.DarkRed;
            fullNameLabel.Location = new Point(287, 232);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(50, 20);
            fullNameLabel.TabIndex = 36;
            fullNameLabel.Text = "Name";
            // 
            // countryComboBox
            // 
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(373, 301);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(200, 28);
            countryComboBox.TabIndex = 35;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(373, 229);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 27);
            nameTextBox.TabIndex = 34;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.ForeColor = Color.DarkRed;
            addButton.Location = new Point(373, 501);
            addButton.Name = "addButton";
            addButton.Size = new Size(115, 40);
            addButton.TabIndex = 33;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // AddStaffControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(positionComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(countryLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(countryComboBox);
            Controls.Add(nameTextBox);
            Controls.Add(addButton);
            Name = "AddStaffControl";
            Size = new Size(860, 605);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox positionComboBox;
        private Label label2;
        private Label label1;
        private Label countryLabel;
        private Label fullNameLabel;
        private ComboBox countryComboBox;
        private TextBox nameTextBox;
        private Button addButton;
    }
}
