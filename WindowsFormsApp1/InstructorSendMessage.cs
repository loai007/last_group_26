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
    }
}
