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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            

            Dashboard ds = new Dashboard();
            this.Hide();
            ds.Show();   
        }

        
    }
}
