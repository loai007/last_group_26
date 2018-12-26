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
    public partial class InstructorAddMarks : Form
    {
        public InstructorAddMarks()
        {
            InitializeComponent();
            showData(getData("user.txt"), "course.txt");
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
            private void button1_Click(object sender, EventArgs e)
        {
            



        }

        private void writeToFile(string path, string line)
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(line);
            sw.Close();
        }
        private void UpdateMarkBtn_Click(object sender, EventArgs e)
        {
            string line = nameTb.Text + ' ' + getData("user.txt")[0] + ' '  + markTb.Text;
            writeToFile("greads.txt", line);
            
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
                if (userDetails[5] == courseDetails[5])
                {
                    linecount++;
                    dt.Rows.Add(courseDetails);

                }
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            dataGridViewMarks.DataSource = dt;

        }
        private void InitializeGridView(DataTable dt)
        {
            string[] columnnames = { "Course name", "Points", "Instructor name", "Day", "Hours", "Department" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
        }
    }
}
