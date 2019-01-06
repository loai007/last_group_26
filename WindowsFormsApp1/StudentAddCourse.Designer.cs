namespace WindowsFormsApp1
{
    partial class StudentAddCourse
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
            this.components = new System.ComponentModel.Container();
            this.welcomelbl = new System.Windows.Forms.Label();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.textBoxAddCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCourse = new System.Windows.Forms.Button();
            this.massagelbl = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.courses_studentsTableAdapter1 = new WindowsFormsApp1.collegeDataSetTableAdapters.courses_studentsTableAdapter();
            this.collegeDataSet = new WindowsFormsApp1.collegeDataSet();
            this.coursesTableAdapter = new WindowsFormsApp1.collegeDataSetTableAdapters.coursesTableAdapter();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uperpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.uperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomelbl
            // 
            this.welcomelbl.AutoSize = true;
            this.welcomelbl.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelbl.Location = new System.Drawing.Point(5, 91);
            this.welcomelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(203, 23);
            this.welcomelbl.TabIndex = 0;
            this.welcomelbl.Text = "Here is a list of the courses: ";
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(9, 114);
            this.dataGridViewCourses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowTemplate.Height = 24;
            this.dataGridViewCourses.Size = new System.Drawing.Size(544, 188);
            this.dataGridViewCourses.TabIndex = 2;
            this.dataGridViewCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourses_CellContentClick);
            this.dataGridViewCourses.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCourses_RowHeaderMouseClick);
            // 
            // textBoxAddCourse
            // 
            this.textBoxAddCourse.Location = new System.Drawing.Point(356, 313);
            this.textBoxAddCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddCourse.Name = "textBoxAddCourse";
            this.textBoxAddCourse.Size = new System.Drawing.Size(108, 20);
            this.textBoxAddCourse.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the name of the course you would like to add:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddCourse
            // 
            this.AddCourse.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCourse.Location = new System.Drawing.Point(370, 349);
            this.AddCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(75, 32);
            this.AddCourse.TabIndex = 5;
            this.AddCourse.Text = "Add course";
            this.AddCourse.UseVisualStyleBackColor = true;
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // massagelbl
            // 
            this.massagelbl.AutoSize = true;
            this.massagelbl.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.massagelbl.Location = new System.Drawing.Point(300, 388);
            this.massagelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.massagelbl.Name = "massagelbl";
            this.massagelbl.Size = new System.Drawing.Size(20, 18);
            this.massagelbl.TabIndex = 6;
            this.massagelbl.Text = "lbl";
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(467, 2);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(91, 37);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // courses_studentsTableAdapter1
            // 
            this.courses_studentsTableAdapter1.ClearBeforeFill = true;
            // 
            // collegeDataSet
            // 
            this.collegeDataSet.DataSetName = "collegeDataSet";
            this.collegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.collegeDataSet;
            // 
            // uperpanel
            // 
            this.uperpanel.BackColor = System.Drawing.Color.LightGreen;
            this.uperpanel.Controls.Add(this.label2);
            this.uperpanel.Controls.Add(this.BackBtn);
            this.uperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uperpanel.Location = new System.Drawing.Point(0, 0);
            this.uperpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uperpanel.Name = "uperpanel";
            this.uperpanel.Size = new System.Drawing.Size(560, 82);
            this.uperpanel.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add Course";
            // 
            // StudentAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 446);
            this.Controls.Add(this.uperpanel);
            this.Controls.Add(this.massagelbl);
            this.Controls.Add(this.AddCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddCourse);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.welcomelbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentAddCourse";
            this.Text = "StudentAddCourse";
            this.Load += new System.EventHandler(this.StudentAddCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.uperpanel.ResumeLayout(false);
            this.uperpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.TextBox textBoxAddCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCourse;
        private System.Windows.Forms.Label massagelbl;
        private System.Windows.Forms.Button BackBtn;
        private collegeDataSetTableAdapters.courses_studentsTableAdapter courses_studentsTableAdapter1;
        private collegeDataSet collegeDataSet;
        private collegeDataSetTableAdapters.coursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.Panel uperpanel;
        private System.Windows.Forms.Label label2;
    }
}