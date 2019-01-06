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
    public partial class StudentShowExams : Form
    {
        public StudentShowExams()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMain f = new studentMain();
            f.Show();
        }

        private void Show_Click(object sender, EventArgs e)
        {
           
        }

        

        private void showData(string[] userDetails, string path)
        {
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            int linecount = 0;
            DataTable dt = new DataTable();
            InitializeGridView(dt);//does as the name say
            while (line != null)
            {
                string[] courseDetails = line.Split(' ');
                if (userDetails[0] == courseDetails[0])
                {

                    linecount++;
                    if (isDate(courseDetails) == null)
                        dt.Rows.Add(courseDetails);
                    else
                    {
                        dt.Rows.Add(isDate(courseDetails).Split(' '));
                        

                    }
                }
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            ShowExams.DataSource = dt;

        }
        private string isDate(string[] coursedetails)
        {
            string[] line = getData("course.txt", coursedetails[1]);
            if (line.Length == 6)
                return null;

            return coursedetails[0] + ' ' +coursedetails[1] + ' ' +coursedetails[2] + ' ' +coursedetails[3] + ' ' + line[6] + ' ' + line[7];
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
            return details;
        }
        private void InitializeGridView(DataTable dt)
        {
            string[] columnnames = { "Student ID", "Course name", "Day", "Hours", "Exam Date", "Exam Time" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
        }

        private void ShowExams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentShowExams_Load(object sender, EventArgs e)
        {
            showData(getData("user.txt"), "coursestudent.txt");
        }
    }
}
