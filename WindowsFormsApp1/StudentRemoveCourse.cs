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
        }
    }
}
