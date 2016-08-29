namespace CardAttendenceTracker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ImportDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImportButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.CardSerialTextBox = new System.Windows.Forms.TextBox();
            this.AcceptSwipeButton = new System.Windows.Forms.Button();
            this.LateCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExportDialog = new System.Windows.Forms.SaveFileDialog();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ActionGroupBox = new System.Windows.Forms.GroupBox();
            this.SwipeGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ActionGroupBox.SuspendLayout();
            this.SwipeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportDialog
            // 
            this.ImportDialog.Filter = "E-learning Offline File|*.csv";
            this.ImportDialog.Title = "Import Data";
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(14, 42);
            this.ImportButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(308, 51);
            this.ImportButton.TabIndex = 0;
            this.ImportButton.Text = "Import from E-Learning";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.AutoEllipsis = true;
            this.LoadButton.Location = new System.Drawing.Point(14, 107);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(308, 51);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load Attendence File";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // CardSerialTextBox
            // 
            this.CardSerialTextBox.Location = new System.Drawing.Point(14, 42);
            this.CardSerialTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.CardSerialTextBox.Name = "CardSerialTextBox";
            this.CardSerialTextBox.PasswordChar = '*';
            this.CardSerialTextBox.Size = new System.Drawing.Size(1049, 35);
            this.CardSerialTextBox.TabIndex = 2;
            this.CardSerialTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CardSerialTextBox_KeyDown);
            // 
            // AcceptSwipeButton
            // 
            this.AcceptSwipeButton.Location = new System.Drawing.Point(894, 100);
            this.AcceptSwipeButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.AcceptSwipeButton.Name = "AcceptSwipeButton";
            this.AcceptSwipeButton.Size = new System.Drawing.Size(175, 51);
            this.AcceptSwipeButton.TabIndex = 3;
            this.AcceptSwipeButton.Text = "Accept";
            this.AcceptSwipeButton.UseVisualStyleBackColor = true;
            this.AcceptSwipeButton.Click += new System.EventHandler(this.AcceptSwipeButton_Click);
            // 
            // LateCheckBox
            // 
            this.LateCheckBox.AutoSize = true;
            this.LateCheckBox.Location = new System.Drawing.Point(14, 109);
            this.LateCheckBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.LateCheckBox.Name = "LateCheckBox";
            this.LateCheckBox.Size = new System.Drawing.Size(92, 33);
            this.LateCheckBox.TabIndex = 5;
            this.LateCheckBox.Text = "LATE";
            this.LateCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(14, 172);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(308, 51);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save Attendence File";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExportDialog
            // 
            this.ExportDialog.DefaultExt = "csv";
            this.ExportDialog.Filter = "E-learning Offline File|*.csv";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(14, 236);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(308, 51);
            this.ExportButton.TabIndex = 7;
            this.ExportButton.Text = "Export Summary Data";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ActionGroupBox
            // 
            this.ActionGroupBox.Controls.Add(this.ImportButton);
            this.ActionGroupBox.Controls.Add(this.ExportButton);
            this.ActionGroupBox.Controls.Add(this.LoadButton);
            this.ActionGroupBox.Controls.Add(this.SaveButton);
            this.ActionGroupBox.Location = new System.Drawing.Point(16, 16);
            this.ActionGroupBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.ActionGroupBox.Name = "ActionGroupBox";
            this.ActionGroupBox.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.ActionGroupBox.Size = new System.Drawing.Size(336, 306);
            this.ActionGroupBox.TabIndex = 8;
            this.ActionGroupBox.TabStop = false;
            this.ActionGroupBox.Text = "Actions";
            // 
            // SwipeGroupBox
            // 
            this.SwipeGroupBox.Controls.Add(this.ResultTextBox);
            this.SwipeGroupBox.Controls.Add(this.CardSerialTextBox);
            this.SwipeGroupBox.Controls.Add(this.AcceptSwipeButton);
            this.SwipeGroupBox.Controls.Add(this.LateCheckBox);
            this.SwipeGroupBox.Location = new System.Drawing.Point(366, 16);
            this.SwipeGroupBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.SwipeGroupBox.Name = "SwipeGroupBox";
            this.SwipeGroupBox.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.SwipeGroupBox.Size = new System.Drawing.Size(1090, 306);
            this.SwipeGroupBox.TabIndex = 9;
            this.SwipeGroupBox.TabStop = false;
            this.SwipeGroupBox.Text = "Card Swipe";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultTextBox.Location = new System.Drawing.Point(10, 161);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(1070, 135);
            this.ResultTextBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 358);
            this.Controls.Add(this.SwipeGroupBox);
            this.Controls.Add(this.ActionGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 400);
            this.MinimumSize = new System.Drawing.Size(1500, 400);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CometCard Attendence Tracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ActionGroupBox.ResumeLayout(false);
            this.SwipeGroupBox.ResumeLayout(false);
            this.SwipeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ImportDialog;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox CardSerialTextBox;
        private System.Windows.Forms.Button AcceptSwipeButton;
        private System.Windows.Forms.CheckBox LateCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog ExportDialog;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.GroupBox ActionGroupBox;
        private System.Windows.Forms.GroupBox SwipeGroupBox;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

