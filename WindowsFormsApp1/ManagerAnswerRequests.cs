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
    public partial class ManagerAnswerRequests : Form
    {
        public ManagerAnswerRequests()
        {
            InitializeComponent();
            errorLBL.Text = "";
            fromLBL.Text = "";
            toLBL.Text = "";
            requestLBL.Text = "";
            statusLBL.Text = "";
            myId = getData("user.txt")[0];
            myRequestsCoutAndexport();
            showRequestsDGV();
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
        private int count = 0;
        private bool messages = false;
        private int selectedIndex = -1;
        private string myId;
        private string[] fromId;
        private string[] request;
        private string[] status;

        private void myRequestsCoutAndexport()
        {
            StreamReader sr = new StreamReader("requests.txt");
            string line = sr.ReadLine();
            messages = false;
            while (line != null)
            {
                string[] details = line.Split(' ');
                if (details.Length >= 2)
                    if (details[1] == myId)
                    {
                        //flagbinding = true;
                        line = sr.ReadLine();
                        while (line != null && details[0] == "EOMessage")
                        {
                            details = line.Split(' ');
                            line = sr.ReadLine();
                        }
                        if (details[1] == "binding")
                        {
                            count++;
                            messages = true;
                        }
                    }
                line = sr.ReadLine();

            }
            bool flag = false;
            fromId = new string[count+1];
            request = new string[count+1];
            status = new string[count+1];
            sr.Close();
            sr = new StreamReader("requests.txt");
            line = sr.ReadLine();
            int i = 0;
            while (line != null && messages)
            {
                //first part of every message/request 
                string[] details = line.Split(' ');
                if (details.Length >= 2)
                    if (details[1] == myId)
                    {
                        request[i] = "";
                        fromId[i] = details[0];
                        for (int c = 2; c < details.Length; c++)
                            request[i] += " " + details[c];
                        request[i] += "\r\n";
                    
                        //secoud part where the masseage is
                        line = sr.ReadLine();
                        details = line.Split(' ');
                        while (line != null)
                        {
                            details = line.Split(' ');
                            if (details[0] == "EOMessage") break;
                            request[i] += line + "\r\n";
                            line = sr.ReadLine();
                        }
                        //lastpart where the EOMessage
                        if (details[1] == "binding")
                        {
                            status[i] = details[1];
                            i++;
                        }
                    }
                    line = sr.ReadLine();
            }
            sr.Close();

        }
        private void showRequestsDGV()
        {
            DataTable dt = new DataTable();
            string[] columnnames = { "Request from" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
            foreach (string c in fromId)
                dt.Rows.Add(c);
            dataGridView.DataSource = dt;
        }
        private void ChangeStatusForRequest()
        {
            int messageIndex = 0;
            string[] Lines = File.ReadAllLines("requests.txt");
            File.Delete("requests.txt");// Deleting the file
            using (StreamWriter sw = File.AppendText("requests.txt"))

                for (int i = 0; i < Lines.Length; i++)
                {
                    string[] splitedLine = Lines[i].Split();
                    if (splitedLine[1] == myId)
                    {

                        while (i < Lines.Length && splitedLine[0] != "EOMessage") i++;

                        if (splitedLine[0] == "EOMessage")
                            if (splitedLine[1] != status[messageIndex])
                            {
                                string newLine = splitedLine[0] + ' ' + status[messageIndex];
                                sw.WriteLine(newLine);
                                messageIndex++;
                            }
                            else

                                sw.WriteLine(Lines[i]);

                    }
                }

            errorLBL.ForeColor = System.Drawing.Color.Black;
            errorLBL.Text = "Coming soon!!";


        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedIndex = dataGridView.CurrentRow.Index;
            if (messages && selectedIndex<=count)
            {
                errorLBL.Text = "";
                fromLBL.Text = fromId[selectedIndex];
                toLBL.Text = myId;
                requestLBL.Text = request[selectedIndex];
                statusLBL.Text = status[selectedIndex];
            }
            else errorLBL.Text = "No Requests";
        }

        private void approveBTN_Click(object sender, EventArgs e)
        {
            if (selectedIndex > -1 && selectedIndex <= count)
            {
                status[selectedIndex] = "Approved";
                ChangeStatusForRequest();
            }
        }

        private void DenyBTN_Click(object sender, EventArgs e)
        {
            if (selectedIndex > -1 && selectedIndex <= count)
            {
                status[selectedIndex] = "Denied";
                ChangeStatusForRequest();
            }
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMain b = new ManagerMain();
            b.Show();
        }
        
    }
}
