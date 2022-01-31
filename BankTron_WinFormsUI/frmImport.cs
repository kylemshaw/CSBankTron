using BankTronBusinessLogic;
using BankTronSQLiteData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankTron_WinFormsUI
{
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
            
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Import CSV Transactions",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "csv",
                Filter = "CSV files (*.csv)|*.csv",          
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
                dgvImportData.DataSource = ImportCSV.GetRBCTransactions(openFileDialog.FileName);
                
                DataGridViewComboBoxColumn categoryColumn = new DataGridViewComboBoxColumn();
                categoryColumn.DataSource = CategoryManager.GetAll();
                categoryColumn.DisplayMember = "Name";
                categoryColumn.ValueMember = "ID";
                categoryColumn.Name = "Category";
                dgvImportData.Columns.Add(categoryColumn);

                DataGridViewTextBoxColumn tagsColumn = new DataGridViewTextBoxColumn();
                tagsColumn.Name = "Tags";
                tagsColumn.Width = 150;
                dgvImportData.Columns.Add(tagsColumn);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {            
            if (IsDataValid())
            {
                foreach (DataGridViewRow row in dgvImportData.Rows)
                {
                    Transaction transaction = new Transaction
                    {
                        Bank = "RBC",
                        AccountType = row.Cells["Account Type"].Value.ToString(),
                        AccountNumber = row.Cells["Account Number"].Value.ToString(),
                        TransactionDate = DateTime.Parse(row.Cells["Transaction Date"].Value.ToString()),
                        Description = row.Cells["Description"].Value.ToString(),
                        Amount = Decimal.Parse(row.Cells["Amount (CAD$)"].Value.ToString()),
                        CategoryID = int.Parse(row.Cells["Category"].Value.ToString()),
                        Tags = row.Cells["Tags"].Value.ToString() ?? string.Empty
                    };

                    TransactionManager.Add(transaction);
                }

                this.DialogResult = DialogResult.OK;
            }               
            
        }

        private bool IsDataValid()
        {
            bool isDataValid = true;
            
            foreach (DataGridViewRow row in dgvImportData.Rows)
            {
                // Category must be selected
                if (Convert.ToInt32(row.Cells["Category"].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                    isDataValid = false;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Empty;
                }

                // Value.ToString() does not handle nulls, so set to empty string
                if (row.Cells["Tags"].Value == null)
                {
                    row.Cells["Tags"].Value = String.Empty;
                }
            }

            return isDataValid;
        }        
                
    }
}
