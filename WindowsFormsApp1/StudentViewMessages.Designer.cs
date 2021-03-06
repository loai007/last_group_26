﻿namespace WindowsFormsApp1
{
    partial class StudentViewMessages
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
            this.dataGridMessage = new System.Windows.Forms.DataGridView();
            this.messageLBL = new System.Windows.Forms.Label();
            this.fromLBL = new System.Windows.Forms.Label();
            this.toLBL = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.uperpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessage)).BeginInit();
            this.uperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridMessage
            // 
            this.dataGridMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMessage.Location = new System.Drawing.Point(33, 126);
            this.dataGridMessage.Name = "dataGridMessage";
            this.dataGridMessage.RowTemplate.Height = 24;
            this.dataGridMessage.Size = new System.Drawing.Size(283, 384);
            this.dataGridMessage.TabIndex = 10;
            this.dataGridMessage.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridMessage_RowHeaderMouseClick_1);
            // 
            // messageLBL
            // 
            this.messageLBL.AutoSize = true;
            this.messageLBL.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLBL.Location = new System.Drawing.Point(459, 245);
            this.messageLBL.Name = "messageLBL";
            this.messageLBL.Size = new System.Drawing.Size(48, 21);
            this.messageLBL.TabIndex = 9;
            this.messageLBL.Text = "label3";
            // 
            // fromLBL
            // 
            this.fromLBL.AutoSize = true;
            this.fromLBL.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLBL.Location = new System.Drawing.Point(459, 215);
            this.fromLBL.Name = "fromLBL";
            this.fromLBL.Size = new System.Drawing.Size(48, 21);
            this.fromLBL.TabIndex = 8;
            this.fromLBL.Text = "label2";
            // 
            // toLBL
            // 
            this.toLBL.AutoSize = true;
            this.toLBL.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLBL.Location = new System.Drawing.Point(459, 185);
            this.toLBL.Name = "toLBL";
            this.toLBL.Size = new System.Drawing.Size(46, 21);
            this.toLBL.TabIndex = 7;
            this.toLBL.Text = "label1";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Sitka Display", 10.2F);
            this.Back.Location = new System.Drawing.Point(624, 2);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(121, 46);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
            // 
            // uperpanel
            // 
            this.uperpanel.BackColor = System.Drawing.Color.LightGreen;
            this.uperpanel.Controls.Add(this.label2);
            this.uperpanel.Controls.Add(this.Back);
            this.uperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uperpanel.Location = new System.Drawing.Point(0, 0);
            this.uperpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uperpanel.Name = "uperpanel";
            this.uperpanel.Size = new System.Drawing.Size(747, 101);
            this.uperpanel.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 58);
            this.label2.TabIndex = 4;
            this.label2.Text = "Messages Box";
            // 
            // StudentViewMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 549);
            this.Controls.Add(this.uperpanel);
            this.Controls.Add(this.dataGridMessage);
            this.Controls.Add(this.messageLBL);
            this.Controls.Add(this.fromLBL);
            this.Controls.Add(this.toLBL);
            this.Name = "StudentViewMessages";
            this.Text = "StudentViewMessages";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessage)).EndInit();
            this.uperpanel.ResumeLayout(false);
            this.uperpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMessage;
        private System.Windows.Forms.Label messageLBL;
        private System.Windows.Forms.Label fromLBL;
        private System.Windows.Forms.Label toLBL;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel uperpanel;
        private System.Windows.Forms.Label label2;
    }
}