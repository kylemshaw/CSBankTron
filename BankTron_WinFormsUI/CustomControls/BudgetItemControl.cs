using BankTronBusinessLogic;
using BankTronSQLiteData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankTron_WinFormsUI.CustomControls
{
    // Unresolved Bug:
    // Throws an Index out of bounds exception when you click on dgv after adding an item
    // Something to do with data binding and CurrencyManager getting set to -1
    // Leave for now but would be nice to have this inside the BudgetGroupControl and frmAddEditBudgetGroup

    public partial class BudgetItemControl : UserControl
    {
        private List<BudgetItemView> budgetItemViews;
        public BudgetItemView selectedBudgetItem;
        public List<BudgetItem> budgetItems;

        public BudgetItemControl()
        {
            InitializeComponent();
            budgetItemViews = new List<BudgetItemView>();
            budgetItems = new List<BudgetItem>();
        }        

        private void BudgetItemControl_Load(object sender, EventArgs e)
        {
            CreateViews();
            BindViewsToDataGrid();            
        }

        public void UpdateDisplay()
        {
            CreateViews();
            BindViewsToDataGrid();
        }

        public void CreateViews()
        {            
            budgetItemViews.Clear();

            foreach (BudgetItem item in budgetItems)
            {
                BudgetItemView itemView = new BudgetItemView
                {
                    CategoryName = item.Category.Name,
                    GoalAmount = item.GoalAmount
                };
                
                budgetItemViews.Add(itemView);
            }
            
        }

        public void BindViewsToDataGrid()
        {
               
            dgvBudgetItems.DataSource = null;
            dgvBudgetItems.DataSource = budgetItemViews;
            
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

        public DataGridViewSelectedRowCollection GetSelectedRows()
        {
            return dgvBudgetItems.SelectedRows;
        }

        private void dgvBudgetItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedBudgetItem = budgetItemViews[e.RowIndex];
            }
            
        }

       
    }
}
