
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.dgvBudgetItems = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lnkEditGroup = new System.Windows.Forms.LinkLabel();
            this.lnkDelete = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblGroupValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetItems)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.19101F));
            this.tableLayoutPanel1.Controls.Add(this.lblGroupName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvBudgetItems, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.30337F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.69663F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 404);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // lblGroupName
            // 
            this.lblGroupName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGroupName.ForeColor = System.Drawing.Color.Silver;
            this.lblGroupName.Location = new System.Drawing.Point(103, 12);
            this.lblGroupName.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(97, 35);
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
            this.dgvBudgetItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBudgetItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBudgetItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBudgetItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBudgetItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvBudgetItems.Location = new System.Drawing.Point(0, 89);
            this.dgvBudgetItems.Margin = new System.Windows.Forms.Padding(0);
            this.dgvBudgetItems.MultiSelect = false;
            this.dgvBudgetItems.Name = "dgvBudgetItems";
            this.dgvBudgetItems.ReadOnly = true;
            this.dgvBudgetItems.RowHeadersVisible = false;
            this.dgvBudgetItems.RowHeadersWidth = 62;
            this.dgvBudgetItems.RowTemplate.Height = 25;
            this.dgvBudgetItems.Size = new System.Drawing.Size(304, 230);
            this.dgvBudgetItems.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.lnkEditGroup);
            this.flowLayoutPanel3.Controls.Add(this.lnkDelete);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(79, 368);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(145, 25);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // lnkEditGroup
            // 
            this.lnkEditGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnkEditGroup.AutoSize = true;
            this.lnkEditGroup.LinkColor = System.Drawing.Color.Silver;
            this.lnkEditGroup.Location = new System.Drawing.Point(4, 0);
            this.lnkEditGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkEditGroup.Name = "lnkEditGroup";
            this.lnkEditGroup.Size = new System.Drawing.Size(42, 25);
            this.lnkEditGroup.TabIndex = 0;
            this.lnkEditGroup.TabStop = true;
            this.lnkEditGroup.Text = "Edit";
            this.lnkEditGroup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditGroup_LinkClicked);
            // 
            // lnkDelete
            // 
            this.lnkDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.LinkColor = System.Drawing.Color.Silver;
            this.lnkDelete.Location = new System.Drawing.Point(79, 0);
            this.lnkDelete.Margin = new System.Windows.Forms.Padding(29, 0, 4, 0);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(62, 25);
            this.lnkDelete.TabIndex = 1;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "Delete";
            this.lnkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDelete_LinkClicked);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblWeight, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblGroupValue, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(298, 32);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWeight.ForeColor = System.Drawing.Color.Silver;
            this.lblWeight.Location = new System.Drawing.Point(43, 5);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(5);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(62, 22);
            this.lblWeight.TabIndex = 9;
            this.lblWeight.Text = "0.0%";
            // 
            // lblGroupValue
            // 
            this.lblGroupValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGroupValue.AutoSize = true;
            this.lblGroupValue.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGroupValue.ForeColor = System.Drawing.Color.Silver;
            this.lblGroupValue.Location = new System.Drawing.Point(184, 5);
            this.lblGroupValue.Margin = new System.Windows.Forms.Padding(5);
            this.lblGroupValue.Name = "lblGroupValue";
            this.lblGroupValue.Size = new System.Drawing.Size(78, 22);
            this.lblGroupValue.TabIndex = 8;
            this.lblGroupValue.Text = "$00.00";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblBalance);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 324);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(298, 41);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBalance.ForeColor = System.Drawing.Color.Silver;
            this.lblBalance.Location = new System.Drawing.Point(200, 5);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(5);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(93, 23);
            this.lblBalance.TabIndex = 10;
            this.lblBalance.Text = "$0000.00";
            // 
            // BudgetGroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BudgetGroupControl";
            this.Size = new System.Drawing.Size(304, 407);
            this.Load += new System.EventHandler(this.BudgetGroupDisplay_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetItems)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.DataGridView dgvBudgetItems;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.LinkLabel lnkEditGroup;
        private System.Windows.Forms.LinkLabel lnkDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblGroupValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblBalance;
    }
}
