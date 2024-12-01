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
    public partial class UpdateExpense : Form
    {

        private BudgetService budgetService = new BudgetService();
        private ExpenseService expenseService = new ExpenseService();

        private int budgetId;

        public UpdateExpense()
        {
            InitializeComponent();

            //Added to load the combobox
            PopulateBudgetComboBox();

            btnEditExpense.Click += btnEditExpense_Click;
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

        //Populate Budget Category - Still need to parse it to the ID NOV 30 11:11pm
        //CANT FIX THE PARSING
        private void PopulateBudgetComboBox()
        {

            var budgets = budgetService.GetBudgetList();

            if (budgets != null && budgets.Any())
            {
                cmbExpense.DataSource = budgets;
                cmbExpense.DisplayMember = "Name";
                cmbExpense.ValueMember = "BudgetId";
            }
            else
            {
                MessageBox.Show("No budgets found.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        //NOT SAVING IN THE DATABASE THORWS ERROR NOV 30 11:11pm
        private void btnEditExpense_Click(object sender, EventArgs e)
        { // Validate required fields
            if (string.IsNullOrEmpty(txtExpenseName.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Validate date
            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("Please select a valid date.");
                return;
            }

            // Retrieve the selected BudgetId from the ComboBox
            int selectedBudgetId = (int)cmbExpense.SelectedValue;

            // Retrieve other data from the form fields
            string name = txtExpenseName.Text;
            double amount = Convert.ToDouble(numExpenseAmount.Value);
            string description = txtDescription.Text;
            string dateString = dateTimePicker1.Text;

            // Create a new Expense object with the selected BudgetId
            Expense expense = new Expense(selectedBudgetId, name, amount, description, dateString);

            // Pass the Expense object and selectedBudgetId to the EditExpense method
            bool isUpdated = expenseService.UpdateExpense(expense, expense.ExpenseId); // Pass ExpenseId here if required

            if (isUpdated)
            {
                MessageBox.Show("Expense updated successfully.");
            }
            else
            {
                MessageBox.Show("Error updating expense.");
            }

            // Close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        //{   // retrieve data from form
        //    int budgetId = 1;
        //    string name = txtExpenseName.Text;
        //    double amount = Convert.ToDouble(numExpenseAmount.Value);
        //    string description = txtDescription.Text;
        //    string dateString = dateTimePicker1.Text;

        //    // create a new budget class object

        //    {
        //        Expense expense = new Expense(budgetId, name, amount, description, dateString);

        //        // pass the object AND ID to the edit budget method of budget service
        //        // proceed to budget service class
        //        expenseService.UpdateExpense(expense, budgetId);
        //        this.DialogResult = DialogResult.OK;
        //        this.Close();


        //TO POPULATE THE COMBOBOX NOV 11:11pm
        private void EditExpenseForm_Load(object sender, EventArgs e)
        {
            PopulateBudgetComboBox(); // Populate the ComboBox when the form is loaded
        }

    }

        }



    