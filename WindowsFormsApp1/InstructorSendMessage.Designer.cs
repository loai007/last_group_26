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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(445, 1);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(88, 41);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // StudentId
            // 
            this.StudentId.Location = new System.Drawing.Point(201, 286);
            this.StudentId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(139, 22);
            this.StudentId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Desired  ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(11, 101);
            this.TextMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextMessage.Multiline = true;
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(362, 156);
            this.TextMessage.TabIndex = 3;
            // 
            // Messages
            // 
            this.Messages.AutoSize = true;
            this.Messages.Location = new System.Drawing.Point(42, 82);
            this.Messages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(111, 17);
            this.Messages.TabIndex = 4;
            this.Messages.Text = "Enter Message :";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(183, 330);
            this.Send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(73, 33);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // idFind
            // 
            this.idFind.AutoSize = true;
            this.idFind.Location = new System.Drawing.Point(340, 42);
            this.idFind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idFind.Name = "idFind";
            this.idFind.Size = new System.Drawing.Size(0, 17);
            this.idFind.TabIndex = 6;
            // 
            // SendStudent
            // 
            this.SendStudent.AutoSize = true;
            this.SendStudent.Location = new System.Drawing.Point(285, 246);
            this.SendStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SendStudent.Name = "SendStudent";
            this.SendStudent.Size = new System.Drawing.Size(0, 17);
            this.SendStudent.TabIndex = 7;
            // 
            // StudentBTN
            // 
            this.StudentBTN.Location = new System.Drawing.Point(620, 264);
            this.StudentBTN.Name = "StudentBTN";
            this.StudentBTN.Size = new System.Drawing.Size(75, 39);
            this.StudentBTN.TabIndex = 70;
            this.StudentBTN.Text = "Student";
            this.StudentBTN.UseVisualStyleBackColor = true;
            this.StudentBTN.Click += new System.EventHandler(this.StudentBTN_Click);
            // 
            // InstructorBTN
            // 
            this.InstructorBTN.Location = new System.Drawing.Point(516, 264);
            this.InstructorBTN.Name = "InstructorBTN";
            this.InstructorBTN.Size = new System.Drawing.Size(75, 39);
            this.InstructorBTN.TabIndex = 69;
            this.InstructorBTN.Text = "Instructor";
            this.InstructorBTN.UseVisualStyleBackColor = true;
            this.InstructorBTN.Click += new System.EventHandler(this.InstructorBTN_Click);
            // 
            // ManagerBTN
            // 
            this.ManagerBTN.Location = new System.Drawing.Point(419, 264);
            this.ManagerBTN.Name = "ManagerBTN";
            this.ManagerBTN.Size = new System.Drawing.Size(75, 39);
            this.ManagerBTN.TabIndex = 68;
            this.ManagerBTN.Text = "Manager";
            this.ManagerBTN.UseVisualStyleBackColor = true;
            this.ManagerBTN.Click += new System.EventHandler(this.ManagerBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(276, 166);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // InstructorSendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 431);
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
            this.Controls.Add(this.Back);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InstructorSendMessage";
            this.Text = "InstructorSendMessage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}