﻿namespace WindowsFormsApp1
{
    partial class StudentSendRequests
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.InstructorBTN = new System.Windows.Forms.Button();
            this.ManagerBTN = new System.Windows.Forms.Button();
            this.fromLBL = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.messageTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sendBTN = new System.Windows.Forms.Button();
            this.messageLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uperpanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.uperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBTN
            // 
            this.backBTN.Font = new System.Drawing.Font("Sitka Display", 10.2F);
            this.backBTN.Location = new System.Drawing.Point(467, 2);
            this.backBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(91, 37);
            this.backBTN.TabIndex = 0;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(9, 136);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(509, 122);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // InstructorBTN
            // 
            this.InstructorBTN.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorBTN.Location = new System.Drawing.Point(21, 314);
            this.InstructorBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InstructorBTN.Name = "InstructorBTN";
            this.InstructorBTN.Size = new System.Drawing.Size(65, 29);
            this.InstructorBTN.TabIndex = 2;
            this.InstructorBTN.Text = "Instructors";
            this.InstructorBTN.UseVisualStyleBackColor = true;
            this.InstructorBTN.Click += new System.EventHandler(this.InstructorBTN_Click);
            // 
            // ManagerBTN
            // 
            this.ManagerBTN.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerBTN.Location = new System.Drawing.Point(102, 314);
            this.ManagerBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagerBTN.Name = "ManagerBTN";
            this.ManagerBTN.Size = new System.Drawing.Size(65, 29);
            this.ManagerBTN.TabIndex = 3;
            this.ManagerBTN.Text = "Managers";
            this.ManagerBTN.UseVisualStyleBackColor = true;
            this.ManagerBTN.Click += new System.EventHandler(this.ManagerBTN_Click);
            // 
            // fromLBL
            // 
            this.fromLBL.AutoSize = true;
            this.fromLBL.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLBL.Location = new System.Drawing.Point(21, 273);
            this.fromLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fromLBL.Name = "fromLBL";
            this.fromLBL.Size = new System.Drawing.Size(115, 21);
            this.fromLBL.TabIndex = 4;
            this.fromLBL.Text = "Request From :  ";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(353, 273);
            this.idTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(76, 20);
            this.idTB.TabIndex = 5;
            // 
            // messageTB
            // 
            this.messageTB.Location = new System.Drawing.Point(269, 303);
            this.messageTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.messageTB.Multiline = true;
            this.messageTB.Name = "messageTB";
            this.messageTB.Size = new System.Drawing.Size(194, 134);
            this.messageTB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Request:";
            // 
            // sendBTN
            // 
            this.sendBTN.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBTN.Location = new System.Drawing.Point(482, 314);
            this.sendBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendBTN.Name = "sendBTN";
            this.sendBTN.Size = new System.Drawing.Size(62, 29);
            this.sendBTN.TabIndex = 9;
            this.sendBTN.Text = "Send";
            this.sendBTN.UseVisualStyleBackColor = true;
            this.sendBTN.Click += new System.EventHandler(this.sendBTN_Click);
            // 
            // messageLBL
            // 
            this.messageLBL.AutoSize = true;
            this.messageLBL.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLBL.Location = new System.Drawing.Point(493, 366);
            this.messageLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLBL.Name = "messageLBL";
            this.messageLBL.Size = new System.Drawing.Size(38, 18);
            this.messageLBL.TabIndex = 10;
            this.messageLBL.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "who do you want to request from :";
            // 
            // uperpanel
            // 
            this.uperpanel.BackColor = System.Drawing.Color.LightGreen;
            this.uperpanel.Controls.Add(this.label4);
            this.uperpanel.Controls.Add(this.backBTN);
            this.uperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uperpanel.Location = new System.Drawing.Point(0, 0);
            this.uperpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uperpanel.Name = "uperpanel";
            this.uperpanel.Size = new System.Drawing.Size(560, 82);
            this.uperpanel.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 47);
            this.label4.TabIndex = 4;
            this.label4.Text = "Send Requests";
            // 
            // StudentSendRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 446);
            this.Controls.Add(this.uperpanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.messageLBL);
            this.Controls.Add(this.sendBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.fromLBL);
            this.Controls.Add(this.ManagerBTN);
            this.Controls.Add(this.InstructorBTN);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentSendRequests";
            this.Text = "StudentSend";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.uperpanel.ResumeLayout(false);
            this.uperpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button InstructorBTN;
        private System.Windows.Forms.Button ManagerBTN;
        private System.Windows.Forms.Label fromLBL;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox messageTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendBTN;
        private System.Windows.Forms.Label messageLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel uperpanel;
        private System.Windows.Forms.Label label4;
    }
}