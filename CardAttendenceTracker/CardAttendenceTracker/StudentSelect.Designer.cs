namespace CardAttendenceTracker
{
    partial class StudentSelect
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentListBox = new System.Windows.Forms.ListBox();
            this.AcceptSelectButton = new System.Windows.Forms.Button();
            this.CancelSelectButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentListBox
            // 
            this.StudentListBox.FormattingEnabled = true;
            this.StudentListBox.ItemHeight = 29;
            this.StudentListBox.Location = new System.Drawing.Point(16, 16);
            this.StudentListBox.Margin = new System.Windows.Forms.Padding(7);
            this.StudentListBox.Name = "StudentListBox";
            this.StudentListBox.Size = new System.Drawing.Size(913, 526);
            this.StudentListBox.TabIndex = 0;
            // 
            // AcceptSelectButton
            // 
            this.AcceptSelectButton.Location = new System.Drawing.Point(565, 556);
            this.AcceptSelectButton.Margin = new System.Windows.Forms.Padding(7);
            this.AcceptSelectButton.Name = "AcceptSelectButton";
            this.AcceptSelectButton.Size = new System.Drawing.Size(175, 51);
            this.AcceptSelectButton.TabIndex = 7;
            this.AcceptSelectButton.Text = "Accept";
            this.AcceptSelectButton.UseVisualStyleBackColor = true;
            this.AcceptSelectButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CancelSelectButton
            // 
            this.CancelSelectButton.Location = new System.Drawing.Point(754, 556);
            this.CancelSelectButton.Margin = new System.Windows.Forms.Padding(7);
            this.CancelSelectButton.Name = "CancelSelectButton";
            this.CancelSelectButton.Size = new System.Drawing.Size(175, 51);
            this.CancelSelectButton.TabIndex = 8;
            this.CancelSelectButton.Text = "Cancel";
            this.CancelSelectButton.UseVisualStyleBackColor = true;
            this.CancelSelectButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(16, 556);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(180, 51);
            this.AddStudentButton.TabIndex = 9;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // StudentSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 615);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.CancelSelectButton);
            this.Controls.Add(this.AcceptSelectButton);
            this.Controls.Add(this.StudentListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "StudentSelect";
            this.Text = "Student Select";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StudentListBox;
        private System.Windows.Forms.Button AcceptSelectButton;
        private System.Windows.Forms.Button CancelSelectButton;
        private System.Windows.Forms.Button AddStudentButton;
    }
}