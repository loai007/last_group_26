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
            this.CoursesTable = new System.Windows.Forms.TableLayoutPanel();
            this.courses_studentsTableAdapter1 = new WindowsFormsApp1.collegeDataSetTableAdapters.courses_studentsTableAdapter();
            this.collegeDataSet = new WindowsFormsApp1.collegeDataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new WindowsFormsApp1.collegeDataSetTableAdapters.coursesTableAdapter();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomelbl
            // 
            this.welcomelbl.AutoSize = true;
            this.welcomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelbl.Location = new System.Drawing.Point(12, 23);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(255, 25);
            this.welcomelbl.TabIndex = 0;
            this.welcomelbl.Text = "Here is a list of the courses: ";
            // 
            // CoursesTable
            // 
            this.CoursesTable.ColumnCount = 6;
            this.CoursesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoursesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoursesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CoursesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CoursesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CoursesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CoursesTable.Location = new System.Drawing.Point(31, 70);
            this.CoursesTable.Name = "CoursesTable";
            this.CoursesTable.RowCount = 2;
            this.CoursesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoursesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoursesTable.Size = new System.Drawing.Size(458, 100);
            this.CoursesTable.TabIndex = 1;
            this.CoursesTable.Paint += new System.Windows.Forms.PaintEventHandler(this.CoursesTable_Paint);
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
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.collegeDataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(133, 217);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowTemplate.Height = 24;
            this.dataGridViewCourses.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewCourses.TabIndex = 2;
            this.dataGridViewCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourses_CellContentClick);
            // 
            // StudentAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.CoursesTable);
            this.Controls.Add(this.welcomelbl);
            this.Name = "StudentAddCourse";
            this.Text = "StudentAddCourse";
            this.Load += new System.EventHandler(this.StudentAddCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.TableLayoutPanel CoursesTable;
        private collegeDataSetTableAdapters.courses_studentsTableAdapter courses_studentsTableAdapter1;
        private collegeDataSet collegeDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private collegeDataSetTableAdapters.coursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
    }
}