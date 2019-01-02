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
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(668, 1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(132, 64);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // StudentId
            // 
            this.StudentId.Location = new System.Drawing.Point(247, 63);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(206, 31);
            this.StudentId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Desired  ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(247, 124);
            this.TextMessage.Multiline = true;
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(541, 242);
            this.TextMessage.TabIndex = 3;
            // 
            // Messages
            // 
            this.Messages.AutoSize = true;
            this.Messages.Location = new System.Drawing.Point(63, 128);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(169, 25);
            this.Messages.TabIndex = 4;
            this.Messages.Text = "Enter Message :";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(247, 372);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(109, 51);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // idFind
            // 
            this.idFind.AutoSize = true;
            this.idFind.Location = new System.Drawing.Point(510, 66);
            this.idFind.Name = "idFind";
            this.idFind.Size = new System.Drawing.Size(0, 25);
            this.idFind.TabIndex = 6;
            // 
            // SendStudent
            // 
            this.SendStudent.AutoSize = true;
            this.SendStudent.Location = new System.Drawing.Point(428, 385);
            this.SendStudent.Name = "SendStudent";
            this.SendStudent.Size = new System.Drawing.Size(0, 25);
            this.SendStudent.TabIndex = 7;
            // 
            // InstructorSendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendStudent);
            this.Controls.Add(this.idFind);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentId);
            this.Controls.Add(this.Back);
            this.Name = "InstructorSendMessage";
            this.Text = "InstructorSendMessage";
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
    }
}