namespace WindowsFormsApp1
{
    partial class InstructorAnswerRequests
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
            this.backBTN = new System.Windows.Forms.Button();
            this.approveBTN = new System.Windows.Forms.Button();
            this.DenyBTN = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusLBL = new System.Windows.Forms.Label();
            this.requestLBL = new System.Windows.Forms.Label();
            this.toLBL = new System.Windows.Forms.Label();
            this.fromLBL = new System.Windows.Forms.Label();
            this.errorLBL = new System.Windows.Forms.Label();
            this.uperpanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.uperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBTN
            // 
            this.backBTN.Font = new System.Drawing.Font("Sitka Display", 10.2F);
            this.backBTN.Location = new System.Drawing.Point(623, 3);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(121, 46);
            this.backBTN.TabIndex = 0;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // approveBTN
            // 
            this.approveBTN.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveBTN.Location = new System.Drawing.Point(531, 327);
            this.approveBTN.Name = "approveBTN";
            this.approveBTN.Size = new System.Drawing.Size(75, 33);
            this.approveBTN.TabIndex = 1;
            this.approveBTN.Text = "Approve";
            this.approveBTN.UseVisualStyleBackColor = true;
            this.approveBTN.Click += new System.EventHandler(this.approveBTN_Click);
            // 
            // DenyBTN
            // 
            this.DenyBTN.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DenyBTN.Location = new System.Drawing.Point(633, 327);
            this.DenyBTN.Name = "DenyBTN";
            this.DenyBTN.Size = new System.Drawing.Size(75, 33);
            this.DenyBTN.TabIndex = 2;
            this.DenyBTN.Text = "Deny";
            this.DenyBTN.UseVisualStyleBackColor = true;
            this.DenyBTN.Click += new System.EventHandler(this.DenyBTN_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 214);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(256, 302);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "From :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Request :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "To :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Status :";
            // 
            // statusLBL
            // 
            this.statusLBL.AutoSize = true;
            this.statusLBL.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLBL.Location = new System.Drawing.Point(628, 263);
            this.statusLBL.Name = "statusLBL";
            this.statusLBL.Size = new System.Drawing.Size(55, 28);
            this.statusLBL.TabIndex = 14;
            this.statusLBL.Text = "label1";
            // 
            // requestLBL
            // 
            this.requestLBL.AutoSize = true;
            this.requestLBL.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestLBL.Location = new System.Drawing.Point(420, 387);
            this.requestLBL.Name = "requestLBL";
            this.requestLBL.Size = new System.Drawing.Size(57, 28);
            this.requestLBL.TabIndex = 13;
            this.requestLBL.Text = "label3";
            // 
            // toLBL
            // 
            this.toLBL.AutoSize = true;
            this.toLBL.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLBL.Location = new System.Drawing.Point(420, 332);
            this.toLBL.Name = "toLBL";
            this.toLBL.Size = new System.Drawing.Size(57, 28);
            this.toLBL.TabIndex = 12;
            this.toLBL.Text = "label2";
            // 
            // fromLBL
            // 
            this.fromLBL.AutoSize = true;
            this.fromLBL.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLBL.Location = new System.Drawing.Point(420, 263);
            this.fromLBL.Name = "fromLBL";
            this.fromLBL.Size = new System.Drawing.Size(55, 28);
            this.fromLBL.TabIndex = 11;
            this.fromLBL.Text = "label1";
            // 
            // errorLBL
            // 
            this.errorLBL.AutoSize = true;
            this.errorLBL.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLBL.Location = new System.Drawing.Point(332, 214);
            this.errorLBL.Name = "errorLBL";
            this.errorLBL.Size = new System.Drawing.Size(72, 28);
            this.errorLBL.TabIndex = 16;
            this.errorLBL.Text = "request:";
            // 
            // uperpanel
            // 
            this.uperpanel.BackColor = System.Drawing.Color.LightGreen;
            this.uperpanel.Controls.Add(this.label5);
            this.uperpanel.Controls.Add(this.backBTN);
            this.uperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uperpanel.Location = new System.Drawing.Point(0, 0);
            this.uperpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uperpanel.Name = "uperpanel";
            this.uperpanel.Size = new System.Drawing.Size(747, 101);
            this.uperpanel.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 58);
            this.label5.TabIndex = 4;
            this.label5.Text = "Answer Requests";
            // 
            // InstructorAnswerRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 549);
            this.Controls.Add(this.uperpanel);
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
            this.Controls.Add(this.DenyBTN);
            this.Controls.Add(this.approveBTN);
            this.Name = "InstructorAnswerRequests";
            this.Text = "InstructorAnswerRequests";
            this.Load += new System.EventHandler(this.InstructorAnswerRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.uperpanel.ResumeLayout(false);
            this.uperpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Button approveBTN;
        private System.Windows.Forms.Button DenyBTN;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label statusLBL;
        private System.Windows.Forms.Label requestLBL;
        private System.Windows.Forms.Label toLBL;
        private System.Windows.Forms.Label fromLBL;
        private System.Windows.Forms.Label errorLBL;
        private System.Windows.Forms.Panel uperpanel;
        private System.Windows.Forms.Label label5;
    }
}