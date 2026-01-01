namespace FootballManager.UserControls.Staff
{
    partial class DeleteStaffControl
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
            fullNameLabel = new Label();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // nameComboBox
            // 
            nameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            nameComboBox.FormattingEnabled = true;
            nameComboBox.Location = new Point(344, 293);
            nameComboBox.Name = "nameComboBox";
            nameComboBox.Size = new Size(275, 28);
            nameComboBox.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(251, 92);
            label1.Name = "label1";
            label1.Size = new Size(368, 81);
            label1.TabIndex = 52;
            label1.Text = "Delete Staff";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            fullNameLabel.ForeColor = Color.DarkRed;
            fullNameLabel.Location = new Point(258, 296);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(50, 20);
            fullNameLabel.TabIndex = 51;
            fullNameLabel.Text = "Name";
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.ForeColor = Color.DarkRed;
            deleteButton.Location = new Point(364, 473);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(115, 40);
            deleteButton.TabIndex = 50;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // DeleteStaffControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(nameComboBox);
            Controls.Add(label1);
            Controls.Add(fullNameLabel);
            Controls.Add(deleteButton);
            Name = "DeleteStaffControl";
            Size = new Size(870, 605);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox nameComboBox;
        private Label label1;
        private Label fullNameLabel;
        private Button deleteButton;
    }
}
