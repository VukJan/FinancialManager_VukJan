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

            string maxIdQuery = "Select MAX(ID_Paycheck) FROM Paycheck";
            object result = fn.getData(maxIdQuery).Tables[0].Rows[0][0];
            int maxId = result != DBNull.Value ? Convert.ToInt32(result) : 0;


            int newID = maxId + 1;

            Income ic = new Income
            {
                ID = newID,
                Name = txtIncomeName.Text,
                Amount = Convert.ToDecimal(txtIncomeAmount.Text),
                Description = txtIncomeDescription.Text,
            };

            string query = "Insert INTO Paycheck (ID_Paycheck, Name, Amount, Description) values('" + +ic.ID + "','" + ic.Name + "','" + ic.Amount + "','" + ic.Description + "') ";

            fn.setData(query, "Prihod je uspješno unesen!");
         
          
        }
    }
}
