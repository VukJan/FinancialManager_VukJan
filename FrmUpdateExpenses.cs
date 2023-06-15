using FinancialManager_VukJan.Models___Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManager_VukJan
{
    public partial class FrmUpdateExpenses : Form
    {
        Baza fn = new Baza();

        int id2;
        public FrmUpdateExpenses(int id)
        {

            InitializeComponent();
            this.id2 = id;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string incomeName = txtName.Text; 
            string incomeDescription = txtDescription.Text;
            decimal incomeAmount = Convert.ToDecimal(txtAmount.Text);

            string query = "UPDATE Expenses SET Name='" + incomeName + "', Description='" + incomeDescription + "', Amount='" + incomeAmount + "' WHERE ID_Expense='" + id2 + "'";
            
            fn.setData(query,"Uspješno ste ažurirali podatke!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
