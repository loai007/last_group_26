namespace WindowsFormsApp1
{
    partial class ManagerShowStudentsInCourse
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
            this.back_btn = new System.Windows.Forms.Button();
            this.showstudents_grd = new System.Windows.Forms.DataGridView();
            this.coursename_txtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.show_btn = new System.Windows.Forms.Button();
            this.erore_lbl = new System.Windows.Forms.Label();
            this.uperpanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showstudents_grd)).BeginInit();
            this.uperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Sitka Display", 10.2F);
            this.back_btn.Location = new System.Drawing.Point(676, 3);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(121, 46);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // showstudents_grd
            // 
            this.showstudents_grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showstudents_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showstudents_grd.Location = new System.Drawing.Point(60, 118);
            this.showstudents_grd.Name = "showstudents_grd";
            this.showstudents_grd.RowTemplate.Height = 24;
            this.showstudents_grd.Size = new System.Drawing.Size(659, 183);
            this.showstudents_grd.TabIndex = 1;
            // 
            // coursename_txtb
            // 
            this.coursename_txtb.Location = new System.Drawing.Point(310, 357);
            this.coursename_txtb.Name = "coursename_txtb";
            this.coursename_txtb.Size = new System.Drawing.Size(126, 22);
            this.coursename_txtb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course Name :";
            // 
            // show_btn
            // 
            this.show_btn.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.Location = new System.Drawing.Point(322, 398);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(98, 30);
            this.show_btn.TabIndex = 4;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // erore_lbl
            // 
            this.erore_lbl.AutoSize = true;
            this.erore_lbl.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erore_lbl.Location = new System.Drawing.Point(345, 317);
            this.erore_lbl.Name = "erore_lbl";
            this.erore_lbl.Size = new System.Drawing.Size(49, 24);
            this.erore_lbl.TabIndex = 5;
            this.erore_lbl.Text = "label2";
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
            this.uperpanel.Size = new System.Drawing.Size(800, 101);
            this.uperpanel.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(228, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 58);
            this.label9.TabIndex = 4;
            this.label9.Text = "Students In Course";
            // 
            // ManagerShowStudentsInCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uperpanel);
            this.Controls.Add(this.erore_lbl);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coursename_txtb);
            this.Controls.Add(this.showstudents_grd);
            this.Name = "ManagerShowStudentsInCourse";
            this.Text = "ManagerShowStudentsInCourse";
            ((System.ComponentModel.ISupportInitialize)(this.showstudents_grd)).EndInit();
            this.uperpanel.ResumeLayout(false);
            this.uperpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView showstudents_grd;
        private System.Windows.Forms.TextBox coursename_txtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Label erore_lbl;
        private System.Windows.Forms.Panel uperpanel;
        private System.Windows.Forms.Label label9;
    }
}