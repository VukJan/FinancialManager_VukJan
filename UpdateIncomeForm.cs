using FinancialManager_VukJan.Models___Classes;
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
    public partial class UpdateIncomeForm : Form
    {
        db fn=new db();
        string id;
        public UpdateIncomeForm()
        {
            InitializeComponent();
        }
        public UpdateIncomeForm(string id)
        {
            InitializeComponent();
            this.id = id;   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            Income ic = new Income
            {
                Name = txtIncomeName.Text,
                Description = txtIncomeDescription.Text,
                DateTime = DateTime.Now,
                Amount = Convert.ToDecimal(txtIncomeAmount.Text),
            };

            string query = "update Paycheck set Name='" + ic.Name + "',Amount='" + ic.Amount + "',Description='" + ic.Description + "',Date='" + ic.DateTime + "' where  ID_Paycheck='" + id + "' ";

            fn.setData(query, "Record Updated in pay check");
        }
    }
}
