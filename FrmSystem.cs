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
    public partial class FrmSystem : Form
    {
        public FrmSystem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmAddExpense frmAddExepense = new FrmAddExpense();
            
            frmAddExepense.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckExpense_Click(object sender, EventArgs e)
        {
            FrmCheckExpense frmCheckExpense = new FrmCheckExpense();

            frmCheckExpense.ShowDialog();
        }

        private void btnUpdateExpense_Click(object sender, EventArgs e)
        {
            FrmUpdateExpense frmUpdateExpense = new FrmUpdateExpense();
            frmUpdateExpense.ShowDialog();
        }

        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            FrmDeleteExpense frmDeleteExpense = new FrmDeleteExpense();
            frmDeleteExpense.ShowDialog();
        }

        private void FrmSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = exit = MessageBox.Show("Jeste li sigurni da želite izaći?", "Izlaz", MessageBoxButtons.YesNo);
            if (exit == DialogResult.No) 
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void btnPaycheck_Click(object sender, EventArgs e)
        {
            FrmAddIncome frmPaycheck = new FrmAddIncome();

            frmPaycheck.ShowDialog();
        }

        private void btnIXO_Click(object sender, EventArgs e)
        {
            FrmIncomeXOutcome frmIncomeXOutcome = new FrmIncomeXOutcome();
            frmIncomeXOutcome.ShowDialog();
        }

        private void btnViewIncome_Click(object sender, EventArgs e)
        {
            FrmViewIncome frmViewIncome = new FrmViewIncome();
            frmViewIncome.ShowDialog();
        }

        private void btnUpdateIncome_Click(object sender, EventArgs e)
        {
            FrmUpdateIncome frmUpdateIncome = new FrmUpdateIncome();
            frmUpdateIncome.ShowDialog();
        }

        private void btnDeleteIncome_Click(object sender, EventArgs e)
        {
            FrmDeleteIncome frmDeleteIncome = new FrmDeleteIncome();
            frmDeleteIncome.ShowDialog();
        }
    }
}
