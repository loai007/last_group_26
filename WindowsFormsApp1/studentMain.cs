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
    public partial class studentMain : Form
    {
        public studentMain()
        {
            InitializeComponent();
        }

        private void sst_Click(object sender, EventArgs e)
        {
            Schedule sc = new Schedule();
            sc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //EmptyUserFile();

            Form1 f1 = new Form1();
            f1.Show();
        }
        private void EmptyUserFile()
        {

            StreamWriter sw = new StreamWriter("user.txt");
            string line = "";
            sw.WriteLine(line);
            sw.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAddCourse f5 = new StudentAddCourse();
            f5.Show();
            
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAddCourse f6 = new StudentAddCourse();
            f6.Show();
        }

        private void RemoveCorse_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentRemoveCourse f7 = new StudentRemoveCourse();
            f7.Show();
        }

        private void ViewGreadsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentViewGreads f8 = new StudentViewGreads();
            f8.Show();
        }

        private void Exams_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentShowExams f = new StudentShowExams();
            f.Show();

        }

        private void viewMessagesBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentViewMessages f = new StudentViewMessages();
            f.Show();
        }

        private void sendMessagesBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentSendMessages f = new StudentSendMessages();
            f.Show();
        }

        private void SendRequestBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentSendRequests f = new StudentSendRequests();
            f.Show();
        }

        private void viewRequestsBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentViewRequests f = new studentViewRequests();
            f.Show();
        }
        private string getData(string path, string key = null)
        {
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            if (line != null)
            {
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
                if (details.Length != 1)
                    return details[2] + " " + details[3];
            }
            sr.Close();
            return null;
        }
        private void studentMain_Load(object sender, EventArgs e)
        {
            studentname_lbl.Text = "Welcome" + " " + getData("user.txt");
        }
    }
}
