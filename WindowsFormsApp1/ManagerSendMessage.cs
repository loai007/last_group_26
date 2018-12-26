﻿using System;
using System.IO;
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
    public partial class ManagerSendMessage : Form
    {
        public ManagerSendMessage()
        {
            InitializeComponent();
        }

        private void ManagerSendMessage_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMain f = new ManagerMain();
            f.Show();
        }
        private bool ifID(string id)
        {
            StreamReader sr = new StreamReader("student.txt");

            string line = sr.ReadLine();
            string[] details = line.Split(' ');
            while (line != null)
            {
                if (id == details[0])
                {
                    sr.Close();
                    return true;
                }
                line = sr.ReadLine();
                if (line != "" && line != null)
                {
                    details = line.Split(' ');
                }

            }
            sr.Close();
            return false;
        }
        private void Send_Click(object sender, EventArgs e)
        {
           string id= StudentId.Text;
            if (ifID(id) != true)
                idFind.Text = "id not exist";
            else
            {
                if (Message.Text != "")
                {
                    char s = ' ';
                    string message = id + s + Message.Text;
                    StreamWriter mw = new StreamWriter("messages.txt", true);
                    mw.WriteLine(message);
                    mw.Close();
                    SendStudent.Text = "message sent";
                }
                else
                    SendStudent.Text = "empty message";

            }

        }
    }
}