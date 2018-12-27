namespace WindowsFormsApp1
{
    partial class ManagerMessage
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
            this.Message = new System.Windows.Forms.Label();
            this.collegeDataSet = new WindowsFormsApp1.collegeDataSet();
            this.collegeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.Messages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(977, -1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(116, 61);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(65, 101);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(123, 25);
            this.Message.TabIndex = 1;
            this.Message.Text = "Messages :";
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
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(185, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(898, 395);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Messages
            // 
            this.Messages.Location = new System.Drawing.Point(220, 518);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(175, 39);
            this.Messages.TabIndex = 3;
            this.Messages.Text = "New Messages";
            this.Messages.UseVisualStyleBackColor = true;
            this.Messages.Click += new System.EventHandler(this.Messages_Click);
            // 
            // ManagerMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 604);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Back);
            this.Name = "ManagerMessage";
            this.Text = "ManagerMessage";
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.BindingSource collegeDataSetBindingSource;
        private collegeDataSet collegeDataSet;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Messages;
    }
}