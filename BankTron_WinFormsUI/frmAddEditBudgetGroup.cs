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
    public partial class frmAddEditBudgetGroup : Form
    {       
        public BudgetGroup Group;
        private bool isAdd;

        public frmAddEditBudgetGroup(bool isAdd)
        {
            InitializeComponent();            
            this.isAdd = isAdd;
        }

        private void frmAddEditBudgetGroup_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                this.Text = "Add New Budget Group";
                Group.BudgetItems = new List<BudgetItem>();
            }
            else
            {
                this.Text = "Edit Group";
                LoadBudgetGroup();                               
            }                       

            UpdateDataGrid();

            // TODO:
            // Filter Categories. Do not allow categories that have already been added to the budget.
            // Will have to pass in a list from frmAddEditBudget
            // Fill Category Combo Box
            List<Category> categories = CategoryManager.GetAll();            
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "Name";            
        }        

        private void btnAddBudgetItem_Click(object sender, EventArgs e)
        {            
            if(Validator.IsPresent(txtGoalAmount) &&
               Validator.IsNonNegativeDecimal(txtGoalAmount))
            {
                BudgetItem item = new BudgetItem
                {
                    Category = (Category)cboCategory.SelectedItem,
                    GoalAmount = Decimal.Parse(txtGoalAmount.Text)
                };

                Group.BudgetItems.Add(item);
                UpdateDataGrid();
                                
                cboCategory.SelectedIndex = 0;
                txtGoalAmount.Text = string.Empty;
            }                        
        }       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string categoryName;
            BudgetItem deleteItem = new BudgetItem();

            foreach (DataGridViewRow row in dgvBudgetItems.SelectedRows) 
            {
                categoryName = row.Cells["CategoryName"].Value.ToString();
                
                foreach (BudgetItem item in Group.BudgetItems)
                {
                    if (item.Category.Name.Equals(categoryName))
                    {
                        // can't delete from list while iterating through it so save and exit loop
                        deleteItem = item;
                        break;
                    }
                }

                Group.BudgetItems.Remove(deleteItem);                                          
            }

            UpdateDataGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Validator.IsPresent(txtGroupName) &&
               Validator.IsPresent(txtWeightInBudget) &&
               Validator.IsNonNegativeDecimal(txtWeightInBudget))
            {
                // Save remaining data (BudgetList is updated on the fly)
                Group.Name = txtGroupName.Text;
                Group.WeightInBudget = Decimal.Parse(txtWeightInBudget.Text) / 100.0m;

                this.DialogResult = DialogResult.OK;
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;           
        }

        private void LoadBudgetGroup()
        {
            txtGroupName.Text = Group.Name;
            txtWeightInBudget.Text = (Group.WeightInBudget * 100.0m).ToString();
        }

        public void UpdateDataGrid()
        {
            dgvBudgetItems.DataSource = null;
            dgvBudgetItems.DataSource = CreateViews(Group.BudgetItems);

            // Category Name
            dgvBudgetItems.Columns[0].HeaderText = "Category";
            dgvBudgetItems.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBudgetItems.Columns[0].Width = 180;
            dgvBudgetItems.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Category Goal Amount
            dgvBudgetItems.Columns[1].HeaderText = "Goal Amount";
            dgvBudgetItems.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBudgetItems.Columns[1].Width = 120;
            dgvBudgetItems.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBudgetItems.Columns[1].DefaultCellStyle.Format = "c";

            //dgvBudgetItems.Width = 343; //Total width with selector column
        }

        public List<BudgetItemView> CreateViews(ICollection<BudgetItem> budgetItems)
        {
            List<BudgetItemView> budgetItemViews = new List<BudgetItemView>();

            foreach (BudgetItem item in budgetItems)
            {
                BudgetItemView itemView = new BudgetItemView
                {
                    CategoryName = item.Category.Name,
                    GoalAmount = item.GoalAmount
                };

                budgetItemViews.Add(itemView);
            }

            return budgetItemViews;

        }


    }
}
