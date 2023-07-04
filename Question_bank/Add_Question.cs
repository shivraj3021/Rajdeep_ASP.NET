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
    public partial class Add_Question : Form
    {
        static string Qry = "";

        public Add_Question()
        {
            InitializeComponent();
        }

        private void Add_Question_Load(object sender, EventArgs e)
        {

        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            Qry = "INSERT INTO Questions ";
            Qry += "SELECT MAX(SrNo) + 1, ";
            Qry += "'"+txtQuestion.Text+"', ";
            Qry += "'" + txtOpA.Text + "', ";
            Qry += "'" + txtOpB.Text + "', ";
            Qry += "'" + txtOpC.Text + "', ";
            Qry += "'" + txtOpD.Text + "', ";
            Qry += "'" + txtAns.Text + "','TRUE' ";
            Qry += "FROM Questions ";

            // connection class insertion function
           new Connection().InsertStudInfo(Qry);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new Dashboard().Show();
        }
    }
}
