using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManager_VukJan
{
    public partial class FrmAddExpense : Form
    {
        public FrmAddExpense()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddExpense_Load(object sender, EventArgs e)
        {
            cbmNeeded.Items.Add("Yes");
            cbmNeeded.Items.Add("No");

            cbmNeeded.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void lblExpenseAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
