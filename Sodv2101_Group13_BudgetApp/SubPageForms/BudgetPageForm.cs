using Microsoft.Data.SqlClient;
using Sodv2101_Group13_BudgetApp.InputForms;
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

        //Error Handler

        //private void btnEditExpense_Click(object sender, EventArgs e)
        //{
        //    if (dataGridViewExpenses.SelectedRows.Count > 0)
        //    {
        //        DataGridViewRow selectedRow = dataGridViewExpenses.SelectedRows[0];

        //        int budgetListIndex = dataGridViewBudgets.CurrentCell.RowIndex;
        //        int budgetId = budgetList[budgetListIndex].BudgetID;

        //        //int budgetId = Convert.ToInt32(selectedRow.Cells["BudgetID"].Value);
        //        string name = selectedRow.Cells["Name"].Value.ToString();
        //        double amount = Convert.ToDouble(selectedRow.Cells["Amount"].Value);
        //        string description = selectedRow.Cells["Description"].Value.ToString();
        //        string dateString = selectedRow.Cells["Time Period"].Value.ToString();

        //        Expense expense = new Expense(budgetId, name, amount, description, dateString);

        //        EditExpenseForm editExpenseForm = new EditExpenseForm();
        //        editExpenseForm.PopulateInputs(expense, budgetId);
        //        if (editExpenseForm.ShowDialog() == DialogResult.OK)
        //        {
        //            LoadExpenses(budgetId); // Refresh expenses
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a single expense to edit.");
        //    }
        //}

        //private void btnDeleteExpense_Click(object sender, EventArgs e)
        //{

        //    if (dataGridViewExpenses.SelectedRows.Count > 0)
        //    {
        //        DataGridViewRow selectedRow = dataGridViewExpenses.SelectedRows[0];
        //        int budgetListIndex = dataGridViewExpenses.CurrentCell.RowIndex;
        //        int budgetId = budgetList[budgetListIndex].BudgetID;

        //        // int budgetId = Convert.ToInt32(selectedRow.Cells["Budget ID"].Value);

        //        bool expenseDeleted = expenseService.DeleteExpense(budgetId);

        //        if (expenseDeleted)
        //        {

        //            LoadExpenses(budgetId);
        //            //LoadBudgets();
        //        }

        //    }

        //}
    }
}

