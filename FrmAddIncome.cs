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
    public partial class FrmAddIncome : Form
    {
        Baza fn = new Baza();
        Random rnd = new Random();
        public FrmAddIncome()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            int value = rnd.Next(1, 20000);
            string query1 = "Select * from Paycheck where ID_Paycheck='" + value + "'";
            DataSet ds = fn.getData(query1);

            while (ds.Tables.Count < 0)
            {
                value = rnd.Next(1, 20000);

                query1 = "Select * from Paycheck where ID_Paycheck='" + value + "'";
                ds = fn.getData(query1);
            }

            Income ic = new Income
            {
                ID = value,
                Name = txtIncomeName.Text,
                Description = txtIncomeDescription.Text,
                Amount = Convert.ToDecimal(txtIncomeAmount.Text),

            };

            string query = "Insert into Paycheck (ID_Paycheck, Name, Amount, Description) values('" + ic.ID + "','" + ic.Name + "','" + ic.Amount + "','" + ic.Description + "') ";

            fn.setData(query, "Prihod uspješno unesen!");
        }
    }
}
