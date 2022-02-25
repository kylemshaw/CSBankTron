using BankTronBusinessLogic;
using BankTronSQLiteData;
using Microsoft.Data.Sqlite;
using System;
using System.Drawing;
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
            cboBank.Items.Add("RBC");
            cboBank.SelectedItem = "RBC";

            btnAddNewCategory.Enabled = false;
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

                try
                {
                    switch (cboBank.SelectedItem)
                    {
                        case "RBC":
                        default:
                            dgvImportData.DataSource = ImportCSV.GetRBCTransactions(openFileDialog.FileName);
                            break;
                    }        
                
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
                catch (SqliteException ex)
                {
                    string message = "The following database error occured while trying to import: " +
                        Environment.NewLine + Environment.NewLine + ex.Message;
                    dgvImportData.DataSource = null;
                    dgvImportData.Columns.Clear();
                    MessageBox.Show(message);
                }
                catch (Exception ex)
                {
                    string message = "The following problem occured while loading the data file: " +
                        Environment.NewLine + Environment.NewLine + ex.Message +
                        Environment.NewLine + Environment.NewLine + "Please review data file and try again.";
                    dgvImportData.DataSource = null;
                    dgvImportData.Columns.Clear();
                    MessageBox.Show(message);
                }

                if(dgvImportData.Rows.Count > 0)
                {
                    btnAddNewCategory.Enabled = true;
                }
                else 
                {
                    btnAddNewCategory.Enabled = false;
                }

            }
        }        

        private void btnImport_Click(object sender, EventArgs e)
        {            
            if(dgvImportData.Rows.Count == 0)
            {
                MessageBox.Show("You must open a data file before importing to the database.");
            }
            else if (IsDataValid())
            {
                try
                {
                    foreach (DataGridViewRow row in dgvImportData.Rows)
                    {
                        Transaction transaction = new Transaction
                        {
                            Bank = cboBank.SelectedItem.ToString(),
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
                catch(SqliteException ex)
                {
                    string message = "The following database error occured while trying to import: " +
                        Environment.NewLine + Environment.NewLine + ex.Message;                       

                    MessageBox.Show(message);
                }
                catch (Exception ex)
                {
                    string message = "The following error occured while trying to import to the database: " +
                        Environment.NewLine + Environment.NewLine + ex.Message +
                        Environment.NewLine + Environment.NewLine + "Please review data file and try again.";

                    MessageBox.Show(message);                    
                }
                
            }               
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            var addCategoryForm = new frmAddEditCategory()
            {
                NewCategory = true,
                Category = null
            };

            DialogResult result = addCategoryForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    CategoryManager.Add(addCategoryForm.Category);
                    DataGridViewComboBoxColumn categoryColumn = (DataGridViewComboBoxColumn)dgvImportData.Columns["Category"];
                    categoryColumn.DataSource = CategoryManager.GetAll();
                }
                catch (Exception)
                {
                    //TODO: General Error Message Class
                    //HandleGeneralError(ex, "Adding Package");
                }
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
