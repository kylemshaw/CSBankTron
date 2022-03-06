
namespace BankTron_WinFormsUI
{
    partial class frmAddEditBudget
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
            this.lblBudgetAmount = new System.Windows.Forms.Label();
            this.txtBudgetValue = new System.Windows.Forms.TextBox();
            this.txtBudgetName = new System.Windows.Forms.TextBox();
            this.lblBudgetName = new System.Windows.Forms.Label();
            this.btnAddBudgetGroup = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAmountAllocated = new System.Windows.Forms.TextBox();
            this.lblAmountAllocated = new System.Windows.Forms.Label();
            this.txtPercentAllocated = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBudgetGroups = new System.Windows.Forms.Label();
            this.flpBudgetGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblBudgetAmount
            // 
            this.lblBudgetAmount.AutoSize = true;
            this.lblBudgetAmount.Location = new System.Drawing.Point(38, 97);
            this.lblBudgetAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBudgetAmount.Name = "lblBudgetAmount";
            this.lblBudgetAmount.Size = new System.Drawing.Size(143, 25);
            this.lblBudgetAmount.TabIndex = 0;
            this.lblBudgetAmount.Text = "Budget Amount:";
            // 
            // txtBudgetValue
            // 
            this.txtBudgetValue.Location = new System.Drawing.Point(182, 92);
            this.txtBudgetValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBudgetValue.Name = "txtBudgetValue";
            this.txtBudgetValue.Size = new System.Drawing.Size(243, 31);
            this.txtBudgetValue.TabIndex = 1;
            this.txtBudgetValue.TextChanged += new System.EventHandler(this.txtBudgetValue_TextChanged);
            // 
            // txtBudgetName
            // 
            this.txtBudgetName.Location = new System.Drawing.Point(182, 24);
            this.txtBudgetName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBudgetName.Name = "txtBudgetName";
            this.txtBudgetName.Size = new System.Drawing.Size(243, 31);
            this.txtBudgetName.TabIndex = 3;
            // 
            // lblBudgetName
            // 
            this.lblBudgetName.AutoSize = true;
            this.lblBudgetName.Location = new System.Drawing.Point(38, 29);
            this.lblBudgetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBudgetName.Name = "lblBudgetName";
            this.lblBudgetName.Size = new System.Drawing.Size(125, 25);
            this.lblBudgetName.TabIndex = 2;
            this.lblBudgetName.Text = "Budget Name:";
            // 
            // btnAddBudgetGroup
            // 
            this.btnAddBudgetGroup.Location = new System.Drawing.Point(89, 757);
            this.btnAddBudgetGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBudgetGroup.Name = "btnAddBudgetGroup";
            this.btnAddBudgetGroup.Size = new System.Drawing.Size(180, 38);
            this.btnAddBudgetGroup.TabIndex = 5;
            this.btnAddBudgetGroup.Text = "Add New Group";
            this.btnAddBudgetGroup.UseVisualStyleBackColor = true;
            this.btnAddBudgetGroup.Click += new System.EventHandler(this.btnAddBudgetGroup_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1221, 757);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1351, 757);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 38);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAmountAllocated
            // 
            this.txtAmountAllocated.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAmountAllocated.Enabled = false;
            this.txtAmountAllocated.Location = new System.Drawing.Point(660, 92);
            this.txtAmountAllocated.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmountAllocated.Name = "txtAmountAllocated";
            this.txtAmountAllocated.Size = new System.Drawing.Size(243, 31);
            this.txtAmountAllocated.TabIndex = 11;
            // 
            // lblAmountAllocated
            // 
            this.lblAmountAllocated.AutoSize = true;
            this.lblAmountAllocated.Location = new System.Drawing.Point(491, 97);
            this.lblAmountAllocated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountAllocated.Name = "lblAmountAllocated";
            this.lblAmountAllocated.Size = new System.Drawing.Size(160, 25);
            this.lblAmountAllocated.TabIndex = 10;
            this.lblAmountAllocated.Text = "Amount Allocated:";
            // 
            // txtPercentAllocated
            // 
            this.txtPercentAllocated.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPercentAllocated.Enabled = false;
            this.txtPercentAllocated.Location = new System.Drawing.Point(660, 24);
            this.txtPercentAllocated.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPercentAllocated.Name = "txtPercentAllocated";
            this.txtPercentAllocated.Size = new System.Drawing.Size(243, 31);
            this.txtPercentAllocated.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Percent Allocated:";
            // 
            // lblBudgetGroups
            // 
            this.lblBudgetGroups.AutoSize = true;
            this.lblBudgetGroups.Location = new System.Drawing.Point(38, 154);
            this.lblBudgetGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBudgetGroups.Name = "lblBudgetGroups";
            this.lblBudgetGroups.Size = new System.Drawing.Size(136, 25);
            this.lblBudgetGroups.TabIndex = 14;
            this.lblBudgetGroups.Text = "Budget Groups:";
            // 
            // flpBudgetGroups
            // 
            this.flpBudgetGroups.AutoScroll = true;
            this.flpBudgetGroups.Location = new System.Drawing.Point(38, 197);
            this.flpBudgetGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpBudgetGroups.Name = "flpBudgetGroups";
            this.flpBudgetGroups.Size = new System.Drawing.Size(1500, 550);
            this.flpBudgetGroups.TabIndex = 15;
            // 
            // frmAddEditBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 810);
            this.Controls.Add(this.flpBudgetGroups);
            this.Controls.Add(this.lblBudgetGroups);
            this.Controls.Add(this.txtPercentAllocated);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmountAllocated);
            this.Controls.Add(this.lblAmountAllocated);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddBudgetGroup);
            this.Controls.Add(this.txtBudgetName);
            this.Controls.Add(this.lblBudgetName);
            this.Controls.Add(this.txtBudgetValue);
            this.Controls.Add(this.lblBudgetAmount);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddEditBudget";
            this.Load += new System.EventHandler(this.frmAddEditBudget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBudgetAmount;
        private System.Windows.Forms.TextBox txtBudgetValue;
        private System.Windows.Forms.TextBox txtBudgetName;
        private System.Windows.Forms.Label lblBudgetName;
        private System.Windows.Forms.Button btnAddBudgetGroup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAmountAllocated;
        private System.Windows.Forms.Label lblAmountAllocated;
        private System.Windows.Forms.TextBox txtPercentAllocated;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBudgetGroups;
        private System.Windows.Forms.FlowLayoutPanel flpBudgetGroups;
    }
}