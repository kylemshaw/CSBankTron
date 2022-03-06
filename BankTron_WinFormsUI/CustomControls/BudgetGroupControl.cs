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
    public partial class BudgetGroupControl : UserControl
    {
        private BudgetGroup group;
        private decimal budgetValue;
        private bool isValid;

        public bool IsValid { get => isValid; }
        public BudgetGroup Group { get => group; }
        
        public event EventHandler BudgetGroupEdit;
        public event EventHandler BudgetGroupDelete;

        public BudgetGroupControl(BudgetGroup group, decimal budgetValue)
        {
            InitializeComponent();
            this.group = group;            
            this.budgetValue = budgetValue; 
        }        

        private void BudgetGroupDisplay_Load(object sender, EventArgs e) 
        {
            lblGroupName.Text = group.Name;                        
            lblWeight.Text = (group.WeightInBudget).ToString("P1");
            lblGroupValue.Text = (group.WeightInBudget * budgetValue).ToString("C");
            ValidateGroupWeight();
            UpdateDataGrid();
        }

        private void lblWeight_TextChanged(object sender, EventArgs e)
        {
            decimal weight;
            if (Decimal.TryParse(lblWeight.Text, out weight))
            {                
                group.WeightInBudget = weight / 100.0m;
                lblGroupValue.Text = (group.WeightInBudget * budgetValue).ToString("C");
                ValidateGroupWeight();                
            }
        }

        private void lnkEditGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditBudgetGroup groupForm = new frmAddEditBudgetGroup(false);
            groupForm.Group = group;

            DialogResult result = groupForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Invoke event to notify parent form of update          
                BudgetGroupEdit?.Invoke(sender, e); 
            }
        }

        private void lnkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            DialogResult result = MessageBox.Show("Are you sure you want to delete this group?", "Delete Group", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {                
                //Invoke event to notify parent form of update          
                BudgetGroupDelete?.Invoke(sender, e);
            }
        }

        private void ValidateGroupWeight()
        {                        
            //Calculate sum of all budget item goal amounts
            decimal groupGoalSum = 0.0m;
            foreach(BudgetItem item in group.BudgetItems)
            {
                groupGoalSum += item.GoalAmount;
            }

            // Proivde user difference between group goal and actual amount allocated
            lblBalance.Text = ((budgetValue * group.WeightInBudget) - groupGoalSum).ToString("C");

            // Apply validation rules
            if (groupGoalSum > Decimal.Parse(lblGroupValue.Text.Substring(1)))
            {
                lblWeight.ForeColor = Color.Red;
                lblGroupValue.ForeColor = Color.Red;
                lblBalance.ForeColor = Color.Red;
                this.isValid = false;
            }
            else if (groupGoalSum < Decimal.Parse(lblGroupValue.Text.Substring(1)))
            {                
                lblWeight.ForeColor = Color.YellowGreen;
                lblGroupValue.ForeColor = Color.YellowGreen;
                lblBalance.ForeColor = Color.Silver;
                this.isValid = true;
            }
            else
            {
                lblWeight.ForeColor = Color.Silver;
                lblGroupValue.ForeColor = Color.Silver;
                lblBalance.ForeColor = Color.Silver;
                this.isValid = true;
            }
        }

        public void UpdateDataGrid()
        {
            dgvBudgetItems.DataSource = null;
            dgvBudgetItems.DataSource = CreateViews(group.BudgetItems);                      

            // Category Name
            dgvBudgetItems.Columns[0].HeaderText = "Category";
            //dgvBudgetItems.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvBudgetItems.Columns[0].HeaderCell.Style.BackColor = Color.Red;
            //dgvBudgetItems.Columns[0].HeaderCell.Style.ForeColor = Color.Black;
            dgvBudgetItems.Columns[0].Width = 175;
            dgvBudgetItems.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Category Goal Amount
            dgvBudgetItems.Columns[1].HeaderText = "Value";
            //dgvBudgetItems.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBudgetItems.Columns[1].Width = 125;
            dgvBudgetItems.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBudgetItems.Columns[1].DefaultCellStyle.Format = "c";                       
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
