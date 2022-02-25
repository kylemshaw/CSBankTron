using BankTron_WinFormsUI.CustomControls;
using BankTronBusinessLogic;
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
    public partial class frmAddEditBudget : Form
    {
        public Budget Budget;
        public bool IsAdd;


        public frmAddEditBudget()
        {
            InitializeComponent();
        }        

        private void frmAddEditBudget_Load(object sender, EventArgs e)
        {
            if (IsAdd)
            {
                this.Text = "Add New Budget";
                Budget.BudgetGroups = new List<BudgetGroup>();
            }
            else
            {
                this.Text = "Edit Budget";
                //LoadSelectedBudget();
                LoadBudgetGroups();
            }
                       

        }

        private void txtBudgetValue_TextChanged(object sender, EventArgs e)
        {
            decimal value;
            if (Decimal.TryParse(txtBudgetValue.Text, out value))
            {
                Budget.Value = value;

                decimal percentAllocated = CalculatePercentAllocated();
                txtPercentAllocated.Text = percentAllocated.ToString("p");
                txtAmountAllocated.Text = (percentAllocated * Budget.Value).ToString("c");

                LoadBudgetGroups();
            }
        }

        private void btnAddBudgetGroup_Click(object sender, EventArgs e)
        {
            frmAddEditBudgetGroup groupForm = new frmAddEditBudgetGroup(true);
            groupForm.Group = new BudgetGroup();

            DialogResult result = groupForm.ShowDialog();
            if (result == DialogResult.OK)
            {                
                Budget.BudgetGroups.Add(groupForm.Group);                
            }
           
            LoadBudgetGroups();
        }        

        private void btnSave_Click(object sender, EventArgs e)
        {
            Budget.Name = txtBudgetName.Text;
            Budget.Value = Decimal.Parse(txtBudgetValue.Text);            
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private decimal CalculatePercentAllocated()
        {
            decimal total = 0m;
            foreach (BudgetGroup group in Budget.BudgetGroups)
            {
                total += group.WeightInBudget;
            }
            return total;
        }

        private void LoadBudgetGroups()
        {
            flpBudgetGroups.Controls.Clear();

            foreach (BudgetGroup group in Budget.BudgetGroups)
            {
                var groupControl = new BudgetGroupControl(group, Budget.Value);
                flpBudgetGroups.Controls.Add(groupControl);
                groupControl.BudgetGroupEdit += budgetgroupControl_Edit;
                groupControl.BudgetGroupDelete += budgetgroupControl_Delete;

            }
        }
        void budgetgroupControl_Edit(object sender, EventArgs e)
        {
            LoadBudgetGroups();
        }

        void budgetgroupControl_Delete(object sender, EventArgs e)
        {
            LinkLabel deleteControl = (LinkLabel)sender;
            BudgetGroupControl bgcDeleted = (BudgetGroupControl)deleteControl.Parent.Parent.Parent;
            Budget.BudgetGroups.Remove(bgcDeleted.Group);
            LoadBudgetGroups();
        }
    }
}
