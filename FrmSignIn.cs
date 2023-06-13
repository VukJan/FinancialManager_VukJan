using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace FinancialManager_VukJan
{
    public partial class FrmSignIn : Form
    {
        string username = "test";
        string password = "test";
        public FrmSignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime ne smije biti prazno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtPassword.Text == "")
                {
                MessageBox.Show("Polje lozinke ne smije biti prazno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtUsername.Text == username && txtPassword.Text == password)
                    {
                    FrmSystem frmSystem = new FrmSystem();
                    Hide();
                    frmSystem.ShowDialog();
                    Close();
                }
                else 
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnEye.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnEyeclose_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnEyeclose.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
