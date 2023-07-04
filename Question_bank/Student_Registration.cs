using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_bank
{
    public partial class StudentRegisteration : Form
    {
        public StudentRegisteration()
        {
            InitializeComponent();
        }
        Connection CN;
        static string Qry = "";

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Teacher().Show();
            this.Hide();
            
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Qry = "INSERT INTO Students ";
            Qry += "SELECT MAX(SrNo)+1, ";
            Qry += " " + txtRollNo.Text.Trim() + ", ";
            Qry += "'" + txtName.Text.Trim() + "', ";
            // Gender
            if (rdbMale.Checked)
                Qry += "'TRUE', ";
            else
                Qry += "'FALSE', ";

            Qry += "'" + cmbSem.SelectedItem + "', ";
            Qry += "'" + cmbSubject.SelectedItem + "', ";
            Qry += "'" + dtPicker.Text + "', ";
            Qry += "'" + txtEmail.Text + "', ";
            Qry += "" + txtPhone.Text + ", "+txtTotal.Text+",0,'TRUE'";
            Qry += "FROM Students ";

            //Object Initalize
            //CN = new Connection();
            //CN.InsertStudInfo(Qry);

            new Stud_Test().Show();
            this.Hide();
        }
         private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbfemale_CheckedChanged(object sender, EventArgs e)
        {

        }

      

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentRegisteration_Load(object sender, EventArgs e)
        {

        }
    }
}
