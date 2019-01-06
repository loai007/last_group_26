namespace WindowsFormsApp1
{
    partial class InstructorSendMessage
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
            this.StudentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextMessage = new System.Windows.Forms.TextBox();
            this.Messages = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.idFind = new System.Windows.Forms.Label();
            this.SendStudent = new System.Windows.Forms.Label();
            this.StudentBTN = new System.Windows.Forms.Button();
            this.InstructorBTN = new System.Windows.Forms.Button();
            this.ManagerBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uperpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.uperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Sitka Display", 10.2F);
            this.Back.Location = new System.Drawing.Point(624, 2);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(121, 46);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // StudentId
            // 
            this.StudentId.Location = new System.Drawing.Point(197, 445);
            this.StudentId.Margin = new System.Windows.Forms.Padding(2);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(139, 22);
            this.StudentId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 439);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Desired  ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(20, 173);
            this.TextMessage.Margin = new System.Windows.Forms.Padding(2);
            this.TextMessage.Multiline = true;
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(272, 243);
            this.TextMessage.TabIndex = 3;
            // 
            // Messages
            // 
            this.Messages.AutoSize = true;
            this.Messages.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold);
            this.Messages.Location = new System.Drawing.Point(22, 132);
            this.Messages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(143, 28);
            this.Messages.TabIndex = 4;
            this.Messages.Text = "Enter Message :";
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Location = new System.Drawing.Point(215, 481);
            this.Send.Margin = new System.Windows.Forms.Padding(2);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(95, 33);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // idFind
            // 
            this.idFind.AutoSize = true;
            this.idFind.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idFind.ForeColor = System.Drawing.Color.Red;
            this.idFind.Location = new System.Drawing.Point(336, 486);
            this.idFind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idFind.Name = "idFind";
            this.idFind.Size = new System.Drawing.Size(0, 28);
            this.idFind.TabIndex = 6;
            // 
            // SendStudent
            // 
            this.SendStudent.AutoSize = true;
            this.SendStudent.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold);
            this.SendStudent.Location = new System.Drawing.Point(299, 395);
            this.SendStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SendStudent.Name = "SendStudent";
            this.SendStudent.Size = new System.Drawing.Size(0, 28);
            this.SendStudent.TabIndex = 7;
            // 
            // StudentBTN
            // 
            this.StudentBTN.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentBTN.Location = new System.Drawing.Point(604, 386);
            this.StudentBTN.Name = "StudentBTN";
            this.StudentBTN.Size = new System.Drawing.Size(75, 39);
            this.StudentBTN.TabIndex = 70;
            this.StudentBTN.Text = "Student";
            this.StudentBTN.UseVisualStyleBackColor = true;
            this.StudentBTN.Click += new System.EventHandler(this.StudentBTN_Click);
            // 
            // InstructorBTN
            // 
            this.InstructorBTN.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorBTN.Location = new System.Drawing.Point(505, 386);
            this.InstructorBTN.Name = "InstructorBTN";
            this.InstructorBTN.Size = new System.Drawing.Size(75, 39);
            this.InstructorBTN.TabIndex = 69;
            this.InstructorBTN.Text = "Instructor";
            this.InstructorBTN.UseVisualStyleBackColor = true;
            this.InstructorBTN.Click += new System.EventHandler(this.InstructorBTN_Click);
            // 
            // ManagerBTN
            // 
            this.ManagerBTN.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerBTN.Location = new System.Drawing.Point(410, 386);
            this.ManagerBTN.Name = "ManagerBTN";
            this.ManagerBTN.Size = new System.Drawing.Size(75, 39);
            this.ManagerBTN.TabIndex = 68;
            this.ManagerBTN.Text = "Manager";
            this.ManagerBTN.UseVisualStyleBackColor = true;
            this.ManagerBTN.Click += new System.EventHandler(this.ManagerBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(343, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(392, 190);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
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
            this.uperpanel.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 58);
            this.label2.TabIndex = 4;
            this.label2.Text = "Send Message";
            // 
            // InstructorSendMessage
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
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InstructorSendMessage";
            this.Text = "InstructorSendMessage";
            this.Load += new System.EventHandler(this.InstructorSendMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.uperpanel.ResumeLayout(false);
            this.uperpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox StudentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextMessage;
        private System.Windows.Forms.Label Messages;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label idFind;
        private System.Windows.Forms.Label SendStudent;
        private System.Windows.Forms.Button StudentBTN;
        private System.Windows.Forms.Button InstructorBTN;
        private System.Windows.Forms.Button ManagerBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel uperpanel;
        private System.Windows.Forms.Label label2;
    }
}