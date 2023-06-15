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
    public partial class FrmUpdateIncome : Form
    {
        Baza fn = new Baza();
        public FrmUpdateIncome()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        int idValue;
        private void FrmUpdateIncome_Load(object sender, EventArgs e)
        {
            string query = "Select * from Paycheck";
            DataSet ds = fn.getData(query); 
            dgvUpdateIncome.DataSource = ds.Tables[0];
        }

        

        private void dgvUpdateIncome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvUpdateIncome.Rows[e.RowIndex].Cells[0].Value.ToString();
            idValue = Convert.ToInt32(id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateIncomes frm = new FrmUpdateIncomes(idValue);
            frm.BringToFront();
            frm.ShowDialog();
            
        }
    }
}
