using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Question_bank
{
    class Connection
    {
        SqlConnection CNN;
        SqlCommand CMD;
        SqlDataReader DR;

        //Data Source=L3-PC163;Initial Catalog=Question_bank;Integrated Security=True FOR LABWORK
        //Data Source=RAJDEEPDHARAVIY;Initial Catalog=Question_Bank;Integrated Security=True FOR RAJDEEP'S PERSONAL LAPTOP
        static string Cnstr = "Data Source=L3-PC163;Initial Catalog=Question_bank;Integrated Security=True";
       //static string Q= "";// Select , insert or update Query 

        //Insert function 
        public void InsertStudInfo(string Qry) {
            CNN = new SqlConnection(Cnstr);
            CMD = new SqlCommand(Qry, CNN);
            CNN.Open();
            CMD.ExecuteNonQuery();
            CNN.Close();

            //  DR = CMD.ExecuteReader();
            // Example of getting text direct to lable 
            //DR.Read();
            //lblName.text = DR["Field_Name"].ToString();
            //DR.Close();
            //CNN.Close();
            // For choose randomly question use for 
        }

        public string DisplayLabel(string Qry) {
            string lblText="";
            CNN = new SqlConnection(Cnstr);
            CMD = new SqlCommand(Qry, CNN);
            CNN.Open();
            DR = CMD.ExecuteReader();
            //Example of getting text direct to lable 
            DR.Read();
            lblText = DR["Field_Name"].ToString();
            DR.Close();
            CNN.Close();
            return lblText;
            //For choose randomly question use for loop
        }
    }
}
