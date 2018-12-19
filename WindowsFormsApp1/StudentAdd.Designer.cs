namespace WindowsFormsApp1
{
    partial class StudentAdd
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
            this.textNCu = new System.Windows.Forms.TextBox();
            this.NCu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNCu
            // 
            this.textNCu.Location = new System.Drawing.Point(316, 137);
            this.textNCu.Multiline = true;
            this.textNCu.Name = "textNCu";
            this.textNCu.Size = new System.Drawing.Size(174, 45);
            this.textNCu.TabIndex = 0;
            // 
            // NCu
            // 
            this.NCu.AutoSize = true;
            this.NCu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NCu.Location = new System.Drawing.Point(146, 140);
            this.NCu.Name = "NCu";
            this.NCu.Size = new System.Drawing.Size(136, 25);
            this.NCu.TabIndex = 1;
            this.NCu.Text = "name course";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(343, 231);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(110, 42);
            this.Add.TabIndex = 3;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // StudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 494);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NCu);
            this.Controls.Add(this.textNCu);
            this.Name = "StudentAdd";
            this.Text = "StudentAdd";
            this.Load += new System.EventHandler(this.StudentAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNCu;
        private System.Windows.Forms.Label NCu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add;
    }
}