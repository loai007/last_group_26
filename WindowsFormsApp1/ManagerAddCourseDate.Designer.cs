namespace WindowsFormsApp1
{
    partial class ManagerAddCourseDate
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.messagelbl = new System.Windows.Forms.Label();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.timeTB = new System.Windows.Forms.TextBox();
            this.addBTN = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.courseNameTB = new System.Windows.Forms.TextBox();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Of Exam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time Of Exam:";
            // 
            // messagelbl
            // 
            this.messagelbl.AutoSize = true;
            this.messagelbl.Location = new System.Drawing.Point(507, 406);
            this.messagelbl.Name = "messagelbl";
            this.messagelbl.Size = new System.Drawing.Size(46, 17);
            this.messagelbl.TabIndex = 4;
            this.messagelbl.Text = "label5";
            // 
            // dateTB
            // 
            this.dateTB.Location = new System.Drawing.Point(238, 339);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(100, 22);
            this.dateTB.TabIndex = 6;
            // 
            // timeTB
            // 
            this.timeTB.Location = new System.Drawing.Point(238, 399);
            this.timeTB.Name = "timeTB";
            this.timeTB.Size = new System.Drawing.Size(100, 22);
            this.timeTB.TabIndex = 7;
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(495, 341);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(75, 23);
            this.addBTN.TabIndex = 9;
            this.addBTN.Text = "Add Time";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(664, 2);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(133, 54);
            this.Backbtn.TabIndex = 11;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "DD/MM/YYYY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "HH:MM";
            // 
            // courseNameTB
            // 
            this.courseNameTB.AcceptsReturn = true;
            this.courseNameTB.Location = new System.Drawing.Point(238, 279);
            this.courseNameTB.Name = "courseNameTB";
            this.courseNameTB.Size = new System.Drawing.Size(100, 22);
            this.courseNameTB.TabIndex = 14;
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(21, 62);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowTemplate.Height = 24;
            this.dataGridViewCourses.Size = new System.Drawing.Size(776, 181);
            this.dataGridViewCourses.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Here are the courses:";
            // 
            // ManagerAddCourseDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.courseNameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.timeTB);
            this.Controls.Add(this.dateTB);
            this.Controls.Add(this.messagelbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ManagerAddCourseDate";
            this.Text = "InstructorAddCourseDate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label messagelbl;
        private System.Windows.Forms.TextBox dateTB;
        private System.Windows.Forms.TextBox timeTB;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox courseNameTB;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Label label6;
    }
}