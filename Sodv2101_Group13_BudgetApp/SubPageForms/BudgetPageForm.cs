using Microsoft.Data.SqlClient;
using Sodv2101_Group13_BudgetApp.InputForms;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.BudgetServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using Sodv2101_Group13_BudgetApp.DBConnectionClass;

namespace Sodv2101_Group13_BudgetApp.SubPageForms
{
	public partial class BudgetPageForm : Form
	{

		private DBConnection dbConnection = new DBConnection();



		private BudgetService budgetService = new BudgetService();
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
			if(dataGridViewBudgets.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridViewBudgets.SelectedRows[0];

				int budgetId = Convert.ToInt32(selectedRow.Cells["BudgetID"].Value);

				bool budgetDeleted = budgetService.DeleteBudget(budgetId);
				if(budgetDeleted)
				{
					LoadBudgets();
				}
			}
		}
	}
}
