using Sodv2101_Group13_BudgetApp.RepositoryDBContext.BudgetServices;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.ExpenseServices;
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

    public partial class NewExpense : Form
    {
        private ExpenseService expenseService = new ExpenseService();

        private BudgetService budgetService = new BudgetService();

        public NewExpense()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtExpenseName.Text != " ")
            {
                int BudgetID = 1; //figure this out
                string Name = txtExpenseName.Text;
                double Amount = (double)numExpenseAmount.Value;
                string Description = txtDescription.Text;
                string DateString = dateTimePicker1.Text;


                Expense expense = new Expense(BudgetID, Name, Amount, Description, DateString);

                expenseService.NewExpense(expense);

            }
        }

        private void LoadBudgetList()
        {
            List<Budget> budgets = new List<Budget>();

            budgets = budgetService.GetBudgetList();
            var budgetBindingList = new BindingList<Budget>(budgets);

            cmbBudgetList.DataSource = budgetBindingList;
            cmbBudgetList.DisplayMember = "Name";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
