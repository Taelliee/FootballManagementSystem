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
            stadiumComboBox = new ComboBox();
            label1 = new Label();
            countryLabel = new Label();
            stadiumNameLabel = new Label();
            countryComboBox = new ComboBox();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // stadiumComboBox
            // 
            stadiumComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stadiumComboBox.FormattingEnabled = true;
            stadiumComboBox.Location = new Point(329, 349);
            stadiumComboBox.Name = "stadiumComboBox";
            stadiumComboBox.Size = new Size(200, 28);
            stadiumComboBox.TabIndex = 76;
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
            countryLabel.Location = new Point(243, 251);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(65, 20);
            countryLabel.TabIndex = 74;
            countryLabel.Text = "Country";
            // 
            // stadiumNameLabel
            // 
            stadiumNameLabel.AutoSize = true;
            stadiumNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            stadiumNameLabel.ForeColor = Color.DarkRed;
            stadiumNameLabel.Location = new Point(243, 352);
            stadiumNameLabel.Name = "stadiumNameLabel";
            stadiumNameLabel.Size = new Size(65, 20);
            stadiumNameLabel.TabIndex = 73;
            stadiumNameLabel.Text = "Stadium";
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
            Controls.Add(stadiumComboBox);
            Controls.Add(label1);
            Controls.Add(countryLabel);
            Controls.Add(stadiumNameLabel);
            Controls.Add(countryComboBox);
            Controls.Add(deleteButton);
            Name = "DeleteStadiumControl";
            Size = new Size(799, 585);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox stadiumComboBox;
        private Label label1;
        private Label countryLabel;
        private Label stadiumNameLabel;
        private ComboBox countryComboBox;
        private Button deleteButton;
    }
}
