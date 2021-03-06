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
    public partial class StudentAddCourse : Form
    {
        public StudentAddCourse()
        {
            InitializeComponent();
            

        }

     

        private void StudentAddCourse_Load(object sender, EventArgs e)
        {
            massagelbl.Visible = false;
            showData(getData("user.txt"), "course.txt");

        }

      

        private void dataGridViewCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        //un=user name
        //ps=password
        //path=path of the desired file
        private void showData(string[] userDetails , string path)
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(path);
            //Read the first line of text
            string line = sr.ReadLine();
            
            //DataGridView dt = new DataGridView();
            DataTable dt = new DataTable();
            InitializeGridView(dt);//does as the name say
            //Continue to read until you reach end of file
            while (!(string.IsNullOrWhiteSpace( line)))
            {
                string[] courseDetails = line.Split(' ');
                if (userDetails[5] == courseDetails[5])
                {
                    if (doesntExist("coursestudent.txt", userDetails[0], courseDetails[0]))

                        dt.Rows.Add(courseDetails);

                }
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            dataGridViewCourses.DataSource = dt;
            
        }
        private string[] getData(string path,string key=null) {
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            string[] details= line.Split(' ');
            while (line!=null && key != null)
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
            if(key == null)
                return details;

            return null;
        }
        private void InitializeGridView(DataTable dt)
        {
            string[] columnnames = { "Course name", "Points", "Instructor name", "Day", "Hours" , "Department" ,"Exam Date","Exam Time"};
            
            foreach (string c in columnnames)
                dt.Columns.Add(c);
        }
        public void writeToFile(string path,string line)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                throw new ArgumentException("Line is Empty", "writetofileError");
            }
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(line);
            sw.Close();
        }

        public bool makesureNotEmpty(string[] userDetails, string[] courseDetail)
        {
            return (userDetails!=null && courseDetail!=null); 
        }

        private bool addCourseForUser(string[] userDetails,string[] courseDetail)
        {
            char s = ' ';
            if (courseDetail==null || courseDetail.Length==0|| string.IsNullOrWhiteSpace(courseDetail[0]))
                return false;
            if (doesntExist("coursestudent.txt", userDetails[0], courseDetail[0]))
            {
                string line = (userDetails[0] + s + courseDetail[0] + s + courseDetail[3] + s + courseDetail[4]);
                writeToFile("coursestudent.txt", line);
            }
            else return false;
            return true;
        }
        //if (doesntExist("coursestudent.txt", userDetails[0], courseDetails[0]))

        private bool doesntExist(string path,string key1, string key2)
        {
            StreamReader sr = new StreamReader(path);

            string line = sr.ReadLine();
            while (line != null)
            {
                string[] details = line.Split(' ');
                    if (details[0] == key1 && details[1] == key2)
                {
                    sr.Close();
                    return false;
                }
                       
                line = sr.ReadLine();

            }
            sr.Close();
            return true;
        }
        private void AddCourse_Click(object sender, EventArgs e)
        {
            string coursename=textBoxAddCourse.Text;
            if (addCourseForUser(getData("user.txt"), getData("course.txt", coursename)))
            {
                massagelbl.Visible = true;
                massagelbl.ForeColor = System.Drawing.Color.Black;
                massagelbl.Text = "Coures added";
            }
            else
            {
                massagelbl.Visible = true;
                massagelbl.ForeColor = System.Drawing.Color.Red;
                massagelbl.Text = "Coures exist or wrong course name";
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMain f8 = new studentMain();
            f8.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCourses_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string courseName= dataGridViewCourses.CurrentRow.Cells[0].Value.ToString();
            if (!string.IsNullOrWhiteSpace(courseName))
            {
                textBoxAddCourse.Text = courseName;
            }
            else
            {
                massagelbl.Visible = true;
                massagelbl.ForeColor = System.Drawing.Color.Black;
                massagelbl.Text = "Choose valed A Course";
            }
        }
    }
}
