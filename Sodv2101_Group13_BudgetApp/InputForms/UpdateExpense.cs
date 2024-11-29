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
    public partial class UpdateExpense : Form
    {
        public UpdateExpense()
        {
            InitializeComponent();
        }

        private ExpenseService expenseService = new ExpenseService();


        private int budgetId;



        public void PopulateInputs(Expense expense, int id)
        {
            txtExpenseName.Text = expense.Name;
            numExpenseAmount.Value = (decimal)expense.Amount;
            txtDescription.Text = expense.Description;
            dateTimePicker1.Value = DateTime.Parse(expense.DateString);

            // Store the budgetId for later use
            budgetId = id;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        //EDIT EXPENSE 

        //   Commented also the designer.resx ------> 117 //btnEditExpense.Click += btnEditExpense_Click;

        //        private void btnEditExpense_Click(object sender, EventArgs e)
        //        /*{   *///    // retrieve data from form
        //                int budgetId = 1;
        //        string name = txtExpenseName.Text;
        //        double amount = Convert.ToDouble(numExpenseAmount.Value);
        //        string description = txtDescription.Text;
        //        string dateString = dateTimePicker1.Text;

        //                // create a new budget class object

        //                {
        //                    Expense expense = new Expense(budgetId, name, amount, description, dateString);

        //        // pass the object AND ID to the edit budget method of budget service
        //        // proceed to budget service class
        //        expenseService.UpdateExpense(expense, budgetId);
        //                    this.DialogResult = DialogResult.OK;
        //                    this.Close();



        //    }

        //}


        
    }
}
