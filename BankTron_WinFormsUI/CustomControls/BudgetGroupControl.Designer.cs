
namespace BankTron_WinFormsUI.CustomControls
{
    partial class BudgetGroupControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.dgvBudgetItems = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblGroupValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lnkEditGroup = new System.Windows.Forms.LinkLabel();
            this.lnkDelete = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetItems)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.19101F));
            this.tableLayoutPanel1.Controls.Add(this.lblBalance, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGroupName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvBudgetItems, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 351);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(213, 314);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(200, 0, 3, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(34, 15);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "$0.00";
            // 
            // lblGroupName
            // 
            this.lblGroupName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGroupName.Location = new System.Drawing.Point(93, 10);
            this.lblGroupName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(63, 24);
            this.lblGroupName.TabIndex = 0;
            this.lblGroupName.Text = "Name";
            // 
            // dgvBudgetItems
            // 
            this.dgvBudgetItems.AllowUserToAddRows = false;
            this.dgvBudgetItems.AllowUserToDeleteRows = false;
            this.dgvBudgetItems.AllowUserToOrderColumns = true;
            this.dgvBudgetItems.AllowUserToResizeRows = false;
            this.dgvBudgetItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvBudgetItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBudgetItems.Location = new System.Drawing.Point(0, 90);
            this.dgvBudgetItems.Margin = new System.Windows.Forms.Padding(0);
            this.dgvBudgetItems.MultiSelect = false;
            this.dgvBudgetItems.Name = "dgvBudgetItems";
            this.dgvBudgetItems.ReadOnly = true;
            this.dgvBudgetItems.RowHeadersVisible = false;
            this.dgvBudgetItems.RowTemplate.Height = 25;
            this.dgvBudgetItems.Size = new System.Drawing.Size(250, 220);
            this.dgvBudgetItems.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.Controls.Add(this.lblWeight);
            this.flowLayoutPanel1.Controls.Add(this.txtWeight);
            this.flowLayoutPanel1.Controls.Add(this.lblGroupValue);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 50);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 34);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(3, 6);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(48, 15);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWeight.BackColor = System.Drawing.Color.LightBlue;
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeight.Location = new System.Drawing.Point(57, 6);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(61, 16);
            this.txtWeight.TabIndex = 2;
            // 
            // lblGroupValue
            // 
            this.lblGroupValue.AutoSize = true;
            this.lblGroupValue.Location = new System.Drawing.Point(171, 8);
            this.lblGroupValue.Margin = new System.Windows.Forms.Padding(50, 8, 3, 0);
            this.lblGroupValue.Name = "lblGroupValue";
            this.lblGroupValue.Size = new System.Drawing.Size(40, 15);
            this.lblGroupValue.TabIndex = 6;
            this.lblGroupValue.Text = "$00.00";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.lnkEditGroup);
            this.flowLayoutPanel3.Controls.Add(this.lnkDelete);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(77, 331);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(96, 15);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // lnkEditGroup
            // 
            this.lnkEditGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnkEditGroup.AutoSize = true;
            this.lnkEditGroup.Location = new System.Drawing.Point(3, 0);
            this.lnkEditGroup.Name = "lnkEditGroup";
            this.lnkEditGroup.Size = new System.Drawing.Size(27, 15);
            this.lnkEditGroup.TabIndex = 0;
            this.lnkEditGroup.TabStop = true;
            this.lnkEditGroup.Text = "Edit";
            this.lnkEditGroup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditGroup_LinkClicked);
            // 
            // lnkDelete
            // 
            this.lnkDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.Location = new System.Drawing.Point(53, 0);
            this.lnkDelete.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(40, 15);
            this.lnkDelete.TabIndex = 1;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "Delete";
            this.lnkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDelete_LinkClicked);
            // 
            // BudgetGroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BudgetGroupControl";
            this.Size = new System.Drawing.Size(250, 351);
            this.Load += new System.EventHandler(this.BudgetGroupDisplay_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetItems)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.DataGridView dgvBudgetItems;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.LinkLabel lnkEditGroup;
        private System.Windows.Forms.LinkLabel lnkDelete;
        private System.Windows.Forms.Label lblGroupValue;
    }
}
