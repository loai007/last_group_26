namespace WindowsFormsApp1
{
    partial class ManagerAddStudent
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
            this.back_btn = new System.Windows.Forms.Button();
            this.id_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firrstname_txtbox = new System.Windows.Forms.TextBox();
            this.lastname_txtbox = new System.Windows.Forms.TextBox();
            this.phonenumber_txtbox = new System.Windows.Forms.TextBox();
            this.department_txtbox = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.error_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.uperpanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.uperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Sitka Display", 9F);
            this.back_btn.Location = new System.Drawing.Point(623, 3);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(121, 46);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // id_txtbox
            // 
            this.id_txtbox.Location = new System.Drawing.Point(205, 176);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(116, 22);
            this.id_txtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Department :";
            // 
            // firrstname_txtbox
            // 
            this.firrstname_txtbox.Location = new System.Drawing.Point(205, 280);
            this.firrstname_txtbox.Name = "firrstname_txtbox";
            this.firrstname_txtbox.Size = new System.Drawing.Size(116, 22);
            this.firrstname_txtbox.TabIndex = 7;
            // 
            // lastname_txtbox
            // 
            this.lastname_txtbox.Location = new System.Drawing.Point(205, 336);
            this.lastname_txtbox.Name = "lastname_txtbox";
            this.lastname_txtbox.Size = new System.Drawing.Size(116, 22);
            this.lastname_txtbox.TabIndex = 8;
            // 
            // phonenumber_txtbox
            // 
            this.phonenumber_txtbox.Location = new System.Drawing.Point(205, 389);
            this.phonenumber_txtbox.Name = "phonenumber_txtbox";
            this.phonenumber_txtbox.Size = new System.Drawing.Size(116, 22);
            this.phonenumber_txtbox.TabIndex = 9;
            // 
            // department_txtbox
            // 
            this.department_txtbox.Location = new System.Drawing.Point(205, 440);
            this.department_txtbox.Name = "department_txtbox";
            this.department_txtbox.Size = new System.Drawing.Size(116, 22);
            this.department_txtbox.TabIndex = 10;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(487, 241);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(87, 34);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_lbl.Location = new System.Drawing.Point(482, 308);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(55, 28);
            this.error_lbl.TabIndex = 12;
            this.error_lbl.Text = "error";
            this.error_lbl.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "PassWord :";
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(205, 226);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(116, 22);
            this.password_txtbox.TabIndex = 14;
            // 
            // uperpanel
            // 
            this.uperpanel.BackColor = System.Drawing.Color.LightGreen;
            this.uperpanel.Controls.Add(this.label7);
            this.uperpanel.Controls.Add(this.back_btn);
            this.uperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uperpanel.Location = new System.Drawing.Point(0, 0);
            this.uperpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uperpanel.Name = "uperpanel";
            this.uperpanel.Size = new System.Drawing.Size(747, 101);
            this.uperpanel.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(202, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 58);
            this.label7.TabIndex = 4;
            this.label7.Text = "Add New Student";
            // 
            // ManagerAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 549);
            this.Controls.Add(this.uperpanel);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.department_txtbox);
            this.Controls.Add(this.phonenumber_txtbox);
            this.Controls.Add(this.lastname_txtbox);
            this.Controls.Add(this.firrstname_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_txtbox);
            this.Name = "ManagerAddStudent";
            this.Text = "ManagerAddStudent";
            this.Load += new System.EventHandler(this.ManagerAddStudent_Load);
            this.uperpanel.ResumeLayout(false);
            this.uperpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox id_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firrstname_txtbox;
        private System.Windows.Forms.TextBox lastname_txtbox;
        private System.Windows.Forms.TextBox phonenumber_txtbox;
        private System.Windows.Forms.TextBox department_txtbox;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label error_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Panel uperpanel;
        private System.Windows.Forms.Label label7;
    }
}