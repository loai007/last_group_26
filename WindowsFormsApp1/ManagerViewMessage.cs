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
    public partial class ManagerViewMessage : Form
    {
        public ManagerViewMessage()
        {
            InitializeComponent();
            messageLBL.Text = "";
            fromLBL.Text = "";
            toLBL.Text = "";
            myId = getData("user.txt")[0];
            myMessagesCout();
            myMessagesExport();
            showMessagesDGV();
        }
        public int count = 0;
        public bool messages = false;
        public string myId;
        public string[] fromId;
        public string[] MessageTxt;
        public string[] UserDetails;
        private void showMessagesDGV()
        {
            DataTable dt = new DataTable();
            string[] columnnames = { "Message From" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
            foreach (string c in fromId)
                dt.Rows.Add(c);
            dataGridMessage.DataSource = dt;
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

        public void myMessagesCout()
        {
            StreamReader sr = new StreamReader("messages.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] details = line.Split(' ');

                if (details[0] == myId)
                {
                    count++;
                    messages = true;

                }
                line = sr.ReadLine();
            }
            sr.Close();


        }
        public void myMessagesExport()
        {
            bool flag = false;
            fromId = new string[count];
            MessageTxt = new string[count];
            StreamReader sr = new StreamReader("messages.txt");
            string line = sr.ReadLine();
            int i = 0, del;
            while (line != null && messages)
            {
                string[] details = line.Split(' ');
                if (details[0] == "EOMessage")//"EOMessage"
                {
                    if (flag)
                        i++;
                    flag = false;
                }
                else if (flag)
                    MessageTxt[i] += line + "\r\n";
                else if (details[0] == myId)
                {
                    fromId[i] = details[1];
                    del = details[0].Length + details[1].Length + 2;
                    MessageTxt[i] += line.Remove(0, del);
                    MessageTxt[i] += "\r\n";
                    flag = true;
                }

                line = sr.ReadLine();
            }
            sr.Close();
        }

        public DataTable showRequestsDGV()
        {
            DataTable dt = new DataTable();
            string[] columnnames = { "Message from" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
            foreach (string c in fromId)
                if (c != null)
                    dt.Rows.Add(c);
            return dt;
        }
        private void Messages_Click(object sender, EventArgs e)
        {

            
        }
        private void Back_Click(object sender, EventArgs e)
        {
            ManagerMain fff = new ManagerMain();
            this.Hide();
            fff.Show();
        }

        private void dataGridMessage_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedIndex = dataGridMessage.CurrentRow.Index;
            if (selectedIndex < count)
            {
                fromLBL.Text = fromId[selectedIndex];
                toLBL.Text = myId;
                messageLBL.Text = MessageTxt[selectedIndex];
            }
        }

        private void ManagerViewMessage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
//getMessage("user.txt", dataGridMessage.CurrentRow.Cells[0].Value.ToString());