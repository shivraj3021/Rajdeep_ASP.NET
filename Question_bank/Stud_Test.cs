using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_bank
{
    public partial class Stud_Test : Form
    {
        // This link is for database to label text
        //https://www.codeproject.com/Questions/447164/TO-DISPLAY-DATA-FROM-SQL-SERVER-INTO-A-LABEL-NAME
        public Stud_Test()
        {
            InitializeComponent();
        }

        TextBox[] textBoxes = new TextBox[n];
        RadioButton[] rdA = new RadioButton[n];
        RadioButton[] rdB = new RadioButton[n];
        RadioButton[] rdC = new RadioButton[n];
        RadioButton[] rdD = new RadioButton[n];
        Label[] labels = new Label[n];
        Label[] labelAns = new Label[n];
        Sem_1 st = new Sem_1();
        Connection cn;
        static string Qry = "";
        static int n =3;
        //static int left = 5;
        //static int right = 5;

        private void Stud_Test_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(st.sendNo().ToString());

            Label lblQuestion = new Label();
            lblQuestion.Left = 10;
            lblQuestion.Top = 10;
            lblQuestion.Text = "QUESTIONS";
            this.Controls.Add(lblQuestion);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //  DR = CMD.ExecuteReader();
            // Example of getting text direct to lable 
            //DR.Read();
            //lblName.text = DR["Field_Name"].ToString();
            //DR.Close();
            //CNN.Close();
            // For choose randomly question use for loop

           // cn = new Connection();
            //labels[i].Text = cn.DisplayLabel(Qry);

            //Data Source=L3-PC163;Initial Catalog=Question_bank;Integrated Security=True FOR LABWORK
            //Data Source=RAJDEEPDHARAVIY;Initial Catalog=Question_Bank;Integrated Security=True FOR RAJDEEP'S PERSONAL LAPTOP
            SqlConnection cnn = new SqlConnection("Data Source=L3-PC163;Initial Catalog=Question_bank;Integrated Security=True");
            SqlDataReader dr = null;
            SqlCommand cmd ;
            
           
            //MessageBox.Show(dr["Question"].ToString());

            int al = 0;
            
            for (int i = 0; i < n; i++)
            {
                int alA = 2;
                cmd = new SqlCommand("SELECT * FROM Questions WHERE (Is_Available='True' AND SrNo="+(i+1)+") AND Subject='CPP'", cnn);
                cnn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
             
                labels[i] = new Label();
                labels[i].Left = 10;
                labels[i].Top = (al + 1) * 40;
                al=al+4;
                labels[i].Width = 400;
                labels[i].Text = dr["Question"].ToString();
                this.Controls.Add(labels[i]);

                rdA[i] = new RadioButton();
                rdA[i].Left = 200;
                rdA[i].Top = (alA + 2) * 60;
                rdA[i].Name = "rdA"+(i+1);
                rdA[i].Text = dr["Opt_A"].ToString();
                this.Controls.Add(rdA[i]);


                rdB[i] = new RadioButton();
                rdB[i].Left = 350;
                rdB[i].Top = (alA + 2) * 60;
                rdB[i].Name = "rdB" + (i + 1);
                rdB[i].Text = dr["Opt_B"].ToString();
                this.Controls.Add(rdB[i]);


                rdC[i] = new RadioButton();
                rdC[i].Left = 500;
                rdC[i].Top = (alA + 2) * 60;
                rdC[i].Name = "rdC" + (i + 1);
                rdC[i].Text = dr["Opt_C"].ToString();
                this.Controls.Add(rdC[i]);


                rdD[i] = new RadioButton();
                rdD[i].Left = 650;
                rdD[i].Top = (alA + 2) * 60;
                rdD[i].Name = "rdD" + (i + 1);
                rdD[i].Text = dr["Opt_D"].ToString();
                this.Controls.Add(rdD[i]);

                labelAns[i] = new Label();
                labelAns[i].Left = 800;
                labelAns[i].Top = (alA + 2) * 60;
                labelAns[i].Text = dr["Ans"].ToString();
                labelAns[i].Visible = true;
                this.Controls.Add(labelAns[i]);
                al++;
                alA++;
                cnn.Close();
            }
        }
    }
}
