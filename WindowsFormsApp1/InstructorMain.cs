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
    public partial class InstructorMain : Form
    {
        public InstructorMain()
        {
            InitializeComponent();
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
            
            f1.Show();
           
        }
    }
}
