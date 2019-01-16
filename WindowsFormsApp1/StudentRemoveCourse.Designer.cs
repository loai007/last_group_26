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
            this.back = new System.Windows.Forms.Button();
            this.courses_dgv = new System.Windows.Forms.DataGridView();
            this.uperpanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courses_dgv)).BeginInit();
            this.uperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 265);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Course :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textcourse
            // 
            this.textcourse.Location = new System.Drawing.Point(256, 262);
            this.textcourse.Margin = new System.Windows.Forms.Padding(2);
            this.textcourse.Multiline = true;
            this.textcourse.Name = "textcourse";
            this.textcourse.Size = new System.Drawing.Size(71, 29);
            this.textcourse.TabIndex = 2;
            // 
            // RemoveCourse
            // 
            this.RemoveCourse.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCourse.Location = new System.Drawing.Point(256, 323);
            this.RemoveCourse.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveCourse.Name = "RemoveCourse";
            this.RemoveCourse.Size = new System.Drawing.Size(59, 28);
            this.RemoveCourse.TabIndex = 3;
            this.RemoveCourse.Text = "Remove";
            this.RemoveCourse.UseVisualStyleBackColor = true;
            this.RemoveCourse.Click += new System.EventHandler(this.RemoveCourse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 4;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Sitka Display", 10.2F);
            this.back.Location = new System.Drawing.Point(468, 2);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(91, 37);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // courses_dgv
            // 
            this.courses_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courses_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courses_dgv.Location = new System.Drawing.Point(68, 118);
            this.courses_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.courses_dgv.Name = "courses_dgv";
            this.courses_dgv.RowTemplate.Height = 24;
            this.courses_dgv.Size = new System.Drawing.Size(414, 122);
            this.courses_dgv.TabIndex = 6;
            this.courses_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.courses_dgv_RowHeaderMouseClick);
            // 
            // uperpanel
            // 
            this.uperpanel.BackColor = System.Drawing.Color.LightGreen;
            this.uperpanel.Controls.Add(this.label3);
            this.uperpanel.Controls.Add(this.back);
            this.uperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uperpanel.Location = new System.Drawing.Point(0, 0);
            this.uperpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uperpanel.Name = "uperpanel";
            this.uperpanel.Size = new System.Drawing.Size(560, 82);
            this.uperpanel.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 47);
            this.label3.TabIndex = 4;
            this.label3.Text = "Delete Course";
            // 
            // StudentRemoveCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 446);
            this.Controls.Add(this.uperpanel);
            this.Controls.Add(this.courses_dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveCourse);
            this.Controls.Add(this.textcourse);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentRemoveCourse";
            this.Text = "RemoveCourseStudent";
            this.Load += new System.EventHandler(this.StudentRemoveCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courses_dgv)).EndInit();
            this.uperpanel.ResumeLayout(false);
            this.uperpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textcourse;
        private System.Windows.Forms.Button RemoveCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView courses_dgv;
        private System.Windows.Forms.Panel uperpanel;
        private System.Windows.Forms.Label label3;
    }
}