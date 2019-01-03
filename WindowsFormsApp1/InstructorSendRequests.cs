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
    public partial class InstructorSendRequests : Form
    {
        public InstructorSendRequests()
        {
            InitializeComponent();
            showManagers();
            messageLBL.Text = "";
            fromLBL.Text = "Request From Manager";
        }
        string lockfor = "manager.txt";
        string spamDetection = null;
        private void backBTN_Click(object sender, EventArgs e)
        {
            
        }
        private bool doesntExist(string path, string key1)
        {
            StreamReader sr = new StreamReader(path);

            string line = sr.ReadLine();
            while (line != null)
            {

                string[] details = line.Split(' ');
                if (details[0] == key1)
                {
                    sr.Close();
                    return false;
                }
                line = sr.ReadLine();

            }
            sr.Close();
            return true;
        }
        
        private void showManagers()
        {
            StreamReader sr = new StreamReader("manager.txt");
            string line = sr.ReadLine();
            DataTable dt = new DataTable();
            //Initialize Grid View
            string[] columnnames = { "ID", "Name", "Last Name", "Department", "Phone Numer" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
            while (line != null)
            {
                string[] details = line.Split(' ');
                if (details.Length >= 6)
                {
                    string[] showLine = { details[0], details[2], details[3], details[5], details[4] };
                    dt.Rows.Add(showLine);
                }
                else
                {
                    messageLBL.Text = "Files Error manager.txt";
                    sr.Close();
                    return;
                }
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            dataGridView.DataSource = dt;

        }
        private string[] getData(string path, string key = null)
        {
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            if (line == null)
                return null;
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
            return details;
        }

        private void addToRequests(string req, string fromId, string toId)
        {
            StreamWriter sw = new StreamWriter("requests.txt", true);
            string status = "binding";
            string line = fromId + ' ' + toId + ' ' + req + "\r\nEOMessage " + status;
            sw.WriteLine(line);
            sw.Close();
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idTB.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void sendBTN_Click(object sender, EventArgs e)
        {
            if (doesntExist(lockfor, idTB.Text))
                messageLBL.Text = "Wrong ID ";
            else

                if (spamDetection != messageTB.Text)
            {
                addToRequests(messageTB.Text, getData("user.txt")[0], idTB.Text);
                messageLBL.Text = "Sent";
                spamDetection = messageTB.Text;
            }
            else messageLBL.Text = "Change Your Request To Request Again ";
        }

        private void backBTN_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            InstructorMain f8 = new InstructorMain();
            f8.Show();
        }
     
    }
}
