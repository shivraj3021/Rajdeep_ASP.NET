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
    public partial class Sem_1 : Form
    {
        public Sem_1()
        {
            InitializeComponent();
        }

        public int No;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Add_Question Ad = new Add_Question();
            Ad.Show();
        }

        private void btnSTest_Click(object sender, EventArgs e)
        {
            
        }

        // This function is not working throwing object to instance error 
        
        //public int sendNo() {
        //    int no = Int32.Parse(cmbQueNo.SelectedValue.ToString());
        //    return no;
        //}
    }
}
