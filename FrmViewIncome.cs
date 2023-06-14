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
    public partial class FrmViewIncome : Form
    {
        Baza fn = new Baza();
        public FrmViewIncome()
        {
            InitializeComponent();
        }
        Income ic = new Income();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvViewIncome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvViewIncome.Rows[e.RowIndex].Cells[0].Value.ToString();
            string name = dgvViewIncome.Rows[e.RowIndex].Cells[1].Value.ToString();        
            decimal amount = Convert.ToDecimal(dgvViewIncome.Rows[e.RowIndex].Cells[2].Value.ToString());
            string description = dgvViewIncome.Rows[e.RowIndex].Cells[3].Value.ToString();


            ic.ID = Convert.ToInt32(id);
            ic.Name = name;
            ic.Amount = amount;
            ic.Description = description;
        }

        private void FrmViewIncome_Load(object sender, EventArgs e)
        {
            string query = "Select * from Paycheck";
            DataSet ds = fn.getData(query);
            dgvViewIncome.DataSource = ds.Tables[0];
        }

      
    }
}
