﻿using System;
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
    public partial class InstructorViewRequests : Form
    {
        //private string[] getData(string path, string key = null)
        //{
        //    StreamReader sr = new StreamReader(path);
        //    string line = sr.ReadLine();
        //    if (line == null)
        //        return null;
        //    string[] details = line.Split(' ');
        //    while (line != null && key != null)
        //    {
        //        details = line.Split(' ');
        //        foreach (string c in details)
        //            if (c == key)
        //                break;
        //        line = sr.ReadLine();
        //    }
        //    sr.Close();
        //    return details;
        //}
        //private int count = 0;
        //private bool messages = false;
        //private string myId;
        //private string[] toId;
        //private string[] request;
        //private string[] status;


        //private void myRequestsCoutAndexport()
        //{
        //    bool flag = false ;
        //    StreamReader sr = new StreamReader("requests.txt");
        //    string line = sr.ReadLine();
        //    while (line != null)
        //    {
        //        string[] details = line.Split(' ');

        //            if (details[0] == myId)
        //            {
        //                    count++;
        //                    messages = true;

        //            }


        //            line = sr.ReadLine();

        //    }

        //    toId = new string[count];
        //    request = new string[count];
        //    status = new string[count];
        //    sr.Close();
        //    sr = new StreamReader("requests.txt");
        //    line = sr.ReadLine();
        //    int i = 0,del;
        //    while (line != null && messages)
        //    {
        //        string[] details = line.Split(' ');
        //        if (details[0] == "EOMessage")//"EOMessage"
        //        {
        //            if (flag)
        //            {
        //                status[i] = details[1];
        //                i++;
        //            }
        //            flag = false;
        //        }

        //        else if (flag)
        //            request[i] += line + "\r\n";

        //        else if (details[0] == myId)
        //        {
        //            toId[i] = details[1];
        //            del = details[0].Length + details[1].Length + 2;
        //            request[i] += line.Remove(0, del);
        //            request[i] += "\r\n";
        //            flag = true;
        //        }

        //        line = sr.ReadLine();
        //    }
        //    sr.Close();



        //}

        //private void showRequestsDGV()
        //{
        //    DataTable dt = new DataTable();
        //    string[] columnnames = { "Request from" };
        //    foreach (string c in columnnames)
        //        dt.Columns.Add(c);
        //    foreach (string c in toId)
        //        if (c != null)
        //            dt.Rows.Add(c);
        //    dataGridView.DataSource = dt;
        //}
        public InstructorViewRequests()
        {
            InitializeComponent();
            fromLBL.Text = "";
            toLBL.Text = "";
            requestLBL.Text = "";
            statusLBL.Text = "";
            myId = getData("user.txt")[0];
            myRequestsCout();
            myRequestsExport();
            dataGridView.DataSource= showRequestsDGV();
        }
        private int selectedIndex = -1;
        public int count = 0;
        public bool messages = false;
        public string myId;
        public string[] fromId;
        public string[] request;
        public string[] status;
        public string[] UserDetails;
        public DataTable showRequestsDGV()
        {
            DataTable dt = new DataTable();
            string[] columnnames = { "Request from" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
            foreach (string c in fromId)
                if (c != null)
                    dt.Rows.Add(c);
            return dt;
        }
        public string[] getData(string path, string key = null)
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

        public void myRequestsCout()
        {
            StreamReader sr = new StreamReader("requests.txt");
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
        public void myRequestsExport()
        {
            bool flag = false;
            fromId = new string[count];
            request = new string[count];
            status = new string[count];
            StreamReader sr = new StreamReader("requests.txt");
            string line = sr.ReadLine();
            int i = 0, del;
            while (line != null && messages)
            {
                string[] details = line.Split(' ');
                if (details[0] == "EOMessage")//"EOMessage"
                {
                    if (flag)
                    {
                        status[i] = details[1];
                        i++;
                    }
                    flag = false;
                }

                else if (flag)
                    request[i] += line + "\r\n";

                else if (details[0] == myId)
                {
                    fromId[i] = details[1];
                    del = details[0].Length + details[1].Length + 2;
                    request[i] += line.Remove(0, del);
                    request[i] += "\r\n";
                    flag = true;
                }

                line = sr.ReadLine();
            }
            sr.Close();
        }
        private void backBTN_Click(object sender, EventArgs e)
        {
                this.Hide();
                InstructorMain f8 = new InstructorMain();
                f8.Show();
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedIndex = dataGridView.CurrentRow.Index;
            if (messages && selectedIndex < count)
            {
                fromLBL.Text = fromId[selectedIndex];
                toLBL.Text = myId;
                requestLBL.Text = request[selectedIndex];
                statusLBL.Text = status[selectedIndex];
            }
            else errorLBL.Text = "No Requests";
        }

        private void InstructorViewRequests_Load(object sender, EventArgs e)
        {
            if (!messages) errorLBL.Text = "you Havent Sent Any Requests";
            else errorLBL.Text = "";
        }
    }
}
