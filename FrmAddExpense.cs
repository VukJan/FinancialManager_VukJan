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
            string maxIdQuery = "Select Max(ID_Expense) FROM Expenses";
            object result = fn.getData(maxIdQuery).Tables[0].Rows[0][0];
            int maxId = result != DBNull.Value ? Convert.ToInt32(result) : 0;


            int newId = maxId + 1;
            bool flag = false;

            if (cbmNeeded.SelectedIndex.ToString() == "Da")
            {
                flag = true;
            }

            Expense ec = new Expense()
            {
                ID = newId,
                Name = txtExpenseName.Text,
                Price = Convert.ToDecimal(txtExpenseAmount.Text),
                Description = txtExpenseDescription.Text,
                Needed = flag
            };

            string query = "Insert into Expenses (ID_Expense, Name, Amount, Description, Needed) values ('" + ec.ID + "','" + ec.Name + "','" + ec.Price + "','" + ec.Description + "','" /* + ec.DateTime + "','" */ + ec.Needed + "') ";

            fn.setData(query, "Trošak uspješno unesen!");
       

        }

        
    }
}
