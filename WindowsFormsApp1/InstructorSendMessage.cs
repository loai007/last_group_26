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
    public partial class InstructorSendMessage : Form
    {
        public InstructorSendMessage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorMain f = new InstructorMain();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private bool ifID(string id, string path)
        {
            StreamReader sr = new StreamReader(path);

            string line = sr.ReadLine();
            string[] details = line.Split(' ');
            while (line != null)
            {
                if (id == details[0])
                {
                    sr.Close();
                    return true;
                }
                line = sr.ReadLine();
                if (line != "" && line != null)
                {
                    details = line.Split(' ');
                }

            }
            sr.Close();
            return false;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string id = StudentId.Text;
            if (ifID(id, "student.txt") != true && ifID(id, "instructor.txt") != true && ifID(id, "manager.txt") != true)
                idFind.Text = "id not exist";
            else
            {
                if (TextMessage.Text != "")
                {
                    char s = ' ';

                    StreamReader mi = new StreamReader("user.txt");
                    string line = mi.ReadLine();
                    string[] details = line.Split(' ');
                    string idM = details[0];
                    mi.Close();

                    string message = id + s + idM + s + TextMessage.Text + "\r\nEOMessage";
                    StreamWriter mw = new StreamWriter("messages.txt", true);
                    mw.WriteLine(message);
                    mw.Close();
                    SendStudent.Text = "message sent";
                }
                else
                    SendStudent.Text = "empty message";

            }
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
            StudentId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void ManagerBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = showManagers();
        }

        private void InstructorBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = showInstructors();
        }

        private void StudentBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = showStudents();
        }

        private void InstructorSendMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
