namespace WindowsFormsApp1
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
            this.SuspendLayout();
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(698, -4);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(103, 62);
            this.backBTN.TabIndex = 0;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // StudentSendRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBTN);
            this.Name = "StudentSendRequests";
            this.Text = "StudentSend";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBTN;
    }
}