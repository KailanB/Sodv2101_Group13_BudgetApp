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
        private ExpenseService expenseService = new ExpenseService();

        private int budgetId;

        public UpdateExpense()
        {
            InitializeComponent();
        }

 


        //REdone the Populated Inputs because of the date parsing
        public void PopulateInputs(Expense expense, int id)
        {
            if (expense == null)
            {
                MessageBox.Show("Expense data is null.");
                return;
            }

            string dateString = expense.TimePeriod.ToString(); // Ensure it's not null

            if (string.IsNullOrEmpty(dateString))
            {
                MessageBox.Show("Expense date is invalid or missing.");
                return;
            }

            // Check if the date string is valid before parsing
            DateTime timePeriod;
            if (DateTime.TryParse(dateString, out timePeriod))
            {
                // Proceed with setting the inputs (form fields)
                dateTimePicker1.Text = timePeriod.ToString("yyyy-MM-dd"); // example date format
            }
            else
            {
                MessageBox.Show("The date format is incorrect or cannot be parsed.");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        //EDIT EXPENSE 

        //   Commented also the designer.resx ------> 117 //btnEditExpense.Click += btnEditExpense_Click;

        private void btnEditExpense_Click(object sender, EventArgs e)
        {   // retrieve data from form
            int budgetId = 1;
            string name = txtExpenseName.Text;
            double amount = Convert.ToDouble(numExpenseAmount.Value);
            string description = txtDescription.Text;
            string dateString = dateTimePicker1.Text;

            // create a new budget class object

            {
                Expense expense = new Expense(budgetId, name, amount, description, dateString);

                // pass the object AND ID to the edit budget method of budget service
                // proceed to budget service class
                expenseService.UpdateExpense(expense, budgetId);
                this.DialogResult = DialogResult.OK;
                this.Close();



            }

        }



    }
}
