﻿namespace WindowsFormsApp1
{
    partial class ManagerMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.deletec_btn = new System.Windows.Forms.Button();
            this.SendMessage = new System.Windows.Forms.Button();
            this.ManageeMessage = new System.Windows.Forms.Button();
            this.AddDatebtn = new System.Windows.Forms.Button();
            this.courseindeoartment_btn = new System.Windows.Forms.Button();
            this.showinstructor_btn = new System.Windows.Forms.Button();
            this.showsutdents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(16, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 51;
            this.button1.Text = "Add Course";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(680, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 49);
            this.button2.TabIndex = 55;
            this.button2.Text = "Log out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // deletec_btn
            // 
            this.deletec_btn.BackColor = System.Drawing.SystemColors.Control;
            this.deletec_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deletec_btn.Location = new System.Drawing.Point(184, 104);
            this.deletec_btn.Name = "deletec_btn";
            this.deletec_btn.Size = new System.Drawing.Size(125, 40);
            this.deletec_btn.TabIndex = 52;
            this.deletec_btn.Text = "Delete Course";
            this.deletec_btn.UseVisualStyleBackColor = false;
            this.deletec_btn.Click += new System.EventHandler(this.deletec_btn_Click);
            // 
            // SendMessage
            // 
            this.SendMessage.BackColor = System.Drawing.SystemColors.Control;
            this.SendMessage.Location = new System.Drawing.Point(366, 104);
            this.SendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(119, 40);
            this.SendMessage.TabIndex = 53;
            this.SendMessage.Text = "Send Message";
            this.SendMessage.UseVisualStyleBackColor = false;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // ManageeMessage
            // 
            this.ManageeMessage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ManageeMessage.Location = new System.Drawing.Point(515, 104);
            this.ManageeMessage.Margin = new System.Windows.Forms.Padding(2);
            this.ManageeMessage.Name = "ManageeMessage";
            this.ManageeMessage.Size = new System.Drawing.Size(107, 40);
            this.ManageeMessage.TabIndex = 54;
            this.ManageeMessage.Text = "Massege";
            this.ManageeMessage.UseVisualStyleBackColor = false;
            this.ManageeMessage.Click += new System.EventHandler(this.ManageeMessage_Click);
            // 
            // AddDatebtn
            // 
            this.AddDatebtn.Location = new System.Drawing.Point(27, 242);
            this.AddDatebtn.Name = "AddDatebtn";
            this.AddDatebtn.Size = new System.Drawing.Size(111, 51);
            this.AddDatebtn.TabIndex = 56;
            this.AddDatebtn.Text = "Add Course Exam Date";
            this.AddDatebtn.UseVisualStyleBackColor = true;
            this.AddDatebtn.Click += new System.EventHandler(this.AddDatebtn_Click);
            // 
            // courseindeoartment_btn
            // 
            this.courseindeoartment_btn.Location = new System.Drawing.Point(516, 231);
            this.courseindeoartment_btn.Name = "courseindeoartment_btn";
            this.courseindeoartment_btn.Size = new System.Drawing.Size(131, 73);
            this.courseindeoartment_btn.TabIndex = 57;
            this.courseindeoartment_btn.Text = "Show Courses In My Department";
            this.courseindeoartment_btn.UseVisualStyleBackColor = true;
            this.courseindeoartment_btn.Click += new System.EventHandler(this.courseindeoartment_btn_Click);
            // 
            // showinstructor_btn
            // 
            this.showinstructor_btn.Location = new System.Drawing.Point(366, 242);
            this.showinstructor_btn.Name = "showinstructor_btn";
            this.showinstructor_btn.Size = new System.Drawing.Size(122, 62);
            this.showinstructor_btn.TabIndex = 58;
            this.showinstructor_btn.Text = "Show Instructor In My Department";
            this.showinstructor_btn.UseVisualStyleBackColor = true;
            this.showinstructor_btn.Click += new System.EventHandler(this.showinstructor_btn_Click);
            // 
            // showsutdents
            // 
            this.showsutdents.Location = new System.Drawing.Point(184, 242);
            this.showsutdents.Name = "showsutdents";
            this.showsutdents.Size = new System.Drawing.Size(120, 62);
            this.showsutdents.TabIndex = 59;
            this.showsutdents.Text = "Show Students In Course In My Department";
            this.showsutdents.UseVisualStyleBackColor = true;
            this.showsutdents.Click += new System.EventHandler(this.showsutdents_Click);
            // 
            // ManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showsutdents);
            this.Controls.Add(this.showinstructor_btn);
            this.Controls.Add(this.courseindeoartment_btn);
            this.Controls.Add(this.AddDatebtn);
            this.Controls.Add(this.ManageeMessage);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.deletec_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ManagerMain";
            this.Text = "ManagerMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button deletec_btn;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.Button ManageeMessage;
        private System.Windows.Forms.Button AddDatebtn;
        private System.Windows.Forms.Button courseindeoartment_btn;
        private System.Windows.Forms.Button showinstructor_btn;
        private System.Windows.Forms.Button showsutdents;
    }
}