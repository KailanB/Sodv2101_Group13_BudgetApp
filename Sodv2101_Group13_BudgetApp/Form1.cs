using Microsoft.Data.SqlClient;
using Sodv2101_Group13_BudgetApp.Input_Forms;

namespace Sodv2101_Group13_BudgetApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();



		}

		private void btnCreateBudget_Click(object sender, EventArgs e)
		{

			// create a new budget form on button click and show it 
			// proceed to the budget form
			CreateBudget budgetForm = new CreateBudget();
			budgetForm.ShowDialog();


		}
	}
}
