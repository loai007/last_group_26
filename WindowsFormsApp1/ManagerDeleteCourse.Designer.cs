namespace WindowsFormsApp1
{
    partial class ManagerDeleteCourse
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
            this.coursename_txt = new System.Windows.Forms.TextBox();
            this.coursename_lbl = new System.Windows.Forms.Label();
            this.Deletecourse_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.wrongname_lbl = new System.Windows.Forms.Label();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.uperpanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.uperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // coursename_txt
            // 
            this.coursename_txt.Location = new System.Drawing.Point(342, 406);
            this.coursename_txt.Name = "coursename_txt";
            this.coursename_txt.Size = new System.Drawing.Size(152, 22);
            this.coursename_txt.TabIndex = 0;
            // 
            // coursename_lbl
            // 
            this.coursename_lbl.AutoSize = true;
            this.coursename_lbl.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursename_lbl.Location = new System.Drawing.Point(195, 408);
            this.coursename_lbl.Name = "coursename_lbl";
            this.coursename_lbl.Size = new System.Drawing.Size(131, 28);
            this.coursename_lbl.TabIndex = 1;
            this.coursename_lbl.Text = "Course Name :";
            // 
            // Deletecourse_btn
            // 
            this.Deletecourse_btn.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletecourse_btn.Location = new System.Drawing.Point(370, 449);
            this.Deletecourse_btn.Name = "Deletecourse_btn";
            this.Deletecourse_btn.Size = new System.Drawing.Size(96, 44);
            this.Deletecourse_btn.TabIndex = 2;
            this.Deletecourse_btn.Text = "Delete";
            this.Deletecourse_btn.UseVisualStyleBackColor = true;
            this.Deletecourse_btn.Click += new System.EventHandler(this.Deletecourse_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Sitka Display", 10.2F);
            this.back_btn.Location = new System.Drawing.Point(622, 3);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(121, 46);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // wrongname_lbl
            // 
            this.wrongname_lbl.AutoSize = true;
            this.wrongname_lbl.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongname_lbl.ForeColor = System.Drawing.Color.Black;
            this.wrongname_lbl.Location = new System.Drawing.Point(494, 462);
            this.wrongname_lbl.Name = "wrongname_lbl";
            this.wrongname_lbl.Size = new System.Drawing.Size(0, 28);
            this.wrongname_lbl.TabIndex = 4;
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(10, 141);
            this.dataGridViewCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowTemplate.Height = 24;
            this.dataGridViewCourses.Size = new System.Drawing.Size(725, 231);
            this.dataGridViewCourses.TabIndex = 5;
            this.dataGridViewCourses.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCourses_RowHeaderMouseClick);
            // 
            // uperpanel
            // 
            this.uperpanel.BackColor = System.Drawing.Color.LightGreen;
            this.uperpanel.Controls.Add(this.label9);
            this.uperpanel.Controls.Add(this.back_btn);
            this.uperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uperpanel.Location = new System.Drawing.Point(0, 0);
            this.uperpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uperpanel.Name = "uperpanel";
            this.uperpanel.Size = new System.Drawing.Size(747, 101);
            this.uperpanel.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(260, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 58);
            this.label9.TabIndex = 4;
            this.label9.Text = "Delete Course";
            // 
            // ManagerDeleteCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 549);
            this.Controls.Add(this.uperpanel);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.wrongname_lbl);
            this.Controls.Add(this.Deletecourse_btn);
            this.Controls.Add(this.coursename_lbl);
            this.Controls.Add(this.coursename_txt);
            this.Name = "ManagerDeleteCourse";
            this.Text = "ManagerDeleteCourse";
            this.Load += new System.EventHandler(this.ManagerDeleteCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.uperpanel.ResumeLayout(false);
            this.uperpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox coursename_txt;
        private System.Windows.Forms.Label coursename_lbl;
        private System.Windows.Forms.Button Deletecourse_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label wrongname_lbl;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Panel uperpanel;
        private System.Windows.Forms.Label label9;
    }
}