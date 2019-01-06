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
        //private int count = 0;
        //private bool messages = false;
        //private int selectedIndex = -1;
        //private string myId;
        //private string[] fromId;
        //private string[] request;
        //private string[] status;

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
        //private void myRequestsCoutAndexport()
        //{
        //    StreamReader sr = new StreamReader("requests.txt");
        //    string line = sr.ReadLine();
        //    messages = false;
        //    while (line != null)
        //    {
        //        string[] details = line.Split(' ');
        //        if (details.Length >= 2)
        //        {
        //            if (details[1] == myId)
        //            {
        //                //flagbinding = true;

        //                while (line != null && details[0] != "EOMessage")
        //                {
        //                    details = line.Split(' ');
        //                    line = sr.ReadLine();
        //                }
        //                if (details[1] == "binding")
        //                {
        //                    count++;
        //                    messages = true;
        //                }
        //            }
        //        }
        //        else
        //            line = sr.ReadLine();

        //    }
        //    fromId = new string[count+1];
        //    request = new string[count+1];
        //    status = new string[count + 1];
        //    sr.Close();
        //    sr = new StreamReader("requests.txt");
        //    line = sr.ReadLine();
        //    int i = 0,del;
        //    while (line != null && messages)
        //    {
        //        //first part of every message/request 
        //        string[] details = line.Split(' ');
        //        if (details.Length >= 2)
        //            if (details[1] == myId)
        //            {
        //                request[i] = "";
        //                fromId[i] = details[0];
        //                del = details[0].Length + details[1].Length + 2;
        //                request[i] += line.Remove(0,del);/* " " + details[c];*/
        //                request[i] += "\r\n";

        //                //secoud part where the masseage is
        //                line = sr.ReadLine();
        //                details = line.Split(' ');
        //                while (line != null)
        //                {
        //                    details = line.Split(' ');
        //                    if (details[0] == "EOMessage") break;
        //                    request[i] += line + "\r\n";
        //                    line = sr.ReadLine();
        //                }
        //                //lastpart where the EOMessage
        //                if (details[1] == "binding")
        //                {
        //                    status[i] = details[1];
        //                    i++;
        //                }
        //                else fromId[i] = null ;
        //            }
        //            line = sr.ReadLine();
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
        //        if (c!=null)
        //            dt.Rows.Add(c);
        //    dataGridView.DataSource = dt;

        //}
        //private void ChangeStatusForRequest(string holeRequest,string newStatus)
        //{
        //    bool found = true;
        //    string[] Lines = File.ReadAllLines("requests.txt");
        //    string requestFinder="";
        //    File.Delete("requests.txt");// Deleting the file
        //    using (StreamWriter sw = File.AppendText("requests.txt"))

        //        for (int i = 0; i < Lines.Length; i++)

        //            if (found)
        //            {
        //                sw.WriteLine(Lines[i]);
        //                requestFinder = Lines[i]+"\r\n";
        //                found = false;

        //            }
        //            else
        //            {

        //                if (Lines[i].Split(' ')[0] == "EOMessage")
        //                {
        //                    if (requestFinder + "EOMessage binding" == holeRequest)
        //                        sw.WriteLine("EOMessage " + newStatus);
        //                    else
        //                        sw.WriteLine(Lines[i]);
        //                    found = true;
        //                }
        //                else sw.WriteLine(Lines[i]);
        //                requestFinder += Lines[i] + "\r\n";
        //            }


        //    errorLBL.ForeColor = System.Drawing.Color.Black;
        //    errorLBL.Text = "Request " + newStatus;



        //}
        public ManagerAnswerRequests()
        {
            InitializeComponent();
            errorLBL.Text = "";
        }
        private Requests ReqObj = new Requests();
        private int selectedIndex = -1;


        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedIndex = dataGridView.CurrentRow.Index;
            if (ReqObj.messages && selectedIndex<= ReqObj.count)
            {
                errorLBL.Text = "";
                fromLBL.Text = ReqObj.fromId[selectedIndex];
                toLBL.Text = ReqObj.myId;
                requestLBL.Text = ReqObj.request[selectedIndex];
                statusLBL.Text = ReqObj.status[selectedIndex];
            }
            else errorLBL.Text = "No Requests";
        }

        private void approveBTN_Click(object sender, EventArgs e)
        {
            if (selectedIndex > -1 && selectedIndex <= ReqObj.count)
            {
                ReqObj.status[selectedIndex] = "Approved";
                string holeRequest= fromLBL.Text+ " " + toLBL.Text + " " + requestLBL.Text + "EOMessage " + statusLBL.Text;
                ReqObj.ChangeStatusForRequest(holeRequest, "Approved");
                ReqObj.RequestsCout();
                ReqObj.RequestsExport();
                dataGridView.DataSource = ReqObj.showRequestsDGV();
            }
        }

        private void DenyBTN_Click(object sender, EventArgs e)
        {
            if (selectedIndex > -1 && selectedIndex <= ReqObj.count)
            {
                ReqObj.status[selectedIndex] = "Denied";
                string holeRequest = fromLBL.Text + " " + toLBL.Text + " " + requestLBL.Text + "EOMessage " + statusLBL.Text;
                ReqObj.ChangeStatusForRequest(holeRequest, "Denied");
                ReqObj.RequestsCout();
                ReqObj.RequestsExport();
                dataGridView.DataSource = ReqObj.showRequestsDGV();
            }
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMain b = new ManagerMain();
            b.Show();
        }

        private void ManagerAnswerRequests_Load(object sender, EventArgs e)
        {
            
            fromLBL.Text = "";
            toLBL.Text = "";
            requestLBL.Text = "";
            statusLBL.Text = "";
            ReqObj.myId = ReqObj.getData("user.txt")[0];
            ReqObj.RequestsCout();
            ReqObj.RequestsExport();
            dataGridView.DataSource= ReqObj.showRequestsDGV();
            
        }
    }
}
