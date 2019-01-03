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
            this.label1.Location = new System.Drawing.Point(190, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Course :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textcourse
            // 
            this.textcourse.Location = new System.Drawing.Point(342, 323);
            this.textcourse.Margin = new System.Windows.Forms.Padding(2);
            this.textcourse.Multiline = true;
            this.textcourse.Name = "textcourse";
            this.textcourse.Size = new System.Drawing.Size(93, 35);
            this.textcourse.TabIndex = 2;
            // 
            // RemoveCourse
            // 
            this.RemoveCourse.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCourse.Location = new System.Drawing.Point(342, 397);
            this.RemoveCourse.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveCourse.Name = "RemoveCourse";
            this.RemoveCourse.Size = new System.Drawing.Size(79, 35);
            this.RemoveCourse.TabIndex = 3;
            this.RemoveCourse.Text = "Remove";
            this.RemoveCourse.UseVisualStyleBackColor = true;
            this.RemoveCourse.Click += new System.EventHandler(this.RemoveCourse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 360);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 4;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Sitka Display", 10.2F);
            this.back.Location = new System.Drawing.Point(624, 2);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(121, 46);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // courses_dgv
            // 
            this.courses_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courses_dgv.Location = new System.Drawing.Point(90, 145);
            this.courses_dgv.Name = "courses_dgv";
            this.courses_dgv.RowTemplate.Height = 24;
            this.courses_dgv.Size = new System.Drawing.Size(552, 150);
            this.courses_dgv.TabIndex = 6;
            // 
            // uperpanel
            // 
            this.uperpanel.BackColor = System.Drawing.Color.LightGreen;
            this.uperpanel.Controls.Add(this.label3);
            this.uperpanel.Controls.Add(this.back);
            this.uperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uperpanel.Location = new System.Drawing.Point(0, 0);
            this.uperpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uperpanel.Name = "uperpanel";
            this.uperpanel.Size = new System.Drawing.Size(747, 101);
            this.uperpanel.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Delete Course";
            // 
            // StudentRemoveCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 549);
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