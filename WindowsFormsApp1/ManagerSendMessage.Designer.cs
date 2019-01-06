namespace WindowsFormsApp1
{
    partial class ManagerSendMessage
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
            this.IdSt = new System.Windows.Forms.Label();
            this.StudentId = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.TextBox();
            this.EnterMessage = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.idFind = new System.Windows.Forms.Label();
            this.SendStudent = new System.Windows.Forms.Label();
            this.StudentBTN = new System.Windows.Forms.Button();
            this.InstructorBTN = new System.Windows.Forms.Button();
            this.ManagerBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uperpanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.uperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Sitka Display", 10.2F);
            this.Back.Location = new System.Drawing.Point(623, 2);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(121, 46);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // IdSt
            // 
            this.IdSt.AutoSize = true;
            this.IdSt.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdSt.Location = new System.Drawing.Point(293, 447);
            this.IdSt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdSt.Name = "IdSt";
            this.IdSt.Size = new System.Drawing.Size(163, 28);
            this.IdSt.TabIndex = 1;
            this.IdSt.Text = "Enter Desired  ID :";
            this.IdSt.Click += new System.EventHandler(this.IdSt_Click);
            // 
            // StudentId
            // 
            this.StudentId.Location = new System.Drawing.Point(475, 447);
            this.StudentId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(110, 22);
            this.StudentId.TabIndex = 2;
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(27, 192);
            this.Message.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(251, 222);
            this.Message.TabIndex = 3;
            // 
            // EnterMessage
            // 
            this.EnterMessage.AutoSize = true;
            this.EnterMessage.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterMessage.Location = new System.Drawing.Point(22, 135);
            this.EnterMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterMessage.Name = "EnterMessage";
            this.EnterMessage.Size = new System.Drawing.Size(143, 28);
            this.EnterMessage.TabIndex = 4;
            this.EnterMessage.Text = "Enter Message :";
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Location = new System.Drawing.Point(481, 489);
            this.Send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(85, 36);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // idFind
            // 
            this.idFind.AutoSize = true;
            this.idFind.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idFind.Location = new System.Drawing.Point(606, 496);
            this.idFind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idFind.Name = "idFind";
            this.idFind.Size = new System.Drawing.Size(0, 24);
            this.idFind.TabIndex = 6;
            // 
            // SendStudent
            // 
            this.SendStudent.AutoSize = true;
            this.SendStudent.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendStudent.Location = new System.Drawing.Point(477, 414);
            this.SendStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SendStudent.Name = "SendStudent";
            this.SendStudent.Size = new System.Drawing.Size(0, 24);
            this.SendStudent.TabIndex = 7;
            // 
            // StudentBTN
            // 
            this.StudentBTN.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentBTN.Location = new System.Drawing.Point(592, 354);
            this.StudentBTN.Name = "StudentBTN";
            this.StudentBTN.Size = new System.Drawing.Size(75, 40);
            this.StudentBTN.TabIndex = 66;
            this.StudentBTN.Text = "Student";
            this.StudentBTN.UseVisualStyleBackColor = true;
            this.StudentBTN.Click += new System.EventHandler(this.StudentBTN_Click);
            // 
            // InstructorBTN
            // 
            this.InstructorBTN.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorBTN.Location = new System.Drawing.Point(488, 354);
            this.InstructorBTN.Name = "InstructorBTN";
            this.InstructorBTN.Size = new System.Drawing.Size(88, 40);
            this.InstructorBTN.TabIndex = 65;
            this.InstructorBTN.Text = "Instructor";
            this.InstructorBTN.UseVisualStyleBackColor = true;
            this.InstructorBTN.Click += new System.EventHandler(this.InstructorBTN_Click);
            // 
            // ManagerBTN
            // 
            this.ManagerBTN.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerBTN.Location = new System.Drawing.Point(391, 354);
            this.ManagerBTN.Name = "ManagerBTN";
            this.ManagerBTN.Size = new System.Drawing.Size(75, 40);
            this.ManagerBTN.TabIndex = 64;
            this.ManagerBTN.Text = "Manager";
            this.ManagerBTN.UseVisualStyleBackColor = true;
            this.ManagerBTN.Click += new System.EventHandler(this.ManagerBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(407, 142);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // uperpanel
            // 
            this.uperpanel.BackColor = System.Drawing.Color.LightGreen;
            this.uperpanel.Controls.Add(this.label9);
            this.uperpanel.Controls.Add(this.Back);
            this.uperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uperpanel.Location = new System.Drawing.Point(0, 0);
            this.uperpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uperpanel.Name = "uperpanel";
            this.uperpanel.Size = new System.Drawing.Size(747, 101);
            this.uperpanel.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(241, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 58);
            this.label9.TabIndex = 4;
            this.label9.Text = "Send Message";
            // 
            // ManagerSendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 549);
            this.Controls.Add(this.uperpanel);
            this.Controls.Add(this.StudentBTN);
            this.Controls.Add(this.InstructorBTN);
            this.Controls.Add(this.ManagerBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SendStudent);
            this.Controls.Add(this.idFind);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.EnterMessage);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.StudentId);
            this.Controls.Add(this.IdSt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerSendMessage";
            this.Text = "ManagerSendMessage";
            this.Load += new System.EventHandler(this.ManagerSendMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.uperpanel.ResumeLayout(false);
            this.uperpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label IdSt;
        private System.Windows.Forms.TextBox StudentId;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Label EnterMessage;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label idFind;
        private System.Windows.Forms.Label SendStudent;
        private System.Windows.Forms.Button StudentBTN;
        private System.Windows.Forms.Button InstructorBTN;
        private System.Windows.Forms.Button ManagerBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel uperpanel;
        private System.Windows.Forms.Label label9;
    }
}