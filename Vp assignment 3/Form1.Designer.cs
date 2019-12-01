namespace WindowsFormsApp1
{
    partial class Form1
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
            this.SMS = new System.Windows.Forms.Label();
            this.Cprofile = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Top3 = new System.Windows.Forms.Button();
            this.Attendance = new System.Windows.Forms.Button();
            this.ViewAttend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SMS
            // 
            this.SMS.AutoSize = true;
            this.SMS.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMS.Location = new System.Drawing.Point(195, 45);
            this.SMS.Name = "SMS";
            this.SMS.Size = new System.Drawing.Size(360, 21);
            this.SMS.TabIndex = 0;
            this.SMS.Text = "Student Management System";
            this.SMS.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cprofile
            // 
            this.Cprofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cprofile.Location = new System.Drawing.Point(87, 121);
            this.Cprofile.Name = "Cprofile";
            this.Cprofile.Size = new System.Drawing.Size(150, 84);
            this.Cprofile.TabIndex = 1;
            this.Cprofile.Text = "Create Profile";
            this.Cprofile.UseVisualStyleBackColor = true;
            this.Cprofile.Click += new System.EventHandler(this.Cprofile_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(309, 121);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(143, 84);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(519, 121);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(134, 84);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete Record";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Top3
            // 
            this.Top3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top3.Location = new System.Drawing.Point(519, 271);
            this.Top3.Name = "Top3";
            this.Top3.Size = new System.Drawing.Size(141, 83);
            this.Top3.TabIndex = 4;
            this.Top3.Text = "Top 3 Student";
            this.Top3.UseVisualStyleBackColor = true;
            this.Top3.Click += new System.EventHandler(this.Top3_Click);
            // 
            // Attendance
            // 
            this.Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance.Location = new System.Drawing.Point(87, 268);
            this.Attendance.Name = "Attendance";
            this.Attendance.Size = new System.Drawing.Size(143, 83);
            this.Attendance.TabIndex = 5;
            this.Attendance.Text = "Mark Atendance";
            this.Attendance.UseVisualStyleBackColor = true;
            this.Attendance.Click += new System.EventHandler(this.Attendance_Click);
            // 
            // ViewAttend
            // 
            this.ViewAttend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAttend.Location = new System.Drawing.Point(309, 273);
            this.ViewAttend.Name = "ViewAttend";
            this.ViewAttend.Size = new System.Drawing.Size(128, 78);
            this.ViewAttend.TabIndex = 6;
            this.ViewAttend.Text = "View Attendance";
            this.ViewAttend.UseVisualStyleBackColor = true;
            this.ViewAttend.Click += new System.EventHandler(this.ViewAttend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewAttend);
            this.Controls.Add(this.Attendance);
            this.Controls.Add(this.Top3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Cprofile);
            this.Controls.Add(this.SMS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label SMS;
        private System.Windows.Forms.Button Cprofile;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Top3;
        private System.Windows.Forms.Button Attendance;
        protected internal System.Windows.Forms.Button ViewAttend;
    }
}

