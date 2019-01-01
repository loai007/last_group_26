namespace WindowsFormsApp1
{
    partial class InstructorViewMessages
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromLBL = new System.Windows.Forms.Label();
            this.toLBL = new System.Windows.Forms.Label();
            this.messageLBL = new System.Windows.Forms.Label();
            this.backBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(232, 305);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "from:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Message:";
            // 
            // fromLBL
            // 
            this.fromLBL.AutoSize = true;
            this.fromLBL.Location = new System.Drawing.Point(463, 58);
            this.fromLBL.Name = "fromLBL";
            this.fromLBL.Size = new System.Drawing.Size(46, 17);
            this.fromLBL.TabIndex = 4;
            this.fromLBL.Text = "label4";
            // 
            // toLBL
            // 
            this.toLBL.AutoSize = true;
            this.toLBL.Location = new System.Drawing.Point(463, 100);
            this.toLBL.Name = "toLBL";
            this.toLBL.Size = new System.Drawing.Size(46, 17);
            this.toLBL.TabIndex = 5;
            this.toLBL.Text = "label5";
            // 
            // messageLBL
            // 
            this.messageLBL.AutoSize = true;
            this.messageLBL.Location = new System.Drawing.Point(463, 145);
            this.messageLBL.Name = "messageLBL";
            this.messageLBL.Size = new System.Drawing.Size(46, 17);
            this.messageLBL.TabIndex = 6;
            this.messageLBL.Text = "label6";
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(664, 12);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(124, 52);
            this.backBTN.TabIndex = 62;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // InstructorViewMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.messageLBL);
            this.Controls.Add(this.toLBL);
            this.Controls.Add(this.fromLBL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "InstructorViewMessages";
            this.Text = "InstructorViewMessages";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fromLBL;
        private System.Windows.Forms.Label toLBL;
        private System.Windows.Forms.Label messageLBL;
        private System.Windows.Forms.Button backBTN;
    }
}