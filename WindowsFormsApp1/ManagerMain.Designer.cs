﻿namespace WindowsFormsApp1
{
    partial class ManagerMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.deletec_btn = new System.Windows.Forms.Button();
            this.SendMessage = new System.Windows.Forms.Button();
            this.ManageeMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(24, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Course";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1020, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 77);
            this.button2.TabIndex = 51;
            this.button2.Text = "Log out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // deletec_btn
            // 
            this.deletec_btn.BackColor = System.Drawing.SystemColors.Control;
            this.deletec_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deletec_btn.Location = new System.Drawing.Point(276, 162);
            this.deletec_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deletec_btn.Name = "deletec_btn";
            this.deletec_btn.Size = new System.Drawing.Size(188, 62);
            this.deletec_btn.TabIndex = 52;
            this.deletec_btn.Text = "Delete Course";
            this.deletec_btn.UseVisualStyleBackColor = false;
            this.deletec_btn.Click += new System.EventHandler(this.deletec_btn_Click);
            // 
            // SendMessage
            // 
            this.SendMessage.BackColor = System.Drawing.SystemColors.Control;
            this.SendMessage.Location = new System.Drawing.Point(549, 162);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(178, 62);
            this.SendMessage.TabIndex = 53;
            this.SendMessage.Text = "Send Message";
            this.SendMessage.UseVisualStyleBackColor = false;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // ManageeMessage
            // 
            this.ManageeMessage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ManageeMessage.Location = new System.Drawing.Point(773, 162);
            this.ManageeMessage.Name = "ManageeMessage";
            this.ManageeMessage.Size = new System.Drawing.Size(160, 62);
            this.ManageeMessage.TabIndex = 54;
            this.ManageeMessage.Text = "Massege";
            this.ManageeMessage.UseVisualStyleBackColor = false;
            this.ManageeMessage.Click += new System.EventHandler(this.ManageeMessage_Click);
            // 
            // ManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.ManageeMessage);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.deletec_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagerMain";
            this.Text = "ManagerMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button deletec_btn;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.Button ManageeMessage;
    }
}