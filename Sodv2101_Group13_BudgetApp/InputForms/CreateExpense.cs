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

    public partial class CreateExpense : Form
    {
        private ExpenseService expenseService = new ExpenseService();

        private BudgetService budgetService = new BudgetService();



        public CreateExpense()
        {
            InitializeComponent();
            LoadBudgetList(); // Ensure this runs during form initialization
        }

        //added to populate the combobox
        private void PopulateBudgetComboBox()
        {

            var budgets = budgetService.GetBudgetList();

            if (budgets != null && budgets.Any())
            {
                cmbBudgetList.DataSource = budgets;
                cmbBudgetList.DisplayMember = "Name";
                cmbBudgetList.ValueMember = "BudgetId";
            }
            else
            {
                MessageBox.Show("No budgets found.");
            }
        }
        //modified today nov 31
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtExpenseName.Text))
                {
                    lblExpenseOutput.Text = "Expense Name is required.";
                    //MessageBox.Show("Expense Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (numExpenseAmount.Value <= 0)
                {
                    lblExpenseOutput.Text = "Expense Amount must be greater than 0.";

                    //MessageBox.Show("Expense Amount must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbBudgetList.SelectedValue == null)
                {
                    lblExpenseOutput.Text = "Please select a valid budget.";
                    //MessageBox.Show("Please select a valid budget.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Retrieve selected BudgetID from ComboBox
                int selectedBudgetId = (int)cmbBudgetList.SelectedValue;

                // Gather data from form fields
                string name = txtExpenseName.Text.Trim();
                double amount = (double)numExpenseAmount.Value;
                string description = txtDescription.Text.Trim();
                DateTime date = dateTimePicker1.Value;

                // Create Expense object
                Expense newExpense = new Expense
                {
                    BudgetId = selectedBudgetId,
                    Name = name,
                    Amount = amount,
                    Description = description,
                    TimePeriod = date
                };

                // Debugging log for tracking values before insert
                Console.WriteLine($"Attempting to save: BudgetId={newExpense.BudgetId}, Name={newExpense.Name}, Amount={newExpense.Amount}, Description={newExpense.Description}, Date={newExpense.TimePeriod}");

                // Add the expense
                bool isAdded = expenseService.NewExpense(newExpense);

                if (isAdded)
                {
                    lblExpenseOutput.Text = "Expense added successfully.";
                    //MessageBox.Show("Expense added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblExpenseOutput.Text = "Failed to add expense. Please try again.";
                    //MessageBox.Show("Failed to add expense. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //HAD THIS BELOW BEFORE
            //if (txtExpenseName.Text != " ")
            //{
            //    int BudgetID = 1; //figure this out
            //    string Name = txtExpenseName.Text;
            //    double Amount = (double)numExpenseAmount.Value;
            //    string Description = txtDescription.Text;
            //    string DateString = dateTimePicker1.Text;


            //    Expense expense = new Expense(BudgetID, Name, Amount, Description, DateString);

            //    expenseService.NewExpense(expense);

        }


        //ADDED for the combobox nov31
        private void LoadBudgetList()
        {
            {
                try
                {
                    var budgets = budgetService.GetBudgetList();

                    if (budgets != null && budgets.Any())
                    {
                        cmbBudgetList.DataSource = budgets;
                        cmbBudgetList.DisplayMember = "Name";
                        cmbBudgetList.ValueMember = "BudgetId";
                    }
                    else
                    {
                        lblExpenseOutput.Text = "No budgets found. Please create a budget first.";
                        //MessageBox.Show("No budgets found. Please create a budget first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load budget list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Had this below before
                //List<Budget> budgets = new List<Budget>();

                //budgets = budgetService.GetBudgetList();
                //var budgetBindingList = new BindingList<Budget>(budgets);

                //cmbBudgetList.DataSource = budgetBindingList;
                //cmbBudgetList.DisplayMember = "Name";

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
