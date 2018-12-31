namespace WindowsFormsApp1
{
    partial class InstructorShowStudenstInCourse
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
            this.studentincourse_dgv = new System.Windows.Forms.DataGridView();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentincourse_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // studentincourse_dgv
            // 
            this.studentincourse_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentincourse_dgv.Location = new System.Drawing.Point(26, 96);
            this.studentincourse_dgv.Name = "studentincourse_dgv";
            this.studentincourse_dgv.RowTemplate.Height = 24;
            this.studentincourse_dgv.Size = new System.Drawing.Size(762, 274);
            this.studentincourse_dgv.TabIndex = 0;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(658, 2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(141, 56);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // InstructorShowStudenstInCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.studentincourse_dgv);
            this.Name = "InstructorShowStudenstInCourse";
            this.Text = "InstructorShowStudentInCourse";
            ((System.ComponentModel.ISupportInitialize)(this.studentincourse_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentincourse_dgv;
        private System.Windows.Forms.Button back_btn;
    }
}