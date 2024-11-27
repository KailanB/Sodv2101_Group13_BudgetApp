using Microsoft.Data.SqlClient;
using Sodv2101_Group13_BudgetApp.InputForms;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.BudgetServices;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.ExpenseService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using DBConnectionClass;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.ExpenseService;

namespace Sodv2101_Group13_BudgetApp.SubPageForms
{
    public partial class BudgetPageForm : Form
    {

        // private DBConnection dbConnection = new DBConnection();

         

        private BudgetService budgetService = new BudgetService();

		private ExpenseService expenseService = new ExpenseService();
		public BudgetPageForm()
        {
            InitializeComponent();

            LoadBudgets();
        }

        private void LoadBudgets()
        {
            DataTable budgetTable = budgetService.GetBudgetTable();

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

                int budgetId = Convert.ToInt32(selectedRow.Cells["BudgetID"].Value);

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

				int budgetId = Convert.ToInt32(selectedRow.Cells["BudgetID"].Value);

                expenses = expenseService.GetExpenseByBudgetId(budgetId);

				DataTable expenseTable = new DataTable();

                //DataTable table = new DataTable();
                //table.Columns.Add("Name", typeof(string));
                //table.Columns.Add("Team", typeof(string));
                //table.Columns.Add("ID", typeof(int));
                //foreach (var player in players)
                //{
                //	table.Rows.Add(player.Name, player.Team, player.Id);
                //}
                //dataGridPlayers.DataSource = table;
                //dataGridPlayers.SelectionChanged += DataGrid_PlayerSelected;

                //int expenseId, int budgetId, string name, double amount, string description, string timePeriod

                MessageBox.Show(expenses.Count.ToString());

				expenseTable.Columns.Add("Name", typeof(string));
                expenseTable.Columns.Add("Amount", typeof(double));
				expenseTable.Columns.Add("Description", typeof(string));
				expenseTable.Columns.Add("Time Period", typeof(string));
				expenseTable.Columns.Add("Expense ID", typeof(int));
                foreach(var exp in expenses)
                {
                    expenseTable.Rows.Add(exp.Name, exp.Amount, exp.Description, exp.TimePeriod, exp.ExpenseId);
                }


				dataGridViewExpenses.DataSource = expenseTable;

				//bool budgetDeleted = budgetService.DeleteBudget(budgetId);
				//if (budgetDeleted)
				//{
				//	LoadBudgets();
				//}
			}
           
        }
    }
}

