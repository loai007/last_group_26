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
    public partial class ManagerMain : Form
    {
        public ManagerMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerAddC mac = new ManagerAddC();
            mac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void deletec_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerDeleteCourse mdc = new ManagerDeleteCourse();
            mdc.Show();
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerSendMessage f9 = new ManagerSendMessage();
            f9.Show();
        }
    }
}
