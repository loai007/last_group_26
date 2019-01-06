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
    public partial class studentViewRequests : Form
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
        
        //int count = 0;
        //private bool messages = false;
        //string myId;
        //string[] fromId;
        //string[] request;
        //string[] status;
        //private void myRequestsCoutAndexport()
        //{

        //    bool flag = false;
        //    StreamReader sr = new StreamReader("requests.txt");
        //    string line = sr.ReadLine();
        //    while (line != null)
        //    {
        //        string[] details = line.Split(' ');

        //        if (details[0] == myId)
        //        {
        //            count++;
        //            messages = true;

        //        }


        //        line = sr.ReadLine();

        //    }

        //    fromId = new string[count];
        //    request = new string[count];
        //    status = new string[count];
        //    sr.Close();
        //    sr = new StreamReader("requests.txt");
        //    line = sr.ReadLine();
        //    int i = 0, del;
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
        //            fromId[i] = details[1];
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
        //    foreach (string c in fromId)
        //        if (c != null)
        //            dt.Rows.Add(c);
        //    dataGridView.DataSource = dt;
        //}
        public studentViewRequests()
        {
            InitializeComponent();
            fromLBL.Text = "";
            toLBL.Text = "";
            requestLBL.Text = "";
            statusLBL.Text = "";
            reqObj.myRequestsCout();
            reqObj.myRequestsExport();
            dataGridView.DataSource= reqObj.showRequestsDGV();
            
        }
        private Requests reqObj = new Requests();
        private int selectedIndex = -1;

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedIndex = dataGridView.CurrentRow.Index;
            if (reqObj.messages && selectedIndex < reqObj.count)
            {
                fromLBL.Text = reqObj.fromId[selectedIndex];
                toLBL.Text = reqObj.myId;
                requestLBL.Text = reqObj.request[selectedIndex];
                statusLBL.Text = reqObj.status[selectedIndex];
            }
            else errorLBL.Text = "No Requests";
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentMain f8 = new studentMain();
            f8.Show();
        }

        private void studentViewRequests_Load(object sender, EventArgs e)
        {
            if (!reqObj.messages) errorLBL.Text = "You Haven't Sent Any Requests";
            else errorLBL.Text = "";
        }
    }
}
