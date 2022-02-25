
namespace BankTron_WinFormsUI
{
    partial class frmAddEditBudgetGroup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnAddBudgetItem = new System.Windows.Forms.Button();
            this.txtGoalAmount = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblGoalAmount = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.txtWeightInBudget = new System.Windows.Forms.TextBox();
            this.lblWeightInBudget = new System.Windows.Forms.Label();
            this.dgvBudgetItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetItems)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(23, 86);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(155, 23);
            this.cboCategory.TabIndex = 0;
            // 
            // btnAddBudgetItem
            // 
            this.btnAddBudgetItem.Location = new System.Drawing.Point(340, 85);
            this.btnAddBudgetItem.Name = "btnAddBudgetItem";
            this.btnAddBudgetItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddBudgetItem.TabIndex = 1;
            this.btnAddBudgetItem.Text = "&Add";
            this.btnAddBudgetItem.UseVisualStyleBackColor = true;
            this.btnAddBudgetItem.Click += new System.EventHandler(this.btnAddBudgetItem_Click);
            // 
            // txtGoalAmount
            // 
            this.txtGoalAmount.Location = new System.Drawing.Point(196, 86);
            this.txtGoalAmount.Name = "txtGoalAmount";
            this.txtGoalAmount.Size = new System.Drawing.Size(122, 23);
            this.txtGoalAmount.TabIndex = 2;
            this.txtGoalAmount.Tag = "Goal Amount";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(23, 66);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";
            // 
            // lblGoalAmount
            // 
            this.lblGoalAmount.AutoSize = true;
            this.lblGoalAmount.Location = new System.Drawing.Point(196, 66);
            this.lblGoalAmount.Name = "lblGoalAmount";
            this.lblGoalAmount.Size = new System.Drawing.Size(81, 15);
            this.lblGoalAmount.TabIndex = 4;
            this.lblGoalAmount.Text = "Goal Amount:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(23, 446);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(259, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(340, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(20, 9);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(78, 15);
            this.lblGroupName.TabIndex = 10;
            this.lblGroupName.Text = "Group Name:";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(20, 27);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(158, 23);
            this.txtGroupName.TabIndex = 9;
            this.txtGroupName.Tag = "Group Name";
            // 
            // txtWeightInBudget
            // 
            this.txtWeightInBudget.Location = new System.Drawing.Point(312, 27);
            this.txtWeightInBudget.Name = "txtWeightInBudget";
            this.txtWeightInBudget.Size = new System.Drawing.Size(61, 23);
            this.txtWeightInBudget.TabIndex = 11;
            this.txtWeightInBudget.Tag = "Weight";
            // 
            // lblWeightInBudget
            // 
            this.lblWeightInBudget.AutoSize = true;
            this.lblWeightInBudget.Location = new System.Drawing.Point(204, 30);
            this.lblWeightInBudget.Name = "lblWeightInBudget";
            this.lblWeightInBudget.Size = new System.Drawing.Size(102, 15);
            this.lblWeightInBudget.TabIndex = 12;
            this.lblWeightInBudget.Text = "Weight in Budget:";
            // 
            // dgvBudgetItems
            // 
            this.dgvBudgetItems.AllowUserToResizeColumns = false;
            this.dgvBudgetItems.AllowUserToResizeRows = false;
            this.dgvBudgetItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBudgetItems.Location = new System.Drawing.Point(48, 126);
            this.dgvBudgetItems.Margin = new System.Windows.Forms.Padding(0);
            this.dgvBudgetItems.Name = "dgvBudgetItems";
            this.dgvBudgetItems.RowHeadersWidth = 40;
            this.dgvBudgetItems.RowTemplate.Height = 25;
            this.dgvBudgetItems.Size = new System.Drawing.Size(343, 292);
            this.dgvBudgetItems.TabIndex = 13;
            // 
            // frmAddEditBudgetGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 494);
            this.Controls.Add(this.dgvBudgetItems);
            this.Controls.Add(this.lblWeightInBudget);
            this.Controls.Add(this.txtWeightInBudget);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblGoalAmount);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtGoalAmount);
            this.Controls.Add(this.btnAddBudgetItem);
            this.Controls.Add(this.cboCategory);
            this.Name = "frmAddEditBudgetGroup";
            this.Load += new System.EventHandler(this.frmAddEditBudgetGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnAddBudgetItem;
        private System.Windows.Forms.TextBox txtGoalAmount;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblGoalAmount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.TextBox txtWeightInBudget;
        private System.Windows.Forms.Label lblWeightInBudget;
        private System.Windows.Forms.DataGridView dgvBudgetItems;
    }
}