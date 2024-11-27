using Microsoft.Data.SqlClient;
using Sodv2101_Group13_BudgetApp.InputForms;
using Sodv2101_Group13_BudgetApp.SubPageForms;

namespace Sodv2101_Group13_BudgetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void btnCreateBudget_Click(object sender, EventArgs e)
        {

            // create a new budget form on button click and show it 
            // proceed to the budget form
            CreateBudget budgetForm = new CreateBudget();
            budgetForm.ShowDialog();

        }

        private void toolBtnAddExpense_Click(object sender, EventArgs e)
        {

        }

        private void btnToolStripBudget_Click(object sender, EventArgs e)
        {
            BudgetPageForm budgetForm = new BudgetPageForm();
            budgetForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
