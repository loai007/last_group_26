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
    public partial class InstructorShowCourse : Form
    {
        public InstructorShowCourse()
        {
            InitializeComponent();
            
        }
        public string dayofweek(int day)
        {
            switch (day)
            {
                case 1:
                    return "Sunday";
                case 2:
                    return "Monday";
                case 3:
                    return "Tuesday";
                case 4:
                    return "Wednesday";
                case 5:
                    return "Thursday";
                case 6:
                    return "Friday";
                case 7:
                    return "Saturday";
                   
            }
            return"";
        }
        private void checkcourse()
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("user.txt");
            //Read the first line of text
            string line = sr.ReadLine();
            string[] details = line.Split(' ');
            string[] cs_details = line.Split();
            name_lbl.Text = cs_details[2];
            coursename_lbl.Text = cs_details[5];

                                     //convert string to int
            day_lbl.Text = dayofweek(Int32.Parse(cs_details[6]));
            int tohour = Int32.Parse(cs_details[7]);
            tohour += 2;
            hour_lbl.Text = cs_details[7] + ":00" +" - "+ tohour.ToString() + ":00";

            sr.Close();

        }
        private void Back_btn_Click(object sender, EventArgs e)
        {
            Hide();
            InstructorMain sm = new InstructorMain();
            sm.Show();
        }

        private void name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void InstructorShowCourse_Load(object sender, EventArgs e)
        {
            checkcourse();
        }
    }
}
