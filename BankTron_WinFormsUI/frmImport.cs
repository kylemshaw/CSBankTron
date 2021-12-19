using BankTronBusinessLogic;
using BankTronData.Models;
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
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Import CSV Transactions",
                CheckFileExists = true,
                CheckPathExists = true,
                //DefaultExt = "csv",
                //Filter = "txt files (*.txt)|*.txt",
                //FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
                dgvImportData.DataSource = ImportCSV.GetRBCTransactions(openFileDialog1.FileName);
                //Add controls for category selection
                
            }
        }
       
        private void btnImport_Click(object sender, EventArgs e)
        {
            //add check to make sure all categories have been selected
            
            //get datasource and pass to BLL as dt to keep code out of Gui
            //dgvImportData.DataSource;

            //convert to DataRow in DataTable when move to BLL
            foreach(DataGridViewRow row in dgvImportData.Rows)
            {
                Transactions tran = new Transactions
                {
                    AccountType = row.Cells["Account Type"].Value.ToString(),
                    AccountNumber = row.Cells["Account Number"].Value.ToString(),
                    TransactionDate = DateTime.Parse(row.Cells["Transaction Date"].Value.ToString()),
                    Description = row.Cells["Description"].Value.ToString(),
                    Amount = Decimal.Parse(row.Cells["Amount (CAD$)"].Value.ToString())
                };
                //insert into database function

            }
        }  
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        
    }
}
