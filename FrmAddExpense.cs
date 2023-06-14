using System;
using FinancialManager_VukJan.Models___Classes;
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
        Baza fn = new Baza();
        Random rndom = new Random();

        public FrmAddExpense()
        {
            InitializeComponent();
        }


       

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void FrmAddExpense_Load(object sender, EventArgs e)
        {
            cbmNeeded.Items.Add("Da");
            cbmNeeded.Items.Add("Ne");

            cbmNeeded.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int value = rndom.Next(1,20000);
            string query1 = "Select * from Paycheck where ID_Paycheck='" + value + "'";
            DataSet ds = fn.getData(query1);

            while(ds.Tables.Count < 0)
            {
                value = rndom.Next(1, 20000);

                query1 = "Select ID, Name, Price, Description, Needed from Paycheck where ID_Paycheck='" + value + "'";
                ds = fn.getData(query1);
            }
            bool flag = false;

            if (cbmNeeded.SelectedIndex.ToString() == "Yes")
            {
                flag = true;
            }
            Expense ec = new Expense
            {
                ID = value,
                Name = txtExpenseName.Text,
                Description = txtExpenseDescription.Text,
                //DateTime = datePicker1.Value.Date,
                Price = Convert.ToDecimal(txtExpenseAmount.Text),
                Needed = flag

            };

            string query = "Insert into Expenses (ID_Expense, Name, Amount, Description, Needed) values ('" + ec.ID + "','" + ec.Name + "','" + ec.Price + "','" + ec.Description + "','" /* + ec.DateTime + "','" */ + ec.Needed + "') ";

            fn.setData(query, "Uspješno uneseni trošak!");

        }

        
    }
}
