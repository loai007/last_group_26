namespace WindowsFormsApp1
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
            this.SuspendLayout();
            // 
            // sst
            // 
            this.sst.Location = new System.Drawing.Point(15, 100);
            this.sst.Name = "sst";
            this.sst.Size = new System.Drawing.Size(100, 48);
            this.sst.TabIndex = 0;
            this.sst.Text = "Schedule";
            this.sst.UseVisualStyleBackColor = true;
            this.sst.Click += new System.EventHandler(this.sst_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 52);
            this.button1.TabIndex = 51;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCourse
            // 
            this.AddCourse.Location = new System.Drawing.Point(125, 100);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(100, 48);
            this.AddCourse.TabIndex = 53;
            this.AddCourse.Text = "Add Course";
            this.AddCourse.UseVisualStyleBackColor = true;
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // RemoveCorse
            // 
            this.RemoveCorse.Location = new System.Drawing.Point(237, 100);
            this.RemoveCorse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveCorse.Name = "RemoveCorse";
            this.RemoveCorse.Size = new System.Drawing.Size(100, 48);
            this.RemoveCorse.TabIndex = 54;
            this.RemoveCorse.Text = "Remove Course";
            this.RemoveCorse.UseVisualStyleBackColor = true;
            this.RemoveCorse.Click += new System.EventHandler(this.RemoveCorse_Click);
            // 
            // ViewGreadsbtn
            // 
            this.ViewGreadsbtn.Location = new System.Drawing.Point(354, 100);
            this.ViewGreadsbtn.Name = "ViewGreadsbtn";
            this.ViewGreadsbtn.Size = new System.Drawing.Size(100, 48);
            this.ViewGreadsbtn.TabIndex = 55;
            this.ViewGreadsbtn.Text = "ViewGread";
            this.ViewGreadsbtn.UseVisualStyleBackColor = true;
            this.ViewGreadsbtn.Click += new System.EventHandler(this.ViewGreadsbtn_Click);
            // 
            // studentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewGreadsbtn);
            this.Controls.Add(this.RemoveCorse);
            this.Controls.Add(this.AddCourse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sst);
            this.Name = "studentMain";
            this.Text = "studentMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddCourse;
        private System.Windows.Forms.Button RemoveCorse;
        private System.Windows.Forms.Button ViewGreadsbtn;
    }
}