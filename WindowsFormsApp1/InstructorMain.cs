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
    public partial class InstructorMain : Form
    {
        
        public InstructorMain()
        {
            InitializeComponent();

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
                if(details.Length!=1)
                    return details[2] + " " + details[3];
            }
            sr.Close();
            return null;
        }

        private void buTime_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstructorSchedule Is = new InstructorSchedule();
            Is.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f1 = new Form1();
            EmptyUserFile();
            f1.Show();
           
        }

        private void EmptyUserFile()
        {

            StreamWriter sw = new StreamWriter("user.txt");
            string line = "";
            sw.WriteLine(line);
            sw.Close();

        }

        private void corses_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorShowCourse isc = new InstructorShowCourse();
            isc.Show();
        }

        private void AddMarksBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorAddMarks iam = new InstructorAddMarks();
            iam.Show();
        }

        private void showstudents_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorShowStudenstInCourse iam = new InstructorShowStudenstInCourse();
            iam.Show();
        }

        private void InstructorMain_Load(object sender, EventArgs e)
        {
            instructorname_lbl.Text = "Welcome" + " " + getData("user.txt");
            date_lbl.Text = DateTime.Now.ToShortDateString();

        }

        private void VeiwMessagesBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorViewMessages iam = new InstructorViewMessages();
            iam.Show();
        }

        private void viewRequestsBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorViewRequests iam = new InstructorViewRequests();
            iam.Show();
        }

        private void answerRequestsBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorAnswerRequests iam = new InstructorAnswerRequests();
            iam.Show();
        }

        private void SendMessages_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorSendMessage f = new InstructorSendMessage();
            f.Show();
        }

        private void SendRequestBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorSendRequests f = new InstructorSendRequests();
            f.Show();
        }
    }
}
