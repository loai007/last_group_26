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
    public partial class ManagerAddCourseDate : Form
    {
        public ManagerAddCourseDate()
        {
            InitializeComponent();
            messagelbl.Text = "";
            showData( "course.txt");
        }

        private string[] getData(string path, string key = null)
        {
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            string[] details = line.Split(' ');
            while (line != null && key != null)
            {
                details = line.Split(' ');
                foreach (string c in details)
                    if (c == key)
                    {
                        sr.Close();
                        return details;
                    }
                line = sr.ReadLine();
            }
            sr.Close();
            if (key == null)
                return details;

            return null;
        }
        private bool iscourse(string course_name)
        {
            StreamReader sr = new StreamReader("course.txt");


            string line = sr.ReadLine();
            string[] details;// = line.Split(' ');
            while (string.IsNullOrWhiteSpace(line) != true)
            {
                details = line.Split(' ');
                if (course_name == details[0])
                {
                    sr.Close();
                    return true;
                }
                line = sr.ReadLine();

            }
            sr.Close();
            return false;

        }

        private bool addDateForCourse(string date, string time, string courseName)
        {
            bool flag = false;
            if (string.IsNullOrWhiteSpace(courseName) == false && iscourse(courseName) == true)
            {
                string[] Lines = File.ReadAllLines("course.txt");
                File.Delete("course.txt");// Deleting the file
                using (StreamWriter sw = File.AppendText("course.txt"))

                    foreach (string line in Lines)
                    {
                        string[] splitedLine = line.Split();
                        if (splitedLine[0] == courseName)
                        {
                            string newLine = splitedLine[0] + ' ' + splitedLine[1] + ' ' + splitedLine[2] + ' ' + splitedLine[3] + ' ' + splitedLine[4] + ' ' + splitedLine[5] + ' ' + date + ' ' + time;
                            sw.WriteLine(newLine);
                            flag = true;
                        }
                        else
                        {
                            sw.WriteLine(line);
                        }
                    }

            }
            if (flag)
            {
                messagelbl.ForeColor = System.Drawing.Color.Black;
                messagelbl.Text = "Course exam time added";
            }
            else
            {
                messagelbl.ForeColor = System.Drawing.Color.Red;
                messagelbl.Text = "Course Not Found";
            }
            return flag;
        }
        
     
        private bool formedDate(string date,string time)
        {
            int D,M,Y,H,MM;
            string[] SDate = date.Split('/');
            string[] sTime = time.Split(':');
            if (SDate.Length == 3 && sTime.Length == 2)
            {
                if (SDate[0].Length == 2 && SDate[1].Length == 2 && SDate[2].Length == 4)
                {
                    if (sTime[0].Length == 2 && sTime[1].Length == 2)
                    {
                        D = (SDate[0][0] - '0') * 10 + SDate[0][1] - '0';
                        M = (SDate[1][0] - '0') * 10 + SDate[1][1] - '0';
                        Y = (SDate[2][0] - '0') * 1000 + (SDate[2][1] - '0') * 100 + (SDate[2][2] - '0') * 10 + SDate[2][3] - '0';

                        H = (sTime[0][0] - '0') * 10 + sTime[0][1] - '0';
                        MM = (sTime[1][0] - '0') * 10 + sTime[1][1] - '0'; ;
                        if (((D > 0 && D <= 30) && (M > 0 && M <= 12) && (Y > 0)))
                            if ((H > 0 && H < 24))
                                return true;
                    }
                }
            }
            return false;
        }
        public  void addBTNClick(string date, string time,string CourseName)
        {
            
            if (formedDate(date, time))
            {
                addDateForCourse(date, time, CourseName);
               
            }
            else
                messagelbl.Text= "Wronf format";
        }
        private void addBTN_Click(object sender, EventArgs e)
        {
            string date = dateTB.Text, time = timeTB.Text,CourseName= courseNameTB.Text;
            addBTNClick(date, time, CourseName);

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMain sm = new ManagerMain();
            sm.Show();
        }
        private void showData( string path)
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(path);
            //Read the first line of text
            string line = sr.ReadLine();

            //DataGridView dt = new DataGridView();
            DataTable dt = new DataTable();
            InitializeGridView(dt);//does as the name say
            //Continue to read until you reach end of file
            while (line != null)
            {
                string[] courseDetails = line.Split(' ');
                if (courseDetails.Length==6)

                    dt.Rows.Add(courseDetails);

                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            dataGridViewCourses.DataSource = dt;

        }
        private void InitializeGridView(DataTable dt)
        {
            string[] columnnames = { "Course name", "Points", "Instructor name", "Day", "Hours", "Department" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
        }
    }
}
