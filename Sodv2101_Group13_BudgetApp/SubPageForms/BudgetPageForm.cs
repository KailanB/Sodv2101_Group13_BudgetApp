using Microsoft.Data.SqlClient;
using Sodv2101_Group13_BudgetApp.InputForms;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.BudgetServices;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.ExpenseServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Sodv2101_Group13_BudgetApp.SubPageForms
{
    public partial class BudgetPageForm : Form
    {

        // private DBConnection dbConnection = new DBConnection();

        private List<Budget> budgetList = new List<Budget>();

        private BudgetService budgetService = new BudgetService();

        private ExpenseService expenseService = new ExpenseService();
        public BudgetPageForm()
        {
            InitializeComponent();

            LoadBudgets();
        }

        private void LoadBudgets()
        {

            budgetList = budgetService.GetBudgetList();
            DataTable budgetTable = new DataTable();
            budgetTable.Columns.Add("Budget", typeof(string));
            budgetTable.Columns.Add("Max Amount", typeof(double));
            budgetTable.Columns.Add("Description", typeof(string));
            budgetTable.Columns.Add("Budget ID", typeof(int));
            foreach (var budg in budgetList)
            {
                budgetTable.Rows.Add(budg.Name, budg.Max, budg.Description, budg.BudgetID);
            }
            dataGridViewBudgets.DataSource = budgetTable;

        }


        //ADDED to work with expenses loading into the database
        private void LoadExpenses(int budgetId)
        {
            List<Expense> expenses = expenseService.GetExpenseByBudgetId(budgetId);

            DataTable expenseTable = new DataTable();
            expenseTable.Columns.Add("Name", typeof(string));
            expenseTable.Columns.Add("Amount", typeof(double));
            expenseTable.Columns.Add("Description", typeof(string));
            expenseTable.Columns.Add("Time Period", typeof(string));
            expenseTable.Columns.Add("Expense ID", typeof(int));

            foreach (var exp in expenses)
            {
                expenseTable.Rows.Add(exp.Name, exp.Amount, exp.Description, exp.TimePeriod.ToString("yyyy/MM/dd"), exp.ExpenseId);
            }

            dataGridViewExpenses.DataSource = expenseTable;
        }


        private void btnNewBudget_Click(object sender, EventArgs e)
        {
            CreateBudget budgetForm = new CreateBudget();
            DialogResult result = budgetForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadBudgets();
            }
        }

        private void btnDeleteBudget_Click(object sender, EventArgs e)
        {
            if (dataGridViewBudgets.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewBudgets.SelectedRows[0];
                int budgetListIndex = dataGridViewBudgets.CurrentCell.RowIndex;
                int budgetId = budgetList[budgetListIndex].BudgetID;

                // int budgetId = Convert.ToInt32(selectedRow.Cells["Budget ID"].Value);

                bool budgetDeleted = budgetService.DeleteBudget(budgetId);
                if (budgetDeleted)
                {
                    LoadBudgets();
                }
            }
        }
        //to VIEW ALL EXPENSES IN THE BUDGET PAGE FORM
        private void btnViewExpenses_Click(object sender, EventArgs e)
        {
            List<Expense> expenses = new List<Expense>();
            if (dataGridViewBudgets.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewBudgets.SelectedRows[0];

                // get id via using list index to find ID of budget at index.
                int budgetListIndex = dataGridViewBudgets.CurrentCell.RowIndex;
                int budgetId = budgetList[budgetListIndex].BudgetID;
                // int budgetId = Convert.ToInt32(selectedRow.Cells["Budget ID"].Value);

                expenses = expenseService.GetExpenseByBudgetId(budgetId);

                DataTable expenseTable = new DataTable();

                expenseTable.Columns.Add("Name", typeof(string));
                expenseTable.Columns.Add("Amount", typeof(double));
                expenseTable.Columns.Add("Description", typeof(string));
                expenseTable.Columns.Add("Time Period", typeof(string));
                expenseTable.Columns.Add("Expense ID", typeof(int));
                foreach (var exp in expenses)
                {
                    expenseTable.Rows.Add(exp.Name, exp.Amount, exp.Description, exp.TimePeriod, exp.ExpenseId);
                }


                dataGridViewExpenses.DataSource = expenseTable;

            }

        }

        private void btnEditBudget_Click(object sender, EventArgs e)
        {
            if (dataGridViewBudgets.SelectedRows.Count > 0 && dataGridViewBudgets.SelectedRows.Count < 2)
            {
                DataGridViewRow selectedRow = dataGridViewBudgets.SelectedRows[0];
                int budgetListIndex = dataGridViewBudgets.CurrentCell.RowIndex;
                int budgetId = budgetList[budgetListIndex].BudgetID;

                string name = selectedRow.Cells["Budget"].Value.ToString();
                double amount = Convert.ToDouble(selectedRow.Cells["Max Amount"].Value);
                string description = selectedRow.Cells["Description"].Value.ToString();

                Budget budget = new Budget(name, amount, description);

                EditBudgetForm editBudgetForm = new EditBudgetForm();
                editBudgetForm.PopulateInputs(budget, budgetId);
                DialogResult result = editBudgetForm.ShowDialog();
                // if new budget is added then reload budget info
                if (result == DialogResult.OK)
                {
                    {
                        LoadBudgets();
                    }


                }
            }



        }

        private void btnNewExpense_Click(object sender, EventArgs e)
        {
            NewExpense expenseForm = new NewExpense();
            DialogResult result = expenseForm.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }

        //still not showing in the dataviewGrid for Expenses in Budget Goal Formit NOV 11:13pm 

        private void btnEditExpense_Click(object sender, EventArgs e)
        {
            if (dataGridViewExpenses.SelectedRows.Count > 0)
            {
                // Get selected expense row from dataGridViewExpenses
                DataGridViewRow selectedRow = dataGridViewExpenses.SelectedRows[0];

                // Get the budgetId from the corresponding selected budget in the dataGridViewBudgets
                int budgetListIndex = dataGridViewBudgets.CurrentCell.RowIndex;
                int budgetId = budgetList[budgetListIndex].BudgetID;

                // Retrieve the selected expense's data
                int expenseId = Convert.ToInt32(selectedRow.Cells["Expense ID"].Value);
                string name = selectedRow.Cells["Name"].Value.ToString();
                double amount = Convert.ToDouble(selectedRow.Cells["Amount"].Value);
                string description = selectedRow.Cells["Description"].Value.ToString();
                string dateString = selectedRow.Cells["Time Period"].Value?.ToString(); // Handle possible null

                DateTime timePeriod = DateTime.MinValue; // Default value if parsing fails

                // Check if the dateString is not null or empty before parsing
                if (!string.IsNullOrEmpty(dateString))
                {
                    if (DateTime.TryParse(dateString, out timePeriod))
                    {
                        // Create Expense object
                        Expense expense = new Expense(expenseId, budgetId, name, amount, description, timePeriod);

                        // Open the EditExpenseForm with populated data
                        UpdateExpense editExpenseForm = new UpdateExpense();
                        editExpenseForm.PopulateInputs(expense, budgetId);

                        if (editExpenseForm.ShowDialog() == DialogResult.OK)
                        {
                            // Reload the expenses after editing
                            LoadExpenses(budgetId);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The date format is incorrect or cannot be parsed. Please check the date format.");
                    }
                }
                else
                {
                    MessageBox.Show("The selected expense does not have a valid date.");
                }
            }
            else
            {
                // No expense selected
                MessageBox.Show("Please select a single expense to edit.");
            }
        }


        //added nov31
        private void btnDeleteExpense_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewExpenses.SelectedRows.Count > 0)
            {
                // Get the selected row from the DataGridView
                DataGridViewRow selectedRow = dataGridViewExpenses.SelectedRows[0];

                // Get the ExpenseId from the selected row
                int expenseId = Convert.ToInt32(selectedRow.Cells["Expense ID"].Value);

                // Confirm the deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this expense?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Call the delete method from the ExpenseService to delete the expense from the database
                    bool expenseDeleted = expenseService.DeleteExpense(expenseId);

                    if (expenseDeleted)
                    {
                        MessageBox.Show("Expense deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Get the current budget ID (you need to reload the expenses for this budget)
                        int budgetListIndex = dataGridViewBudgets.CurrentCell.RowIndex;
                        int budgetId = budgetList[budgetListIndex].BudgetID;

                        // Reload the expenses to reflect the deletion
                        LoadExpenses(budgetId);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the expense. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an expense to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }


}



//private void btnDeleteExpense_Click(object sender, EventArgs e)
//{

//    //if (dataGridViewExpenses.SelectedRows.Count > 0)
//    //{
//    //    DataGridViewRow selectedRow = dataGridViewExpenses.SelectedRows[0];
//    //    int expenseId = Convert.ToInt32(selectedRow.Cells["Expense ID"].Value);
//    //    int budgetListIndex = dataGridViewBudgets.CurrentCell.RowIndex;
//    //    int budgetId = budgetList[budgetListIndex].BudgetID;

//    //    bool expenseDeleted = expenseService.DeleteExpense(expenseId);

//    //    if (expenseDeleted)
//    //    {
//    //        LoadExpenses(budgetId); // Refresh expenses
//    //        MessageBox.Show("Expense deleted successfully.");
//    //    }
//    //}
//    //else
//    //{
//    //    MessageBox.Show("Please select an expense to delete.");
//    //}

//}

