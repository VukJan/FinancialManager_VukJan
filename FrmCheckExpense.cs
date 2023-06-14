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
    public partial class FrmCheckExpense : Form
    {
        Baza fn = new Baza();
        Expense e1 = new Expense();
        public FrmCheckExpense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCheckExpense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvCheckExpense.Rows[e.RowIndex].Cells[0].Value.ToString();
            string name = dgvCheckExpense.Rows[e.RowIndex].Cells[1].Value.ToString();
            decimal amount = Convert.ToDecimal(dgvCheckExpense.Rows[e.RowIndex].Cells[2].ToString());
            bool needed = Convert.ToBoolean(dgvCheckExpense.Rows[e.RowIndex].Cells[3].ToString());
            string description = dgvCheckExpense.Rows[e.RowIndex].Cells[4].Value.ToString();


            e1.ID = Convert.ToInt32(id);
            e1.Name = name;        
            e1.Price = amount;
            e1.Needed = needed;
            e1.Description = description;

        }

        private void FrmCheckExpense_Load(object sender, EventArgs e)
        {
            string query1 = "Select * from Expenses";
            DataSet ds = fn.getData(query1);
            dgvCheckExpense.DataSource = ds.Tables[0];
        }
    }
}
