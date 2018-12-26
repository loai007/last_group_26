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
    public partial class StudentAddCourse : Form
    {
        public StudentAddCourse()
        {
            InitializeComponent();
            showData(getUser(), "course.txt");

        }

        private void CoursesTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentAddCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeDataSet.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.collegeDataSet.courses);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //un=user name
        //ps=password
        //path=path of the desired file
        private bool showData(string[] userDetails , string path)
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(path);
            //Read the first line of text
            string line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                string[] courseDetails = line.Split(' ');
                if (userDetails[5] == courseDetails[5])
                    DisplayCourse(courseDetails);
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            return false;
        }
        private string[] getUser() {

           
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("user.txt");
                //Read the first line of text
                string line = sr.ReadLine();
                string[] details = line.Split(' ');
                sr.Close();
            return details;


        }
        private void DisplayCourse(string[] courseDetalis)
        {
            
            DataTable dt = new DataTable();
            string[] columnnames = {"Course name","Points","Day", "Hours" };
            foreach (string c in courseDetalis)
            {
                dt.Columns.Add(c);
            }
         
                DataRow dr = dt.NewRow();
                for (int i = 0; i < courseDetalis.Length; i++)
                {
                    dr[i] = courseDetalis[i];
                }
                dt.Rows.Add(dr);
            
        }
    }
}
