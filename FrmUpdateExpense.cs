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
    public partial class FrmUpdateExpense : Form
    {
        Baza fn = new Baza();
        public FrmUpdateExpense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        int idValue;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateExpenses frm = new FrmUpdateExpenses(idValue);

            frm.BringToFront();
            frm.ShowDialog();
        }

        private void FrmUpdateExpense_Load(object sender, EventArgs e)
        {
            string query = "Select * from Expenses";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            idValue = Convert.ToInt32(id);
        }
    }
}
