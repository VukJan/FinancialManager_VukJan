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
    public partial class FrmDeleteIncome : Form
    {
        Baza fn = new Baza();
        public FrmDeleteIncome()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteIncome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Izbrisati Prihod", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(cbmIncomeID.SelectedItem.ToString());
                string query = "Delete from Paycheck where ID_Paycheck='" + id + "'";
                fn.setData(query, "Prihod je uspješno izbrisan!");
                
            }
            else
            {
                MessageBox.Show("Prihod nije izbrisan!", "Izbrisati Prihod?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmDeleteIncome_Load(object sender, EventArgs e)
        {
            string query = "Select ID_Paycheck from Paycheck";

            DataSet ds = fn.getData(query);
            int[] Ids = new int[ds.Tables[0].Rows.Count];

            for (int i = 0; i< ds.Tables[0].Rows.Count; i++)
            {
                Ids[i] = Convert.ToInt32(ds.Tables[0].Rows[i]["ID_Paycheck"]);
            }

            query = "Select Name from Paycheck";

            ds = fn.getData(query);

            string[] name = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                name[i] = Convert.ToString(ds.Tables[0].Rows[i]["Name"].ToString());
            }

            query = "Select Amount from Paycheck";

            ds = fn.getData(query);

            decimal[] amount = new decimal[ds.Tables[0].Rows.Count];

            for (int i = 0; i< ds.Tables[0].Rows.Count; i++)
            {
                amount[i] = Convert.ToDecimal(ds.Tables[0].Rows[i]["Amount"].ToString());
            }

            cbmIncomeID.DataSource = Ids;
            cbmIncomeName.DataSource = name;
            cbmIncomePrice.DataSource = amount;


        }
    }
}
