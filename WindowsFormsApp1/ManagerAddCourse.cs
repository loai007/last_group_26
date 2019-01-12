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
//update
namespace WindowsFormsApp1
{
    public partial class ManagerAddCourse : Form
    {
        public ManagerAddCourse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void writeToManagerFile(string line)
        {
            StreamWriter sw = new StreamWriter("instructor.txt",true);
            sw.WriteLine(line);
            sw.Close();
        }

        private void writeToCourseFile(string line)
        {
            StreamWriter sw = new StreamWriter("course.txt", true);
            sw.WriteLine(line);
            sw.Close();
        }
        private bool ifID(string i)
        {
            StreamReader sr = new StreamReader("instructor.txt");

            string line = sr.ReadLine();
            string[] details = line.Split(' ');
            while (line != null)
            {
                if (i == details[0])
                {
                    sr.Close();
                    return false;
                }
                line = sr.ReadLine();
                if (line!=""  && line!=null)
                {
                    details = line.Split(' ');
                }
              
            }
            sr.Close();
            return true; 
        }
        public bool CheckInputs(string data)
        {
            return (!(string.IsNullOrWhiteSpace(data)));
        }
        private void addbut_Click(object sender, EventArgs e)
        {
            string day = daybox.Text
            , points = points_txt.Text
            , time = timebox.Text
            , cname = cnamebox.Text
            , phn = txtphn.Text
            , dep = depbox.Text
            , last = lastnbox.Text
            , name = namebox.Text
            , pass = passbox.Text
            ,id = idbox.Text;
            int flag = 1;
            if (CheckInputs(id)
            && CheckInputs(pass)
            && CheckInputs(name)
            && CheckInputs(last)
            && CheckInputs(dep)
            && CheckInputs(phn)
            && CheckInputs(cname)
            && CheckInputs(day)
            && CheckInputs(time)
            && CheckInputs(points))
                flag = 0;
            

            char s = ' ';
            if (flag != 0 && ifID(id)==true)
            {
                string line = (id + s + pass + s + name + s + last + s + dep + s  + cname + s + day + s + time + s + phn);

                writeToManagerFile(line);
                line = (cname + s + points + s + name + s + day + s + time + s + dep); 
                writeToCourseFile(line);
                lblero.Text = "added ☺";
            }
            else
            {
                lblero.Text = "Fill in all blanks ";
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMain f4 = new ManagerMain();
            f4.Show();
        }
    }
}
