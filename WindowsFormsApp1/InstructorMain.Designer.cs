namespace WindowsFormsApp1
{
    partial class InstructorMain
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
            this.corses_btn = new System.Windows.Forms.Button();
            this.AddMarksBtn = new System.Windows.Forms.Button();
            this.showstudents_btn = new System.Windows.Forms.Button();
            this.uperpanel = new System.Windows.Forms.Panel();
            this.instructorname_lbl = new System.Windows.Forms.Label();
            this.uperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(77, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(624, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 46);
            this.button2.TabIndex = 51;
            this.button2.Text = "Sigh out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // corses_btn
            // 
            this.corses_btn.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corses_btn.Location = new System.Drawing.Point(302, 142);
            this.corses_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.corses_btn.Name = "corses_btn";
            this.corses_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.corses_btn.Size = new System.Drawing.Size(139, 37);
            this.corses_btn.TabIndex = 52;
            this.corses_btn.Text = "Corses I Teach";
            this.corses_btn.UseVisualStyleBackColor = true;
            this.corses_btn.Click += new System.EventHandler(this.corses_btn_Click);
            // 
            // AddMarksBtn
            // 
            this.AddMarksBtn.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMarksBtn.Location = new System.Drawing.Point(513, 142);
            this.AddMarksBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddMarksBtn.Name = "AddMarksBtn";
            this.AddMarksBtn.Size = new System.Drawing.Size(141, 37);
            this.AddMarksBtn.TabIndex = 53;
            this.AddMarksBtn.Text = "Add Exam Marks";
            this.AddMarksBtn.UseVisualStyleBackColor = true;
            this.AddMarksBtn.Click += new System.EventHandler(this.AddMarksBtn_Click);
            // 
            // showstudents_btn
            // 
            this.showstudents_btn.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showstudents_btn.Location = new System.Drawing.Point(77, 255);
            this.showstudents_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showstudents_btn.Name = "showstudents_btn";
            this.showstudents_btn.Size = new System.Drawing.Size(152, 65);
            this.showstudents_btn.TabIndex = 54;
            this.showstudents_btn.Text = "Show Students In My Course";
            this.showstudents_btn.UseVisualStyleBackColor = true;
            this.showstudents_btn.Click += new System.EventHandler(this.showstudents_btn_Click);
            // 
            // uperpanel
            // 
            this.uperpanel.BackColor = System.Drawing.Color.LightGreen;
            this.uperpanel.Controls.Add(this.instructorname_lbl);
            this.uperpanel.Controls.Add(this.button2);
            this.uperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uperpanel.Location = new System.Drawing.Point(0, 0);
            this.uperpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uperpanel.Name = "uperpanel";
            this.uperpanel.Size = new System.Drawing.Size(747, 101);
            this.uperpanel.TabIndex = 55;
            // 
            // instructorname_lbl
            // 
            this.instructorname_lbl.AutoSize = true;
            this.instructorname_lbl.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorname_lbl.Location = new System.Drawing.Point(264, 37);
            this.instructorname_lbl.Name = "instructorname_lbl";
            this.instructorname_lbl.Size = new System.Drawing.Size(164, 33);
            this.instructorname_lbl.TabIndex = 52;
            this.instructorname_lbl.Text = "Instructor Name";
            this.instructorname_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 549);
            this.Controls.Add(this.uperpanel);
            this.Controls.Add(this.showstudents_btn);
            this.Controls.Add(this.AddMarksBtn);
            this.Controls.Add(this.corses_btn);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InstructorMain";
            this.Text = "InstructorMain";
            this.Load += new System.EventHandler(this.InstructorMain_Load);
            this.uperpanel.ResumeLayout(false);
            this.uperpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button corses_btn;
        private System.Windows.Forms.Button AddMarksBtn;
        private System.Windows.Forms.Button showstudents_btn;
        private System.Windows.Forms.Panel uperpanel;
        private System.Windows.Forms.Label instructorname_lbl;
    }
}