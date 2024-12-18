﻿using Sodv2101_Group13_BudgetApp.RepositoryDBContext.BudgetServices;
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
        private int currentExpenseId = 0;


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
                lblUpdateExpense.Text = "Expense data is null.\", \"Error\"";
                MessageBox.Show("Expense data is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtExpenseName.Text = expense.Name;
            numExpenseAmount.Value = Convert.ToDecimal(expense.Amount);
            txtDescription.Text = expense.Description;

            if (DateTime.TryParse(expense.TimePeriod.ToString(), out DateTime timePeriod))
            {
                dateTimePicker1.Value = timePeriod;
            }

            cmbExpense.SelectedValue = expense.BudgetId;

            currentExpenseId = expense.ExpenseId; // Assign ExpenseId here.

        }

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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        //NOT SAVING IN THE DATABASE THORWS ERROR NOV 30 11:11pm
        private void btnEditExpense_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentExpenseId <= 0)
                {
                    lblUpdateExpense.Text = "Invalid Expense ID. Please reload the form and try again";

                    //MessageBox.Show("Invalid Expense ID. Please reload the form and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtExpenseName.Text))
                {
                    lblUpdateExpense.Text = "Expense Name is required. ";
                    //MessageBox.Show("Expense Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (numExpenseAmount.Value <= 0)
                {
                    lblUpdateExpense.Text = "Expense Amount must be greater than 0.";
                    //MessageBox.Show("Expense Amount must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbExpense.SelectedValue == null)
                {
                    lblUpdateExpense.Text = "Please select a valid budget.";
                    //MessageBox.Show("Please select a valid budget.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Retrieve the selected BudgetId from the ComboBox
                int selectedBudgetId = (int)cmbExpense.SelectedValue;

                // Retrieve other data from the form fields
                string name = txtExpenseName.Text.Trim();
                double amount = Convert.ToDouble(numExpenseAmount.Value);
                string description = txtDescription.Text.Trim();
                DateTime date = dateTimePicker1.Value;

                // Create a new Expense object
                Expense updatedExpense = new Expense
                {
                    ExpenseId = currentExpenseId,
                    BudgetId = selectedBudgetId,
                    Name = name,
                    Amount = amount,
                    Description = description,
                    TimePeriod = date
                };

                // Call the service method
                bool isUpdated = expenseService.UpdateExpense(updatedExpense, selectedBudgetId);

                if (isUpdated)
                {
                    lblUpdateExpense.Text = "Expense updated successfully.";
                    //MessageBox.Show("Expense updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblUpdateExpense.Text = "Failed to update the expense. Please try again.";
                    //MessageBox.Show("Failed to update the expense. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

<<<<<<< HEAD
            //second try
            //{ // Validate required fields
            //    if (string.IsNullOrEmpty(txtExpenseName.Text) || string.IsNullOrEmpty(txtDescription.Text))
            //    {
            //        MessageBox.Show("Please fill in all fields.");
            //        return;
            //    }

            //    // Validate date
            //    if (string.IsNullOrEmpty(dateTimePicker1.Text))
            //    {
            //        MessageBox.Show("Please select a valid date.");
            //        return;
            //    }

            //    // Retrieve the selected BudgetId from the ComboBox
            //    int selectedBudgetId = (int)cmbExpense.SelectedValue;

            //    // Retrieve other data from the form fields
            //    string name = txtExpenseName.Text;
            //    double amount = Convert.ToDouble(numExpenseAmount.Value);
            //    string description = txtDescription.Text;
            //    string dateString = dateTimePicker1.Text;

            //    // Create a new Expense object with the selected BudgetId
            //    Expense expense = new Expense(selectedBudgetId, name, amount, description, dateString);

            //    // Pass the Expense object and selectedBudgetId to the EditExpense method
            //    bool isUpdated = expenseService.UpdateExpense(expense, expense.ExpenseId); // Pass ExpenseId here if required

            //    if (isUpdated)
            //    {
            //        MessageBox.Show("Expense updated successfully.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error updating expense.");
            //    }

            //    // Close the form
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}

            //first try
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
        }
        //TO POPULATE THE COMBOBOX NOV 11:11pm
        private void EditExpenseForm_Load(object sender, EventArgs e)
        {
            PopulateBudgetComboBox(); // Populate the ComboBox when the form is loaded
        }
=======
        } 

            private void EditExpenseForm_Load(object sender, EventArgs e)
            {
                PopulateBudgetComboBox(); // Populate the ComboBox when the form is loaded
            }
>>>>>>> 7a61e77a8a1763cd816f32646cc05fe056457bde

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}



    