﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentSendRequests : Form
    {
        public StudentSendRequests()
        {
            InitializeComponent();
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMain f8 = new studentMain();
            f8.Show();
        }
    }
}
