namespace WindowsFormsApp1
{
    partial class InstructorViewRequests
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
            this.errorLBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusLBL = new System.Windows.Forms.Label();
            this.requestLBL = new System.Windows.Forms.Label();
            this.toLBL = new System.Windows.Forms.Label();
            this.fromLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.backBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLBL
            // 
            this.errorLBL.AutoSize = true;
            this.errorLBL.Location = new System.Drawing.Point(379, 39);
            this.errorLBL.Name = "errorLBL";
            this.errorLBL.Size = new System.Drawing.Size(60, 17);
            this.errorLBL.TabIndex = 29;
            this.errorLBL.Text = "request:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "status:";
            // 
            // statusLBL
            // 
            this.statusLBL.AutoSize = true;
            this.statusLBL.Location = new System.Drawing.Point(393, 136);
            this.statusLBL.Name = "statusLBL";
            this.statusLBL.Size = new System.Drawing.Size(46, 17);
            this.statusLBL.TabIndex = 27;
            this.statusLBL.Text = "label1";
            // 
            // requestLBL
            // 
            this.requestLBL.AutoSize = true;
            this.requestLBL.Location = new System.Drawing.Point(393, 201);
            this.requestLBL.Name = "requestLBL";
            this.requestLBL.Size = new System.Drawing.Size(46, 17);
            this.requestLBL.TabIndex = 26;
            this.requestLBL.Text = "label3";
            // 
            // toLBL
            // 
            this.toLBL.AutoSize = true;
            this.toLBL.Location = new System.Drawing.Point(528, 88);
            this.toLBL.Name = "toLBL";
            this.toLBL.Size = new System.Drawing.Size(46, 17);
            this.toLBL.TabIndex = 25;
            this.toLBL.Text = "label2";
            // 
            // fromLBL
            // 
            this.fromLBL.AutoSize = true;
            this.fromLBL.Location = new System.Drawing.Point(387, 88);
            this.fromLBL.Name = "fromLBL";
            this.fromLBL.Size = new System.Drawing.Size(46, 17);
            this.fromLBL.TabIndex = 24;
            this.fromLBL.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "request:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "From:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(240, 411);
            this.dataGridView.TabIndex = 20;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(713, 1);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(75, 23);
            this.backBTN.TabIndex = 17;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // InstructorViewRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLBL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusLBL);
            this.Controls.Add(this.requestLBL);
            this.Controls.Add(this.toLBL);
            this.Controls.Add(this.fromLBL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.backBTN);
            this.Name = "InstructorViewRequests";
            this.Text = "InstructorViewRequests";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLBL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label statusLBL;
        private System.Windows.Forms.Label requestLBL;
        private System.Windows.Forms.Label toLBL;
        private System.Windows.Forms.Label fromLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button backBTN;
    }
}