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
            if (MessageBox.Show("Are you sure?", "Izbrisati Prihod", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
            else
            {
                MessageBox.Show("Prihod nije izbrisan!", "Izbrisati Prihod?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
