using BankTronSQLiteData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankTron_WinFormsUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImport importForm = new frmImport();
            DialogResult result = importForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                //notify import was success
            }
        }

        private void btnCreateBudget_Click(object sender, EventArgs e)
        {
            frmAddEditBudget budgetForm = new frmAddEditBudget();
            budgetForm.IsAdd = true;
            budgetForm.Budget = new Budget();

            DialogResult result = budgetForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //notify of success
            }
        }
    }
}
