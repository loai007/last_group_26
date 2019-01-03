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
            this.date_lbl = new System.Windows.Forms.Label();
            this.instructorname_lbl = new System.Windows.Forms.Label();
            this.VeiwMessagesBTN = new System.Windows.Forms.Button();
            this.viewRequestsBTN = new System.Windows.Forms.Button();
            this.answerRequestsBTN = new System.Windows.Forms.Button();
            this.SendMessages = new System.Windows.Forms.Button();
            this.SendRequestBTN = new System.Windows.Forms.Button();
            this.uperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(58, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(468, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sigh out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // corses_btn
            // 
            this.corses_btn.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corses_btn.Location = new System.Drawing.Point(226, 115);
            this.corses_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.corses_btn.Name = "corses_btn";
            this.corses_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.corses_btn.Size = new System.Drawing.Size(104, 30);
            this.corses_btn.TabIndex = 1;
            this.corses_btn.Text = "Corses I Teach";
            this.corses_btn.UseVisualStyleBackColor = true;
            this.corses_btn.Click += new System.EventHandler(this.corses_btn_Click);
            // 
            // AddMarksBtn
            // 
            this.AddMarksBtn.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMarksBtn.Location = new System.Drawing.Point(385, 115);
            this.AddMarksBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddMarksBtn.Name = "AddMarksBtn";
            this.AddMarksBtn.Size = new System.Drawing.Size(106, 30);
            this.AddMarksBtn.TabIndex = 2;
            this.AddMarksBtn.Text = "Add Exam Marks";
            this.AddMarksBtn.UseVisualStyleBackColor = true;
            this.AddMarksBtn.Click += new System.EventHandler(this.AddMarksBtn_Click);
            // 
            // showstudents_btn
            // 
            this.showstudents_btn.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showstudents_btn.Location = new System.Drawing.Point(58, 207);
            this.showstudents_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showstudents_btn.Name = "showstudents_btn";
            this.showstudents_btn.Size = new System.Drawing.Size(114, 53);
            this.showstudents_btn.TabIndex = 3;
            this.showstudents_btn.Text = "Show Students In My Course";
            this.showstudents_btn.UseVisualStyleBackColor = true;
            this.showstudents_btn.Click += new System.EventHandler(this.showstudents_btn_Click);
            // 
            // uperpanel
            // 
            this.uperpanel.BackColor = System.Drawing.Color.LightGreen;
            this.uperpanel.Controls.Add(this.date_lbl);
            this.uperpanel.Controls.Add(this.instructorname_lbl);
            this.uperpanel.Controls.Add(this.button2);
            this.uperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uperpanel.Location = new System.Drawing.Point(0, 0);
            this.uperpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uperpanel.Name = "uperpanel";
            this.uperpanel.Size = new System.Drawing.Size(560, 82);
            this.uperpanel.TabIndex = 55;
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(23, 47);
            this.date_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(49, 28);
            this.date_lbl.TabIndex = 58;
            this.date_lbl.Text = "Date";
            // 
            // instructorname_lbl
            // 
            this.instructorname_lbl.AutoSize = true;
            this.instructorname_lbl.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorname_lbl.Location = new System.Drawing.Point(171, 33);
            this.instructorname_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructorname_lbl.Name = "instructorname_lbl";
            this.instructorname_lbl.Size = new System.Drawing.Size(227, 47);
            this.instructorname_lbl.TabIndex = 52;
            this.instructorname_lbl.Text = "Instructor Name";
            this.instructorname_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VeiwMessagesBTN
            // 
            this.VeiwMessagesBTN.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VeiwMessagesBTN.Location = new System.Drawing.Point(385, 206);
            this.VeiwMessagesBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VeiwMessagesBTN.Name = "VeiwMessagesBTN";
            this.VeiwMessagesBTN.Size = new System.Drawing.Size(114, 53);
            this.VeiwMessagesBTN.TabIndex = 4;
            this.VeiwMessagesBTN.Text = "Veiw Messages";
            this.VeiwMessagesBTN.UseVisualStyleBackColor = true;
            this.VeiwMessagesBTN.Click += new System.EventHandler(this.VeiwMessagesBTN_Click);
            // 
            // viewRequestsBTN
            // 
            this.viewRequestsBTN.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRequestsBTN.Location = new System.Drawing.Point(58, 314);
            this.viewRequestsBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewRequestsBTN.Name = "viewRequestsBTN";
            this.viewRequestsBTN.Size = new System.Drawing.Size(114, 53);
            this.viewRequestsBTN.TabIndex = 5;
            this.viewRequestsBTN.Text = " View My Requests";
            this.viewRequestsBTN.UseVisualStyleBackColor = true;
            this.viewRequestsBTN.Click += new System.EventHandler(this.viewRequestsBTN_Click);
            // 
            // answerRequestsBTN
            // 
            this.answerRequestsBTN.Location = new System.Drawing.Point(385, 314);
            this.answerRequestsBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answerRequestsBTN.Name = "answerRequestsBTN";
            this.answerRequestsBTN.Size = new System.Drawing.Size(114, 53);
            this.answerRequestsBTN.TabIndex = 56;
            this.answerRequestsBTN.Text = "Answer Requests";
            this.answerRequestsBTN.UseVisualStyleBackColor = true;
            this.answerRequestsBTN.Click += new System.EventHandler(this.answerRequestsBTN_Click);
            // 
            // SendMessages
            // 
            this.SendMessages.Location = new System.Drawing.Point(226, 207);
            this.SendMessages.Margin = new System.Windows.Forms.Padding(2);
            this.SendMessages.Name = "SendMessages";
            this.SendMessages.Size = new System.Drawing.Size(114, 53);
            this.SendMessages.TabIndex = 57;
            this.SendMessages.Text = "Send Messages";
            this.SendMessages.UseVisualStyleBackColor = true;
            this.SendMessages.Click += new System.EventHandler(this.SendMessages_Click);
            // 
            // SendRequestBTN
            // 
            this.SendRequestBTN.Location = new System.Drawing.Point(226, 314);
            this.SendRequestBTN.Name = "SendRequestBTN";
            this.SendRequestBTN.Size = new System.Drawing.Size(114, 53);
            this.SendRequestBTN.TabIndex = 58;
            this.SendRequestBTN.Text = "Send Request";
            this.SendRequestBTN.UseVisualStyleBackColor = true;
            this.SendRequestBTN.Click += new System.EventHandler(this.SendRequestBTN_Click);
            // 
            // InstructorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 446);
            this.Controls.Add(this.SendRequestBTN);
            this.Controls.Add(this.SendMessages);
            this.Controls.Add(this.answerRequestsBTN);
            this.Controls.Add(this.viewRequestsBTN);
            this.Controls.Add(this.VeiwMessagesBTN);
            this.Controls.Add(this.uperpanel);
            this.Controls.Add(this.showstudents_btn);
            this.Controls.Add(this.AddMarksBtn);
            this.Controls.Add(this.corses_btn);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button VeiwMessagesBTN;
        private System.Windows.Forms.Button viewRequestsBTN;
        private System.Windows.Forms.Button answerRequestsBTN;
        private System.Windows.Forms.Button SendMessages;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Button SendRequestBTN;
    }
}