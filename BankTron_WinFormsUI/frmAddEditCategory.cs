using BankTronBusinessLogic;
using BankTronSQLiteData;
using System;
using System.Windows.Forms;

namespace BankTron_WinFormsUI
{
    public partial class frmAddEditCategory : Form
    {
        public bool NewCategory { get; set; }
        public Category Category { get; set; }

        public frmAddEditCategory()
        {
            InitializeComponent();            
        }

        private void frmAddEditCategory_Load(object sender, EventArgs e)
        {
            if(NewCategory)
            {
                this.Text = "Add New Category";
            }
            else
            {
                this.Text = "Edit Category";
                txtName.Text = Category.Name;
            }
            
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(isValidData())
           {
                if (NewCategory)
                {
                    Category = new Category();
                }                                   

                Category.Name = txtName.Text;

                this.DialogResult = DialogResult.OK;
            }                        
        }        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isValidData()
        {
            bool isValid = false;

            if ( Validator.IsPresent(txtName))
            {
                if (CategoryManager.FindByName(txtName.Text.Trim()) == null)
                {
                    isValid = true;
                }
                else
                {
                    MessageBox.Show(txtName.Text + " already exists!");
                }
            }                 
               
            return isValid;
        }

    }
}
