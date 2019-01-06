namespace WindowsFormsApp1
{
    partial class ManagerViewMessage
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
            this.components = new System.ComponentModel.Container();
            this.Back = new System.Windows.Forms.Button();
            this.collegeDataSet = new WindowsFormsApp1.collegeDataSet();
            this.collegeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toLBL = new System.Windows.Forms.Label();
            this.fromLBL = new System.Windows.Forms.Label();
            this.messageLBL = new System.Windows.Forms.Label();
            this.dataGridMessage = new System.Windows.Forms.DataGridView();
            this.uperpanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessage)).BeginInit();
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
            // collegeDataSet
            // 
            this.collegeDataSet.DataSetName = "collegeDataSet";
            this.collegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collegeDataSetBindingSource
            // 
            this.collegeDataSetBindingSource.DataSource = this.collegeDataSet;
            this.collegeDataSetBindingSource.Position = 0;
            // 
            // toLBL
            // 
            this.toLBL.AutoSize = true;
            this.toLBL.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLBL.Location = new System.Drawing.Point(348, 159);
            this.toLBL.Name = "toLBL";
            this.toLBL.Size = new System.Drawing.Size(57, 28);
            this.toLBL.TabIndex = 2;
            this.toLBL.Text = "label1";
            // 
            // fromLBL
            // 
            this.fromLBL.AutoSize = true;
            this.fromLBL.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLBL.Location = new System.Drawing.Point(348, 214);
            this.fromLBL.Name = "fromLBL";
            this.fromLBL.Size = new System.Drawing.Size(60, 28);
            this.fromLBL.TabIndex = 3;
            this.fromLBL.Text = "label2";
            // 
            // messageLBL
            // 
            this.messageLBL.AutoSize = true;
            this.messageLBL.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLBL.Location = new System.Drawing.Point(348, 267);
            this.messageLBL.Name = "messageLBL";
            this.messageLBL.Size = new System.Drawing.Size(60, 28);
            this.messageLBL.TabIndex = 4;
            this.messageLBL.Text = "label3";
            // 
            // dataGridMessage
            // 
            this.dataGridMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMessage.Location = new System.Drawing.Point(12, 121);
            this.dataGridMessage.Name = "dataGridMessage";
            this.dataGridMessage.RowTemplate.Height = 24;
            this.dataGridMessage.Size = new System.Drawing.Size(260, 387);
            this.dataGridMessage.TabIndex = 5;
            this.dataGridMessage.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridMessage_RowHeaderMouseClick);
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
            this.uperpanel.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 58);
            this.label9.TabIndex = 4;
            this.label9.Text = "Message Box";
            // 
            // ManagerViewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 549);
            this.Controls.Add(this.uperpanel);
            this.Controls.Add(this.dataGridMessage);
            this.Controls.Add(this.messageLBL);
            this.Controls.Add(this.fromLBL);
            this.Controls.Add(this.toLBL);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerViewMessage";
            this.Text = "ManagerMessage";
            this.Load += new System.EventHandler(this.ManagerViewMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessage)).EndInit();
            this.uperpanel.ResumeLayout(false);
            this.uperpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.BindingSource collegeDataSetBindingSource;
        private collegeDataSet collegeDataSet;
        private System.Windows.Forms.Label toLBL;
        private System.Windows.Forms.Label fromLBL;
        private System.Windows.Forms.Label messageLBL;
        private System.Windows.Forms.DataGridView dataGridMessage;
        private System.Windows.Forms.Panel uperpanel;
        private System.Windows.Forms.Label label9;
    }
}