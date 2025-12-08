namespace FootballManager.UserControls.Stadiums
{
    partial class DeleteStadiumControl
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
            label1 = new Label();
            countryLabel = new Label();
            fullNameLabel = new Label();
            countryComboBox = new ComboBox();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // nameComboBox
            // 
            nameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            nameComboBox.FormattingEnabled = true;
            nameComboBox.Location = new Point(329, 349);
            nameComboBox.Name = "nameComboBox";
            nameComboBox.Size = new Size(200, 28);
            nameComboBox.TabIndex = 76;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(165, 65);
            label1.Name = "label1";
            label1.Size = new Size(468, 81);
            label1.TabIndex = 75;
            label1.Text = "Delete Stadium";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            countryLabel.ForeColor = Color.DarkRed;
            countryLabel.Location = new Point(228, 251);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(65, 20);
            countryLabel.TabIndex = 74;
            countryLabel.Text = "Country";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            fullNameLabel.ForeColor = Color.DarkRed;
            fullNameLabel.Location = new Point(243, 352);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(50, 20);
            fullNameLabel.TabIndex = 73;
            fullNameLabel.Text = "Name";
            // 
            // countryComboBox
            // 
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(329, 251);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(200, 28);
            countryComboBox.TabIndex = 72;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.ForeColor = Color.DarkRed;
            deleteButton.Location = new Point(329, 479);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(115, 40);
            deleteButton.TabIndex = 71;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // DeleteStadiumControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(nameComboBox);
            Controls.Add(label1);
            Controls.Add(countryLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(countryComboBox);
            Controls.Add(deleteButton);
            Name = "DeleteStadiumControl";
            Size = new Size(799, 585);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox nameComboBox;
        private Label label1;
        private Label countryLabel;
        private Label fullNameLabel;
        private ComboBox countryComboBox;
        private Button deleteButton;
    }
}
