
namespace BankTron_WinFormsUI.CustomControls
{
    partial class BudgetItemControl
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
            this.dgvBudgetItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBudgetItems
            // 
            this.dgvBudgetItems.AllowUserToResizeColumns = false;
            this.dgvBudgetItems.AllowUserToResizeRows = false;
            this.dgvBudgetItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBudgetItems.Location = new System.Drawing.Point(0, 0);
            this.dgvBudgetItems.Margin = new System.Windows.Forms.Padding(0);
            this.dgvBudgetItems.Name = "dgvBudgetItems";
            this.dgvBudgetItems.RowHeadersVisible = false;
            this.dgvBudgetItems.RowTemplate.Height = 25;
            this.dgvBudgetItems.Size = new System.Drawing.Size(343, 292);
            this.dgvBudgetItems.TabIndex = 6;
            this.dgvBudgetItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBudgetItems_CellContentClick);
            // 
            // BudgetItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.dgvBudgetItems);
            this.Name = "BudgetItemControl";
            this.Size = new System.Drawing.Size(343, 292);
            this.Load += new System.EventHandler(this.BudgetItemControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBudgetItems;
    }
}
