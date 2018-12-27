﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ManagerMessage : Form
    {
        public ManagerMessage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMain f = new ManagerMain();
            f.Show();

        }
        private void ifId(string id)
        {
            StreamReader sr = new StreamReader("messages.txt");

            string line = sr.ReadLine();
            string[] details = line.Split(' ');
            string[] arr = new string[3];
           
            char s = ' ';
            while (line != null)
            {
                if (id == details[0])
                {
                    arr[0] = "Id: ";
                    arr[0] += details[1];
                    arr[1] = "Message: ";
                    for (int i = 2; i < details.Length ; i++)
                    {
                        arr[1] =arr[1]+ details[i] + s;
                    }
                    
                    listView1.Items.Add(arr[0]);
                    listView1.Items.Add(arr[1]);
                    

                }
                arr[0] = "";
                arr[1] = "";
                line = sr.ReadLine();
                if (line != "" && line != null)
                {
                    details = line.Split(' ');
                }

            }
            sr.Close();
            
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void Messages_Click(object sender, EventArgs e)
        {
            StreamReader mi = new StreamReader("user.txt");
            string line = mi.ReadLine();
            string[] details = line.Split(' ');
            string idM = details[0];
            mi.Close();
            ifId(idM);
        }
    }
}
