using System;
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
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAddCourse f5 = new StudentAddCourse();
            f5.Show();
            
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {

        }
    }
}
