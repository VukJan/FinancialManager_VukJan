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
    public partial class FrmUpdateExpense : Form
    {
        public FrmUpdateExpense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*FrmAddExpense selectedExpense = dgvExpenses.CurrentRow.DataBoundItem as Expense;
            if (selectedExpense != null)
            {
                FrmUpdateExpenses frmUpdateExpenses = new FrmUpdateExpenses(selectedExpense);
                frmUpdateExpenses .ShowDialog();
            }
            */
        }
    }
}
