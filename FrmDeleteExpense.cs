using FinancialManager_VukJan.Models___Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManager_VukJan
{
    public partial class FrmDeleteExpense : Form
    {
        Baza fn = new Baza();
        public FrmDeleteExpense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Izbrisati trošak?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(cbmExpenseID.SelectedItem.ToString());
                string query = "delete from Expenses where ID_Expense='" + id + "'";
                fn.setData(query, "Trošak je izbrisan iz baze!");
            }
            else
            {
                MessageBox.Show("Trošak nije izbrisan!","Izbrisati trošak?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmDeleteExpense_Load(object sender, EventArgs e)
        {
            string query1 = "Select ID_Expense from Expenses";

            DataSet ds = fn.getData(query1);
            int[] Ids = new int[ds.Tables[0].Rows.Count];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Ids[i] = Convert.ToInt32(ds.Tables[0].Rows[i]["ID_Expense"]);

            }

            query1 = "select Name from Expenses";

            ds = fn.getData(query1);
            string[] name = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                name[i] = Convert.ToString(ds.Tables[0].Rows[i]["Name"]);
            }

            query1 = "Select Amount from Expenses";
            ds = fn.getData(query1);


            decimal[] price = new decimal[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                price[i] = Convert.ToDecimal(ds.Tables[0].Rows[i]["Amount"].ToString());

            }

            cbmExpenseID.DataSource = Ids;
            cbmExpenseName.DataSource = name;
            cbmExpensePrice.DataSource = price;
        }
    }
}
