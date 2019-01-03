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
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(645, 18);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(92, 26);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // id_txtbox
            // 
            this.id_txtbox.Location = new System.Drawing.Point(153, 61);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(116, 22);
            this.id_txtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Department :";
            // 
            // firrstname_txtbox
            // 
            this.firrstname_txtbox.Location = new System.Drawing.Point(153, 157);
            this.firrstname_txtbox.Name = "firrstname_txtbox";
            this.firrstname_txtbox.Size = new System.Drawing.Size(116, 22);
            this.firrstname_txtbox.TabIndex = 7;
            // 
            // lastname_txtbox
            // 
            this.lastname_txtbox.Location = new System.Drawing.Point(153, 203);
            this.lastname_txtbox.Name = "lastname_txtbox";
            this.lastname_txtbox.Size = new System.Drawing.Size(116, 22);
            this.lastname_txtbox.TabIndex = 8;
            // 
            // phonenumber_txtbox
            // 
            this.phonenumber_txtbox.Location = new System.Drawing.Point(153, 248);
            this.phonenumber_txtbox.Name = "phonenumber_txtbox";
            this.phonenumber_txtbox.Size = new System.Drawing.Size(116, 22);
            this.phonenumber_txtbox.TabIndex = 9;
            // 
            // department_txtbox
            // 
            this.department_txtbox.Location = new System.Drawing.Point(153, 288);
            this.department_txtbox.Name = "department_txtbox";
            this.department_txtbox.Size = new System.Drawing.Size(116, 22);
            this.department_txtbox.TabIndex = 10;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(158, 352);
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
            this.error_lbl.Location = new System.Drawing.Point(130, 412);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(39, 17);
            this.error_lbl.TabIndex = 12;
            this.error_lbl.Text = "error";
            this.error_lbl.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "PassWord :";
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(153, 105);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(116, 22);
            this.password_txtbox.TabIndex = 14;
            // 
            // ManagerAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 549);
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
            this.Controls.Add(this.back_btn);
            this.Name = "ManagerAddStudent";
            this.Text = "ManagerAddStudent";
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
    }
}