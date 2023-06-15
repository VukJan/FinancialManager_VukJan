using FinancialManager_VukJan.Models___Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace FinancialManager_VukJan
{
    public partial class FrmUpdateIncomes : Form
    {
        Baza fn = new Baza();
        int id;
        public FrmUpdateIncomes(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            decimal amount = Convert.ToDecimal(txtAmount.Text);
            string description = txtDescription.Text;
            

            string query = "UPDATE Paycheck SET Name='" + name + "', Description='" + description + "', Amount='" + amount + "' where ID_Paycheck='" + id + "'";

            fn.setData(query,"Uspješno ste ažurirali podatke!");

        }
    }
}
