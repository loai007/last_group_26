namespace WindowsFormsApp1
{
    partial class InstructorShowCourses
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
            this.Back_btn = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.coursename_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.day_lbl = new System.Windows.Forms.Label();
            this.hour_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(645, 1);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(155, 58);
            this.Back_btn.TabIndex = 1;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(224, 164);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(160, 25);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Instructor Name :";
            this.lbl1.Click += new System.EventHandler(this.name_lbl_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(240, 216);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(144, 25);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Course Name :";
            // 
            // coursename_lbl
            // 
            this.coursename_lbl.AutoSize = true;
            this.coursename_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursename_lbl.Location = new System.Drawing.Point(498, 216);
            this.coursename_lbl.Name = "coursename_lbl";
            this.coursename_lbl.Size = new System.Drawing.Size(53, 25);
            this.coursename_lbl.TabIndex = 4;
            this.coursename_lbl.Text = "lable";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(498, 164);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(46, 25);
            this.name_lbl.TabIndex = 5;
            this.name_lbl.Text = "labll";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Day :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hour :";
            // 
            // day_lbl
            // 
            this.day_lbl.AutoSize = true;
            this.day_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_lbl.Location = new System.Drawing.Point(498, 264);
            this.day_lbl.Name = "day_lbl";
            this.day_lbl.Size = new System.Drawing.Size(64, 25);
            this.day_lbl.TabIndex = 8;
            this.day_lbl.Text = "label3";
            // 
            // hour_lbl
            // 
            this.hour_lbl.AutoSize = true;
            this.hour_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_lbl.Location = new System.Drawing.Point(498, 310);
            this.hour_lbl.Name = "hour_lbl";
            this.hour_lbl.Size = new System.Drawing.Size(64, 25);
            this.hour_lbl.TabIndex = 9;
            this.hour_lbl.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(610, 48);
            this.label3.TabIndex = 10;
            this.label3.Text = "Instructor Course and information";
            // 
            // InstructorShowCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hour_lbl);
            this.Controls.Add(this.day_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.coursename_lbl);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.Back_btn);
            this.Name = "InstructorShowCourses";
            this.Text = "InstructorShowCourses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label coursename_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label day_lbl;
        private System.Windows.Forms.Label hour_lbl;
        private System.Windows.Forms.Label label3;
    }
}