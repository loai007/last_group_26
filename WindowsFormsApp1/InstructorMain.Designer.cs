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
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(679, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 45);
            this.button2.TabIndex = 51;
            this.button2.Text = "Log out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // corses_btn
            // 
            this.corses_btn.Location = new System.Drawing.Point(210, 84);
            this.corses_btn.Name = "corses_btn";
            this.corses_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.corses_btn.Size = new System.Drawing.Size(140, 37);
            this.corses_btn.TabIndex = 52;
            this.corses_btn.Text = "Corses I teach";
            this.corses_btn.UseVisualStyleBackColor = true;
            this.corses_btn.Click += new System.EventHandler(this.corses_btn_Click);
            // 
            // AddMarksBtn
            // 
            this.AddMarksBtn.Location = new System.Drawing.Point(412, 84);
            this.AddMarksBtn.Name = "AddMarksBtn";
            this.AddMarksBtn.Size = new System.Drawing.Size(115, 36);
            this.AddMarksBtn.TabIndex = 53;
            this.AddMarksBtn.Text = "add marks";
            this.AddMarksBtn.UseVisualStyleBackColor = true;
            this.AddMarksBtn.Click += new System.EventHandler(this.AddMarksBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(418, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 65);
            this.button3.TabIndex = 54;
            this.button3.Text = "Show Students In my Course";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InstructorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AddMarksBtn);
            this.Controls.Add(this.corses_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "InstructorMain";
            this.Text = "InstructorMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button corses_btn;
        private System.Windows.Forms.Button AddMarksBtn;
        private System.Windows.Forms.Button button3;
    }
}