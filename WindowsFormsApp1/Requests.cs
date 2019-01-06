using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    class Requests
    {
        public Requests()
        {
            UserDetails = getData("user.txt");
            myId = UserDetails[0];
            ///ToDO
            /// dataGridView.DataSource = dt;
            /// myRequestsCout();
            /// myRequestsexport();\ ChangeStatusForRequest(holeRequest, newStatus);
            /// errorLBL.ForeColor = System.Drawing.Color.Black;
            /// errorLBL.Text = "Request " + newStatus;

        }
        public int count = 0;
        public bool messages = false;
        public string myId;
        public string[] fromId;
        public string[] request;
        public string[] status;
        public string[] UserDetails;
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
        public void RequestsCout()
        {
            StreamReader sr = new StreamReader("requests.txt");
            string line = sr.ReadLine();
            messages = false;
            string[] details;
            while (line != null)
            {
                 details = line.Split(' ');
                if (details.Length >= 2)
                {
                    if (details[1] == myId)
                    {
                        //flagbinding = true;

                        while (line != null && details[0] != "EOMessage")
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
                }
                
                    line = sr.ReadLine();

            }
            sr.Close();

        }
        public void RequestsExport() {

            fromId = new string[count + 1];
            request = new string[count + 1];
            status = new string[count + 1];
            
            var sr = new StreamReader("requests.txt");
            string line = sr.ReadLine();
            int i = 0, del;
            while (line != null && messages)
            {
                //first part of every message/request 
                string[] details = line.Split(' ');
                if (details.Length >= 2)
                    if (details[1] == myId)
                    {
                        request[i] = "";
                        fromId[i] = details[0];
                        del = details[0].Length + details[1].Length + 2;
                        request[i] += line.Remove(0, del);
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
                        else fromId[i] = null;
                    }
                line = sr.ReadLine();
            }
            sr.Close();

        }
        public bool doesntExist(string path, string key1)
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

        public DataTable showInstructors()
        {
            StreamReader sr = new StreamReader("instructor.txt");
            string line = sr.ReadLine();
            DataTable dt = new DataTable();
            //Initialize Grid View
            string[] columnnames = { "ID", "Name", "Last Name", "Department", "Course", "Phone Numer" };
            foreach (string c in columnnames)
                dt.Columns.Add(c);
            while (line != null)
            {
                string[] details = line.Split(' ');
                if (details.Length >= 9)
                {
                    string[] showLine = { details[0], details[2], details[3], details[4], details[5], details[8] };
                    dt.Rows.Add(showLine);
                }
                else
                {
                    sr.Close();
                    break;
                }
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            return dt;

        }

        public DataTable showManagers()
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
                    sr.Close();
                    break;
                }
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            return dt;

        }

        public void addToRequests(string req, string fromId, string toId)
        {
            StreamWriter sw = new StreamWriter("requests.txt", true);
            string status = "binding";
            string line = fromId + ' ' + toId + ' ' + req + "\r\nEOMessage " + status;
            sw.WriteLine(line);
            sw.Close();
        }

        public void ChangeStatusForRequest(string holeRequest, string newStatus)
        {
            bool found = true;
            string[] Lines = File.ReadAllLines("requests.txt");
            string requestFinder = "";
            File.Delete("requests.txt");// Deleting the file
            using (StreamWriter sw = File.AppendText("requests.txt"))

                for (int i = 0; i < Lines.Length; i++)
                {

                    if (found)
                    {
                        sw.WriteLine(Lines[i]);
                        requestFinder = Lines[i] + "\r\n";
                        found = false;

                    }
                    else
                    {

                        if (Lines[i].Split(' ')[0] == "EOMessage")
                        {
                            if (requestFinder + "EOMessage binding" == holeRequest)
                                sw.WriteLine("EOMessage " + newStatus);
                            else
                                sw.WriteLine(Lines[i]);
                            found = true;
                        }
                        else sw.WriteLine(Lines[i]);
                        requestFinder += Lines[i] + "\r\n";
                    }
                }
        }
        ///////////     Change status      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////     add Request      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////     Change status      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////     Change status      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    }
}
