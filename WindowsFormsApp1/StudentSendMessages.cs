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
    public partial class StudentSendMessages : Form
    {
        public StudentSendMessages()
        {
            InitializeComponent();
            messageLBL.Text = "";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMain f8 = new studentMain();
            f8.Show();
        }
        private bool FindUser(string un, string path)
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(path);
            //Read the first line of text
            string line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                string[] details = line.Split(' ');
                if (details[0] == un)
                {
                    sr.Close();
                    return true;
                }
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
            return false;
        }
        private void sendBTN_Click(object sender, EventArgs e)
        {
            studentMain st = new studentMain();
            InstructorMain ins = new InstructorMain();
            ManagerMain ma = new ManagerMain();
            int flag = 0;
            string un = textBoxun.Text;
            if (un != "" )
            {
                if (FindUser(un, "student.txt")) {  flag = 1;  }
                else if (FindUser(un, "instructor.txt")) {  flag = 1;  }
                else if (FindUser(un, "manager.txt")) {  flag = 1;  }
                if (flag == 1)
                {
                    char s = ' ';

                    StreamReader mi = new StreamReader("user.txt");
                    string line = mi.ReadLine();
                    string[] details = line.Split(' ');
                    string idM = details[0];
                    mi.Close();

                    string message = un + s + idM + s + textBoxMessage.Text + "\r\nEOMessage";
                    StreamWriter mw = new StreamWriter("messages.txt", true);
                    mw.WriteLine(message);
                    mw.Close();
                    
                    messageLBL.Text = "Message sent";
                }
                else messageLBL.Text = "Wrong password or ID";
            }
            else messageLBL.Text = "Fill in the ID or message";
        }
        public DataTable showInstructors()
        {
            StreamReader sr = new StreamReader("instructor.txt");
            string line = sr.ReadLine();
            DataTable dt = new DataTable();
            //Initialize Grid View
            string[] columnnames = { "ID", "Name", "Last Name", "Department", "Course", "Phone Numer" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
            while (line != null)
            {
                string[] details = line.Split(' ');
                if (details.Length >= 9)
                {
                    string[] showLine = { details[0], details[2], details[3], details[4], details[5], details[8] };
                    dt.Rows.Add(showLine);
                }
                else
                {
                    sr.Close();
                    break;
                }
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            return dt;

        }

        public DataTable showManagers()
        {
            StreamReader sr = new StreamReader("manager.txt");
            string line = sr.ReadLine();
            DataTable dt = new DataTable();
            //Initialize Grid View
            string[] columnnames = { "ID", "Name", "Last Name", "Department", "Phone Numer" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
            while (line != null)
            {
                string[] details = line.Split(' ');
                if (details.Length >= 6)
                {
                    string[] showLine = { details[0], details[2], details[3], details[5], details[4] };
                    dt.Rows.Add(showLine);
                }
                else
                {
                    sr.Close();
                    break;
                }
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            return dt;

        }

        public DataTable showStudents()
        {
            StreamReader sr = new StreamReader("student.txt");
            string line = sr.ReadLine();
            DataTable dt = new DataTable();
            //Initialize Grid View
            string[] columnnames = { "ID", "Name", "Last Name", "Department", "Phone Numer" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
            while (line != null)
            {
                string[] details = line.Split(' ');
                if (details.Length >= 6)
                {
                    string[] showLine = { details[0], details[2], details[3], details[5], details[4] };
                    dt.Rows.Add(showLine);
                }
                else
                {
                    sr.Close();
                    break;
                }
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            return dt;

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             textBoxun.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void ManagerBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = showManagers();
        }

        private void InstructorBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =showInstructors();
        }

        private void StudentBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = showStudents();
        }
    }
}
