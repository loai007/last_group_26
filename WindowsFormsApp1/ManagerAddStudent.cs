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
    public partial class ManagerAddStudent : Form
    {
        public ManagerAddStudent()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            int flag = 1;
            string id = id_txtbox.Text;
            if (id == "")
                flag = 0;
            string pass = password_txtbox.Text;
            if (pass == "")
                flag = 0;
            string name = firrstname_txtbox.Text;
            if (name == "")
                flag = 0;
            string last = lastname_txtbox.Text;
            if (last == "")
                flag = 0;
            string dep = department_txtbox.Text;
            if (dep == "")
                flag = 0;
            string phn = phonenumber_txtbox.Text;
            if (phn == "")
                flag = 0;
            
            char s = ' ';
            if (flag != 0)
            {
                if (ifID(id) == true)
                {
                    string line = (id + s + pass + s + name + s + last + s + phn + s + dep);

                    writeToStudentFile(line);
                    error_lbl.Visible = true;
                    error_lbl.Text = "added ☺";
                }
                else
                {
                    error_lbl.Visible = true;
                    error_lbl.Text = "id Exist";
                }
            }
            else
            {
                error_lbl.Visible = true;
                error_lbl.Text = "Fill in all blanks ";
            }

        }
        private void writeToStudentFile(string line)
        {
            StreamWriter sw = new StreamWriter("student.txt", true);
            sw.WriteLine(line);
            sw.Close();
        }

        private bool ifID(string i)
        {
            StreamReader sr = new StreamReader("student.txt");

            string line = sr.ReadLine();
            
            while (line != null)
            {
                string[] details = line.Split(' ');
                if (i == details[0])
                {
                    sr.Close();
                    return false;
                }
                line = sr.ReadLine();
                

            }
            sr.Close();
            return true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMain f4 = new ManagerMain();
            f4.Show();
        }

        private void ManagerAddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
