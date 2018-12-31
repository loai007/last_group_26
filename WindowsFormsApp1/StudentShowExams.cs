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
    public partial class StudentShowExams : Form
    {
        public StudentShowExams()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMain f = new studentMain();
            f.Show();
        }

        private void Show_Click(object sender, EventArgs e)
        {

        }

        private void ShowEsams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
