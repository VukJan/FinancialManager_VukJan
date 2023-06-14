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
    public partial class IncomeMoreDetail : Form
    {
        Income icc = null;

        Expense ic1 = null;
      
        public IncomeMoreDetail()
        {
            InitializeComponent();
        }
        public IncomeMoreDetail(Income ic)
        {
            icc = new Income();
           icc = ic;
            InitializeComponent();
        }
        public IncomeMoreDetail(Expense ic)
        {
            ic1 = new Expense();    
            ic1 = ic;
            InitializeComponent();
        }

        private void IncomeMoreDetail_Load(object sender, EventArgs e)
        {
            if(icc==null ) 
            {
                label1.Visible = false;
            }
            if(icc!=null)
            {
                label1.Text += "ID : "+icc.ID + "\n";
                label1.Text += "NAME : " + icc.Name + "\n";
                label1.Text += "DESCRIPTION : " + icc.Description + "\n";
                label1.Text += "AMOUNT : " + icc.Amount + "\n";
                label1.Text += "DATE : " + icc.DateTime + "\n";
            }

            if(ic1==null )
            {
                label2.Visible = false;
            }
           if(ic1!=null) 
            {
                label2.Text += "ID : " + ic1.ID + "\n";
                label2.Text += "NAME : " + ic1.Name + "\n";
                label2.Text += "DESCRIPTION : " + ic1.Description + "\n";
                label2.Text += "PRICE : " + ic1.Price + "\n";
                label2.Text += "DATE : " + ic1.DateTime + "\n";
                label2.Text += "NEEDED : " + ic1.Needed + "\n";

            }

        }
    }
}
