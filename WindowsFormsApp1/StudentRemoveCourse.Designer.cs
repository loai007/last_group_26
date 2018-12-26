namespace WindowsFormsApp1
{
    partial class StudentRemoveCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.textcourse = new System.Windows.Forms.TextBox();
            this.RemoveCourse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "name course:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textcourse
            // 
            this.textcourse.Location = new System.Drawing.Point(355, 159);
            this.textcourse.Multiline = true;
            this.textcourse.Name = "textcourse";
            this.textcourse.Size = new System.Drawing.Size(138, 52);
            this.textcourse.TabIndex = 2;
            // 
            // RemoveCourse
            // 
            this.RemoveCourse.Location = new System.Drawing.Point(374, 249);
            this.RemoveCourse.Name = "RemoveCourse";
            this.RemoveCourse.Size = new System.Drawing.Size(100, 40);
            this.RemoveCourse.TabIndex = 3;
            this.RemoveCourse.Text = "Remove";
            this.RemoveCourse.UseVisualStyleBackColor = true;
            this.RemoveCourse.Click += new System.EventHandler(this.RemoveCourse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 4;
            // 
            // RemoveCourseStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveCourse);
            this.Controls.Add(this.textcourse);
            this.Controls.Add(this.label1);
            this.Name = "RemoveCourseStudent";
            this.Text = "RemoveCourseStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textcourse;
        private System.Windows.Forms.Button RemoveCourse;
        private System.Windows.Forms.Label label2;
    }
}