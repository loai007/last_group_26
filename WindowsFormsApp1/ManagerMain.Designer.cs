namespace WindowsFormsApp1
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
            this.showinstructors_btn = new System.Windows.Forms.Button();
            this.showcourses_btn = new System.Windows.Forms.Button();
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
            // showinstructors_btn
            // 
            this.showinstructors_btn.Location = new System.Drawing.Point(515, 203);
            this.showinstructors_btn.Name = "showinstructors_btn";
            this.showinstructors_btn.Size = new System.Drawing.Size(121, 61);
            this.showinstructors_btn.TabIndex = 56;
            this.showinstructors_btn.Text = "Show Instructors In My Department";
            this.showinstructors_btn.UseVisualStyleBackColor = true;
            this.showinstructors_btn.Click += new System.EventHandler(this.showinstructors_btn_Click);
            // 
            // showcourses_btn
            // 
            this.showcourses_btn.Location = new System.Drawing.Point(366, 203);
            this.showcourses_btn.Name = "showcourses_btn";
            this.showcourses_btn.Size = new System.Drawing.Size(106, 61);
            this.showcourses_btn.TabIndex = 57;
            this.showcourses_btn.Text = "Show All Courses In My Department";
            this.showcourses_btn.UseVisualStyleBackColor = true;
            this.showcourses_btn.Click += new System.EventHandler(this.showcourses_btn_Click);
            // 
            // ManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showcourses_btn);
            this.Controls.Add(this.showinstructors_btn);
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
        private System.Windows.Forms.Button showinstructors_btn;
        private System.Windows.Forms.Button showcourses_btn;
    }
}