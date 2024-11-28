using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.BudgetServices;

namespace Sodv2101_Group13_BudgetApp.InputForms
{
    public partial class CreateBudget : Form
    {

        // create budget form has a class with methods that run CRUD
        private BudgetService budgetService = new BudgetService();
        public CreateBudget()
        {
            InitializeComponent();
        }

        // on create button click
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtBudgetName.Text != "" && txtBudgetDescription.Text != "" && numBudgetAmount.Value != 0)
            {
                // retrieve data from form
                string name = txtBudgetName.Text;
                double amount = Convert.ToDouble(numBudgetAmount.Value);
                string descript = txtBudgetDescription.Text;

                // create a new budget class object
                Budget budget = new Budget(name, amount, descript);

                // pass the object to the create budget method of budget service
                // proceed to budget service class
                budgetService.CreateBudget(budget);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                lblBudgetError.Text = "Please Fill in all Fields";
            }



        }

        //public void ChangeBtnNameEdit()
        //{
        //    btnCreate.Text = "Edit";
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
