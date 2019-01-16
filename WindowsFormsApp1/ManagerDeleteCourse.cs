using System;
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
    public partial class ManagerDeleteCourse : Form
    {
        public ManagerDeleteCourse()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMain mm= new ManagerMain();
            mm.Show();
        }
        private void showData(string[] userDetails, string path)
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
                if (userDetails[5] == courseDetails[5])
                {

                    dt.Rows.Add(courseDetails);

                }
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            dataGridViewCourses.DataSource = dt;

        }
        private string[] getData(string path, string key = null)
        {
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            if (key == null)
            {
                sr.Close();
                return line.Split(' ');
            }
                string[] details;
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
            

            return null;
        }

        private void InitializeGridView(DataTable dt)
        {
            string[] columnnames = { "Course name", "Points", "Instructor name", "Day", "Hours", "Department", "Exam Date", "Exam Time" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
        }

        private bool iscourse(string course_name)
        {
            StreamReader sr = new StreamReader("course.txt");
            

                string line = sr.ReadLine();
                string[] details;// = line.Split(' ');
                while  (string.IsNullOrWhiteSpace(line) != true)
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

        private void Deletecourse(string course_name)
        {
            if (iscourse(course_name) && string.IsNullOrWhiteSpace(course_name)==false)
            {
                string[] Lines = File.ReadAllLines("course.txt");
                File.Delete("course.txt");// Deleting the file
                using (StreamWriter sw = File.AppendText("course.txt"))
                    foreach (string line in Lines)
                    {
                        if (line.IndexOf(course_name) >= 0)
                        {
                            //Skip the line
                            continue;
                        }
                        else
                        {
                            sw.WriteLine(line);
                        }
                    }
                DeleteIstructor(getData("instructor.txt", coursename_txt.Text)[0]);
                wrongname_lbl.ForeColor = System.Drawing.Color.Black;
                wrongname_lbl.Text = "Deleted";
            }
            else
            {
                wrongname_lbl.ForeColor = System.Drawing.Color.Red;
                wrongname_lbl.Text = "Wrong course name";
            }
        }
        private bool ifID(string id, string path)
        {
            StreamReader sr = new StreamReader(path);

            string line = sr.ReadLine();
            string[] details;// = line.Split(' ');
            while (string.IsNullOrWhiteSpace(line) == false)
            {
                details = line.Split(' ');
                if (id == details[0])
                {
                    sr.Close();
                    return true;
                }
                line = sr.ReadLine();

            }
            sr.Close();
            return false;
        }
        private void DeleteIstructor(string ins_id)
        {
            
                string[] Lines = File.ReadAllLines("instructor.txt");
                File.Delete("instructor.txt");// Deleting the file
                using (StreamWriter sw = File.AppendText("instructor.txt"))
                    foreach (string line in Lines)
                    {
                        if (line.IndexOf(ins_id) >= 0)
                        {
                            //Skip the line
                            continue;
                        }
                        else
                        {
                            sw.WriteLine(line);
                        }
                    }
                
                wrongname_lbl.ForeColor = System.Drawing.Color.Black;
                wrongname_lbl.Text = "Deleted";
            
            
        }
        private void Deletecourse_btn_Click(object sender, EventArgs e)
        {
            if (iscourse(coursename_txt.Text))
            {
                if ((ifID(getData("instructor.txt", coursename_txt.Text)[0], "instructor.txt")))
                {
                    Deletecourse(coursename_txt.Text);
                    showData(getData("user.txt"), "course.txt");
                }
                else
                {
                    wrongname_lbl.ForeColor = System.Drawing.Color.Red;
                    wrongname_lbl.Text = "Instructor Doesnt Exist";
                }
            }
            else
            {
                wrongname_lbl.ForeColor = System.Drawing.Color.Red;
                wrongname_lbl.Text = "Wrong course name";
            }
        }

        private void ManagerDeleteCourse_Load(object sender, EventArgs e)
        {
            showData(getData("user.txt"), "course.txt");

        }

        private void dataGridViewCourses_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         coursename_txt.Text = dataGridViewCourses.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
