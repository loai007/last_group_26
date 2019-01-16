using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Auto_data_forms
{
    public partial class MainAuto : Form
    {
        public MainAuto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void AddCourseInsBtn_Click(object sender, EventArgs e)
        {
            ManagerAddCourse AA = new ManagerAddCourse();

            AA.addbuttonClick("2", "5", "3", "cpp"
            , "00000000", "computers", "kh", "sa", "333", "333");
            lbl.Text = "Couse Added AUTOMATICLY ";
        }

        private void nessagesendBtn_Click(object sender, EventArgs e)
        {
            ManagerSendMessage AA = new ManagerSendMessage();

            AA.click("111", "222", "hi my name is", "manager.txt");
            AA.click("1111","22", "hi my name is", "instructor.txt");
            AA.click("222","3333", "hi my name is", "student.txt");
            lbl.Text = "Auto message sender";
        }
    }
}
