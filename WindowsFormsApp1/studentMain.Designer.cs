﻿namespace WindowsFormsApp1
{
    partial class studentMain
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
            this.sst = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddCourse = new System.Windows.Forms.Button();
            this.RemoveCorse = new System.Windows.Forms.Button();
            this.ViewGreadsbtn = new System.Windows.Forms.Button();
            this.Exams = new System.Windows.Forms.Button();
            this.viewMessagesBTN = new System.Windows.Forms.Button();
            this.sendMessagesBTN = new System.Windows.Forms.Button();
            this.SendRequestBTN = new System.Windows.Forms.Button();
            this.viewRequestsBTN = new System.Windows.Forms.Button();
            this.studentname_lbl = new System.Windows.Forms.Label();
            this.uperpanel = new System.Windows.Forms.Panel();
            this.date_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sst
            // 
            this.sst.Location = new System.Drawing.Point(26, 119);
            this.sst.Margin = new System.Windows.Forms.Padding(2);
            this.sst.Name = "sst";
            this.sst.Size = new System.Drawing.Size(75, 39);
            this.sst.TabIndex = 0;
            this.sst.Text = "Schedule";
            this.sst.UseVisualStyleBackColor = true;
            this.sst.Click += new System.EventHandler(this.sst_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Display", 10.2F);
            this.button1.Location = new System.Drawing.Point(476, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 51;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCourse
            // 
            this.AddCourse.Location = new System.Drawing.Point(136, 119);
            this.AddCourse.Margin = new System.Windows.Forms.Padding(2);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(75, 39);
            this.AddCourse.TabIndex = 53;
            this.AddCourse.Text = "Add Course";
            this.AddCourse.UseVisualStyleBackColor = true;
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // RemoveCorse
            // 
            this.RemoveCorse.Location = new System.Drawing.Point(250, 119);
            this.RemoveCorse.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveCorse.Name = "RemoveCorse";
            this.RemoveCorse.Size = new System.Drawing.Size(75, 39);
            this.RemoveCorse.TabIndex = 54;
            this.RemoveCorse.Text = "Remove Course";
            this.RemoveCorse.UseVisualStyleBackColor = true;
            this.RemoveCorse.Click += new System.EventHandler(this.RemoveCorse_Click);
            // 
            // ViewGreadsbtn
            // 
            this.ViewGreadsbtn.Location = new System.Drawing.Point(363, 119);
            this.ViewGreadsbtn.Margin = new System.Windows.Forms.Padding(2);
            this.ViewGreadsbtn.Name = "ViewGreadsbtn";
            this.ViewGreadsbtn.Size = new System.Drawing.Size(75, 39);
            this.ViewGreadsbtn.TabIndex = 55;
            this.ViewGreadsbtn.Text = "ViewGread";
            this.ViewGreadsbtn.UseVisualStyleBackColor = true;
            this.ViewGreadsbtn.Click += new System.EventHandler(this.ViewGreadsbtn_Click);
            // 
            // Exams
            // 
            this.Exams.Location = new System.Drawing.Point(466, 119);
            this.Exams.Margin = new System.Windows.Forms.Padding(2);
            this.Exams.Name = "Exams";
            this.Exams.Size = new System.Drawing.Size(75, 39);
            this.Exams.TabIndex = 56;
            this.Exams.Text = "Exams";
            this.Exams.UseVisualStyleBackColor = true;
            this.Exams.Click += new System.EventHandler(this.Exams_Click);
            // 
            // viewMessagesBTN
            // 
            this.viewMessagesBTN.Location = new System.Drawing.Point(415, 224);
            this.viewMessagesBTN.Margin = new System.Windows.Forms.Padding(2);
            this.viewMessagesBTN.Name = "viewMessagesBTN";
            this.viewMessagesBTN.Size = new System.Drawing.Size(75, 39);
            this.viewMessagesBTN.TabIndex = 57;
            this.viewMessagesBTN.Text = "View Messages";
            this.viewMessagesBTN.UseVisualStyleBackColor = true;
            this.viewMessagesBTN.Click += new System.EventHandler(this.viewMessagesBTN_Click);
            // 
            // sendMessagesBTN
            // 
            this.sendMessagesBTN.Location = new System.Drawing.Point(311, 224);
            this.sendMessagesBTN.Margin = new System.Windows.Forms.Padding(2);
            this.sendMessagesBTN.Name = "sendMessagesBTN";
            this.sendMessagesBTN.Size = new System.Drawing.Size(62, 42);
            this.sendMessagesBTN.TabIndex = 58;
            this.sendMessagesBTN.Text = "Send Messages";
            this.sendMessagesBTN.UseVisualStyleBackColor = true;
            this.sendMessagesBTN.Click += new System.EventHandler(this.sendMessagesBTN_Click);
            // 
            // SendRequestBTN
            // 
            this.SendRequestBTN.Location = new System.Drawing.Point(197, 224);
            this.SendRequestBTN.Margin = new System.Windows.Forms.Padding(2);
            this.SendRequestBTN.Name = "SendRequestBTN";
            this.SendRequestBTN.Size = new System.Drawing.Size(56, 42);
            this.SendRequestBTN.TabIndex = 59;
            this.SendRequestBTN.Text = "Send Request";
            this.SendRequestBTN.UseVisualStyleBackColor = true;
            this.SendRequestBTN.Click += new System.EventHandler(this.SendRequestBTN_Click);
            // 
            // viewRequestsBTN
            // 
            this.viewRequestsBTN.Location = new System.Drawing.Point(64, 224);
            this.viewRequestsBTN.Margin = new System.Windows.Forms.Padding(2);
            this.viewRequestsBTN.Name = "viewRequestsBTN";
            this.viewRequestsBTN.Size = new System.Drawing.Size(94, 42);
            this.viewRequestsBTN.TabIndex = 60;
            this.viewRequestsBTN.Text = "View Requests Status";
            this.viewRequestsBTN.UseVisualStyleBackColor = true;
            this.viewRequestsBTN.Click += new System.EventHandler(this.viewRequestsBTN_Click);
            // 
            // studentname_lbl
            // 
            this.studentname_lbl.AutoSize = true;
            this.studentname_lbl.Font = new System.Drawing.Font("Sitka Display", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentname_lbl.Location = new System.Drawing.Point(154, 34);
            this.studentname_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentname_lbl.Name = "studentname_lbl";
            this.studentname_lbl.Size = new System.Drawing.Size(85, 43);
            this.studentname_lbl.TabIndex = 61;
            this.studentname_lbl.Text = "label1";
            // 
            // uperpanel
            // 
            this.uperpanel.BackColor = System.Drawing.Color.LightGreen;
            this.uperpanel.Controls.Add(this.date_lbl);
            this.uperpanel.Controls.Add(this.studentname_lbl);
            this.uperpanel.Controls.Add(this.button1);
            this.uperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uperpanel.Location = new System.Drawing.Point(0, 0);
            this.uperpanel.Margin = new System.Windows.Forms.Padding(2);
            this.uperpanel.Name = "uperpanel";
            this.uperpanel.Size = new System.Drawing.Size(561, 82);
            this.uperpanel.TabIndex = 63;
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(23, 47);
            this.date_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(49, 28);
            this.date_lbl.TabIndex = 62;
            this.date_lbl.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "not working correctly";
            // 
            // studentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(561, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uperpanel);
            this.Controls.Add(this.viewRequestsBTN);
            this.Controls.Add(this.SendRequestBTN);
            this.Controls.Add(this.sendMessagesBTN);
            this.Controls.Add(this.viewMessagesBTN);
            this.Controls.Add(this.Exams);
            this.Controls.Add(this.ViewGreadsbtn);
            this.Controls.Add(this.RemoveCorse);
            this.Controls.Add(this.AddCourse);
            this.Controls.Add(this.sst);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "studentMain";
            this.Text = "studentMain";
            this.Load += new System.EventHandler(this.studentMain_Load);
            this.uperpanel.ResumeLayout(false);
            this.uperpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddCourse;
        private System.Windows.Forms.Button RemoveCorse;
        private System.Windows.Forms.Button ViewGreadsbtn;
        private System.Windows.Forms.Button Exams;
        private System.Windows.Forms.Button viewMessagesBTN;
        private System.Windows.Forms.Button sendMessagesBTN;
        private System.Windows.Forms.Button SendRequestBTN;
        private System.Windows.Forms.Button viewRequestsBTN;
        private System.Windows.Forms.Label studentname_lbl;
        private System.Windows.Forms.Panel uperpanel;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label label1;
    }
}