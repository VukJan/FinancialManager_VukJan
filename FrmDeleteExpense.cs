using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManager_VukJan
{
    public partial class FrmDeleteExpense : Form
    {
        public FrmDeleteExpense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Izbrisati trošak?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
            else
            {
                MessageBox.Show("Expense is not deleted!","Izbrisati trošak?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}
