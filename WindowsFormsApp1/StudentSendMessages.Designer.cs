﻿namespace WindowsFormsApp1
{
    partial class StudentSendMessages
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
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxun = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.sendBTN = new System.Windows.Forms.Button();
            this.messageLBL = new System.Windows.Forms.Label();
            this.uperpanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ManagerBTN = new System.Windows.Forms.Button();
            this.InstructorBTN = new System.Windows.Forms.Button();
            this.StudentBTN = new System.Windows.Forms.Button();
            this.uperpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Sitka Display", 10.2F);
            this.Back.Location = new System.Drawing.Point(625, 2);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(121, 46);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Message to:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Message:";
            // 
            // textBoxun
            // 
            this.textBoxun.Location = new System.Drawing.Point(489, 398);
            this.textBoxun.Name = "textBoxun";
            this.textBoxun.Size = new System.Drawing.Size(100, 22);
            this.textBoxun.TabIndex = 10;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(27, 149);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(278, 271);
            this.textBoxMessage.TabIndex = 11;
            // 
            // sendBTN
            // 
            this.sendBTN.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBTN.Location = new System.Drawing.Point(489, 441);
            this.sendBTN.Name = "sendBTN";
            this.sendBTN.Size = new System.Drawing.Size(85, 35);
            this.sendBTN.TabIndex = 12;
            this.sendBTN.Text = "send";
            this.sendBTN.UseVisualStyleBackColor = true;
            this.sendBTN.Click += new System.EventHandler(this.sendBTN_Click);
            // 
            // messageLBL
            // 
            this.messageLBL.AutoSize = true;
            this.messageLBL.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLBL.Location = new System.Drawing.Point(511, 479);
            this.messageLBL.Name = "messageLBL";
            this.messageLBL.Size = new System.Drawing.Size(48, 21);
            this.messageLBL.TabIndex = 13;
            this.messageLBL.Text = "label3";
            // 
            // uperpanel
            // 
            this.uperpanel.BackColor = System.Drawing.Color.LightGreen;
            this.uperpanel.Controls.Add(this.label3);
            this.uperpanel.Controls.Add(this.Back);
            this.uperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uperpanel.Location = new System.Drawing.Point(0, 0);
            this.uperpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uperpanel.Name = "uperpanel";
            this.uperpanel.Size = new System.Drawing.Size(747, 101);
            this.uperpanel.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Send Message";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(331, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(404, 150);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // ManagerBTN
            // 
            this.ManagerBTN.Location = new System.Drawing.Point(392, 360);
            this.ManagerBTN.Name = "ManagerBTN";
            this.ManagerBTN.Size = new System.Drawing.Size(75, 23);
            this.ManagerBTN.TabIndex = 60;
            this.ManagerBTN.Text = "Manager";
            this.ManagerBTN.UseVisualStyleBackColor = true;
            this.ManagerBTN.Click += new System.EventHandler(this.ManagerBTN_Click);
            // 
            // InstructorBTN
            // 
            this.InstructorBTN.Location = new System.Drawing.Point(489, 360);
            this.InstructorBTN.Name = "InstructorBTN";
            this.InstructorBTN.Size = new System.Drawing.Size(75, 23);
            this.InstructorBTN.TabIndex = 61;
            this.InstructorBTN.Text = "Instructor";
            this.InstructorBTN.UseVisualStyleBackColor = true;
            this.InstructorBTN.Click += new System.EventHandler(this.InstructorBTN_Click);
            // 
            // StudentBTN
            // 
            this.StudentBTN.Location = new System.Drawing.Point(593, 360);
            this.StudentBTN.Name = "StudentBTN";
            this.StudentBTN.Size = new System.Drawing.Size(75, 23);
            this.StudentBTN.TabIndex = 62;
            this.StudentBTN.Text = "Student";
            this.StudentBTN.UseVisualStyleBackColor = true;
            this.StudentBTN.Click += new System.EventHandler(this.StudentBTN_Click);
            // 
            // StudentSendMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 549);
            this.Controls.Add(this.StudentBTN);
            this.Controls.Add(this.InstructorBTN);
            this.Controls.Add(this.ManagerBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uperpanel);
            this.Controls.Add(this.messageLBL);
            this.Controls.Add(this.sendBTN);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentSendMessages";
            this.Text = "StudentSendMessages";
            this.uperpanel.ResumeLayout(false);
            this.uperpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxun;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button sendBTN;
        private System.Windows.Forms.Label messageLBL;
        private System.Windows.Forms.Panel uperpanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ManagerBTN;
        private System.Windows.Forms.Button InstructorBTN;
        private System.Windows.Forms.Button StudentBTN;
    }
}