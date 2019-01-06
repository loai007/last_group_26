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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(600, 1);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 40);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // IdSt
            // 
            this.IdSt.AutoSize = true;
            this.IdSt.Location = new System.Drawing.Point(80, 271);
            this.IdSt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdSt.Name = "IdSt";
            this.IdSt.Size = new System.Drawing.Size(124, 17);
            this.IdSt.TabIndex = 1;
            this.IdSt.Text = "Enter Desired  ID :";
            this.IdSt.Click += new System.EventHandler(this.IdSt_Click);
            // 
            // StudentId
            // 
            this.StudentId.Location = new System.Drawing.Point(225, 266);
            this.StudentId.Margin = new System.Windows.Forms.Padding(2);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(110, 22);
            this.StudentId.TabIndex = 2;
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(48, 108);
            this.Message.Margin = new System.Windows.Forms.Padding(2);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(333, 132);
            this.Message.TabIndex = 3;
            // 
            // EnterMessage
            // 
            this.EnterMessage.AutoSize = true;
            this.EnterMessage.Location = new System.Drawing.Point(45, 76);
            this.EnterMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterMessage.Name = "EnterMessage";
            this.EnterMessage.Size = new System.Drawing.Size(111, 17);
            this.EnterMessage.TabIndex = 4;
            this.EnterMessage.Text = "Enter Message :";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(213, 322);
            this.Send.Margin = new System.Windows.Forms.Padding(2);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(62, 30);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // idFind
            // 
            this.idFind.AutoSize = true;
            this.idFind.Location = new System.Drawing.Point(335, 52);
            this.idFind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idFind.Name = "idFind";
            this.idFind.Size = new System.Drawing.Size(0, 17);
            this.idFind.TabIndex = 6;
            // 
            // SendStudent
            // 
            this.SendStudent.AutoSize = true;
            this.SendStudent.Location = new System.Drawing.Point(303, 242);
            this.SendStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SendStudent.Name = "SendStudent";
            this.SendStudent.Size = new System.Drawing.Size(0, 17);
            this.SendStudent.TabIndex = 7;
            // 
            // StudentBTN
            // 
            this.StudentBTN.Location = new System.Drawing.Point(600, 265);
            this.StudentBTN.Name = "StudentBTN";
            this.StudentBTN.Size = new System.Drawing.Size(75, 23);
            this.StudentBTN.TabIndex = 66;
            this.StudentBTN.Text = "Student";
            this.StudentBTN.UseVisualStyleBackColor = true;
            this.StudentBTN.Click += new System.EventHandler(this.StudentBTN_Click);
            // 
            // InstructorBTN
            // 
            this.InstructorBTN.Location = new System.Drawing.Point(496, 265);
            this.InstructorBTN.Name = "InstructorBTN";
            this.InstructorBTN.Size = new System.Drawing.Size(75, 23);
            this.InstructorBTN.TabIndex = 65;
            this.InstructorBTN.Text = "Instructor";
            this.InstructorBTN.UseVisualStyleBackColor = true;
            this.InstructorBTN.Click += new System.EventHandler(this.InstructorBTN_Click);
            // 
            // ManagerBTN
            // 
            this.ManagerBTN.Location = new System.Drawing.Point(399, 265);
            this.ManagerBTN.Name = "ManagerBTN";
            this.ManagerBTN.Size = new System.Drawing.Size(75, 23);
            this.ManagerBTN.TabIndex = 64;
            this.ManagerBTN.Text = "Manager";
            this.ManagerBTN.UseVisualStyleBackColor = true;
            this.ManagerBTN.Click += new System.EventHandler(this.ManagerBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(276, 150);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // ManagerSendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 421);
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
            this.Controls.Add(this.Back);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerSendMessage";
            this.Text = "ManagerSendMwssage";
            this.Load += new System.EventHandler(this.ManagerSendMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}