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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            Add_Question aq = new Add_Question();
            aq.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Test ts = new Test();
            ts.Show();
        }
    }
}
