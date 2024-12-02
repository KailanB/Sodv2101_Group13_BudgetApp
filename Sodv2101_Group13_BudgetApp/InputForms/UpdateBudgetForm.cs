using Sodv2101_Group13_BudgetApp.RepositoryDBContext.BudgetServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sodv2101_Group13_BudgetApp.InputForms
{
    public partial class UpdateBudgetForm : Form
    {

        private BudgetService budgetService = new BudgetService();
        private int budgetId;

        public UpdateBudgetForm()
        {
            InitializeComponent();
        }



        public void PopulateInputs(Budget budget, int id)
        {
            txtBudgetName.Text = budget.Name;
            txtBudgetDescription.Text = budget.Description;
            numBudgetAmount.Value = (decimal)budget.Max;

            budgetId = id;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            // retrieve data from form
            string name = txtBudgetName.Text;
            double amount = Convert.ToDouble(numBudgetAmount.Value);
            string descript = txtBudgetDescription.Text;

            // create a new budget class object
            Budget budget = new Budget(name, amount, descript);

            // pass the object AND ID to the edit budget method of budget service
            // proceed to budget service class
            budgetService.EditBudget(budget, budgetId);
            this.DialogResult = DialogResult.OK;
            this.Close();



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
