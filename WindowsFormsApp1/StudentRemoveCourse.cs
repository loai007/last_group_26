using System;
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
    public partial class StudentRemoveCourse : Form
    {
        public StudentRemoveCourse()
        {
            InitializeComponent();
            showData(getData("user.txt"), "coursestudent.txt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool CourseR(string id)
        {
            StreamReader stc = new StreamReader("coursestudent.txt");
            string course = textcourse.Text;

            string line = stc.ReadLine();
            string[] details = line.Split(' ');
            while (line != null)
            {
                if (id == details[0] && course == details[1])
                {
                    string[] Lines = File.ReadAllLines("coursestudent.txt");
                    stc.Close();

                    File.Delete("coursestudent.txt");// Deleting the file
                    using (StreamWriter sw = File.AppendText("coursestudent.txt"))

                        foreach (string line1 in Lines)
                        {
                            if (line1.IndexOf(course) >= 0)
                            {
                                //Skip the line
                                continue;
                            }
                            else
                            {
                                sw.WriteLine(line1);
                            }
                        }

                    return true;
                }
                line = stc.ReadLine();
                if (line != "" && line != null)
                {
                    details = line.Split(' ');
                }

            }
            stc.Close();
            return false;
        }

        private void RemoveCourse_Click(object sender, EventArgs e)
        {
            StreamReader stc = new StreamReader("user.txt");
            string line = stc.ReadLine();
            string[] details = line.Split(' ');
            if (CourseR(details[0]) != true)
                label2.Text = "error";
            else
            {

                label2.Text = "Remove";
            }

            stc.Close();
            showData(getData("user.txt"), "coursestudent.txt");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMain f8 = new studentMain();
            f8.Show();
        }

        private void StudentRemoveCourse_Load(object sender, EventArgs e)
        {

        }
        private void showData(string[] userDetails, string path)
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(path);
            //Read the first line of text
            string line = sr.ReadLine();
            int linecount = 0;
            //DataGridView dt = new DataGridView();
            DataTable dt = new DataTable();
            InitializeGridView(dt);//does as the name say
            //Continue to read until you reach end of file
            while (line != null)
            {
                string[] courseDetails = line.Split(' ');
                    dt.Rows.Add(courseDetails);

                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            courses_dgv.DataSource = dt;


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
                        break;
                line = sr.ReadLine();
            }
            sr.Close();
            return details;
        }
        private void InitializeGridView(DataTable dt)
        {
            string[] columnnames = { "Student ID","Course name", "Day", "Hours"};
            foreach (string c in columnnames)
                dt.Columns.Add(c);
        }
        private void writeToFile(string path, string line)
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(line);
            sw.Close();
        }
    }
}
