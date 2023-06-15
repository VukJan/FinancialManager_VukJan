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
    public partial class FrmIncomeXOutcome : Form
    {
        Baza fn = new Baza();
        public FrmIncomeXOutcome()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmIncomeXOutcome_Load(object sender, EventArgs e)
        {
            string query = "select * from Expenses";
            DataSet ds = fn.getData(query);
            dgvOutcome.DataSource = ds.Tables[0];

            query = "Select Amount from Expenses";

            ds = fn.getData(query);
            decimal ExpenseSum = 0;
            decimal[] priceOutcome = new decimal[ds.Tables[0].Rows.Count];


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                priceOutcome[i] = Convert.ToDecimal(ds.Tables[0].Rows[i]["Amount"].ToString());
                ExpenseSum += priceOutcome[i];
            }
            txtOutcome.Text = ExpenseSum.ToString();


            query = "Select * from Paycheck";
            ds = fn.getData(query);
            dgvIncome.DataSource = ds.Tables[0];

            query = "Select Amount from Paycheck";
            ds = fn.getData(query);
            decimal[] priceIncome = new decimal[ds.Tables[0].Rows.Count];
            decimal priceSum = 0;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) 
            {
                priceIncome[i] = Convert.ToDecimal(ds.Tables[0].Rows[i]["Amount"].ToString());
                priceSum += priceIncome[i];
            }
            txtIncome.Text = priceSum.ToString();

            decimal result = priceSum - ExpenseSum;
            txtTotal.Text = result.ToString();
        }
    }
}
