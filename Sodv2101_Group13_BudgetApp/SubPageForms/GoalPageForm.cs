using Microsoft.Identity.Client;
using Sodv2101_Group13_BudgetApp.InputForms;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.BudgetServices;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.ContributionServices;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.FinancialGoalsService;
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
	public partial class GoalPageForm : Form
	{

		public FinancialGoal SelectedGoal { get; private set; }
		private List<FinancialGoal> goalList = new List<FinancialGoal>();
		private FinancialGoalService goalService = new FinancialGoalService();
		private ContributionService contributionService = new ContributionService();
		private List<Contribution> contributionsList = new List<Contribution>();

		public GoalPageForm()
		{
			InitializeComponent();
			LoadGoals();
		}
		public void LoadGoals()
		{
			goalList = goalService.GetFinancialGoalList();
			DataTable goalTable = new DataTable();
			goalTable.Columns.Add("GoalID", typeof(int));
			goalTable.Columns.Add("Name", typeof(string));
			goalTable.Columns.Add("Max Amount", typeof(double));
			goalTable.Columns.Add("Description", typeof(string));
			goalTable.Columns.Add("Deadline", typeof(DateTime));

			foreach (var goal in goalList)
			{
				goalTable.Rows.Add(goal.GoalID, goal.Name, goal.MaxAmount, goal.Description, goal.Deadline);
			}
			dataGridViewFinancialGoals.DataSource = goalTable;

			if (dataGridViewFinancialGoals.Columns.Contains("GoalID"))
			{
				dataGridViewFinancialGoals.Columns["GoalID"].Visible = false;
			}
		}
		public void LoadContribution()
		{
			if (SelectedGoal == null)
			{
				MessageBox.Show("Please select a financial goal to view contributions.", "No Goal Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (dataGridViewFinancialGoals.SelectedRows.Count > 0)
			{
				int selectedIndex = dataGridViewFinancialGoals.SelectedRows[0].Index;
				SelectedGoal = goalList[selectedIndex];

				//goalID = Convert.ToInt32(dataGridViewFinancialGoals.SelectedRows[0].Cells["GoalID"].Value);
				contributionsList = contributionService.GetContributionList(SelectedGoal.GoalID);
				dataGridViewContributions.DataSource = contributionsList;
				if (dataGridViewContributions.Columns.Contains("GoalID"))
				{
					dataGridViewContributions.Columns["GoalID"].Visible = false;
				}
				if (dataGridViewContributions.Columns.Contains("ContributionID"))
				{
					dataGridViewContributions.Columns["ContributionID"].Visible = false;
				}
			}



			//DataTable contributionTable = new DataTable();
			//contributionTable.Columns.Add("Amount", typeof(double));
			//contributionTable.Columns.Add("Description", typeof (string));
			//contributionTable.Columns.Add("Date", typeof(DateTime));

			//foreach(var contribution in contributionsList)
			//{
			//    contributionTable.Rows.Add(contribution.Amount, contribution.Description, contribution.Date);
			//}
			//dataGridViewContributions.DataSource = contributionTable;
			//if(dataGridViewFinancialGoals.SelectedRows.Count > 0)
			//{
			//    int selectedRowIndex = dataGridViewFinancialGoals.SelectedRows[0].Index;
			//    goalID = selectedRowIndex;
			//    contributionsList = contributionService.GetContributionList(goalID);
			//    dataGridViewContributions.DataSource = contributionsList;
			//    dataGridViewContributions.Columns["GoalID"].Visible = false;
			//    dataGridViewContributions.Columns["ContributionID"].Visible = false;
			//}

		}

		private void LoadContributionsOfGoal(int goalId)
		{

			var goal = goalList.Find(goal => goal.GoalID == goalId);

			if(goal != null)
			{
				contributionsList = contributionService.GetContributionList(goal.GoalID);
				dataGridViewContributions.DataSource = contributionsList;
				if (dataGridViewContributions.Columns.Contains("GoalID"))
				{
					dataGridViewContributions.Columns["GoalID"].Visible = false;
				}
				if (dataGridViewContributions.Columns.Contains("ContributionID"))
				{
					dataGridViewContributions.Columns["ContributionID"].Visible = false;
				}
			}
			
		}

		private void btnGFPViewGoal_Click(object sender, EventArgs e)
		{
			LoadContribution();
		}
		public List<FinancialGoal> GetGoals()
		{
			return goalList;
		}

		private void toolStripMenuItemAddGoal_Click(object sender, EventArgs e)
		{
			AddGoalForm addGoalForm = new AddGoalForm();
			if (addGoalForm.ShowDialog() == DialogResult.OK)
			{
				FinancialGoal newGoal = addGoalForm.NewGoal;

				if (newGoal != null)
				{
					goalService.CreateFinancialGoal(newGoal);
					LoadGoals();
				}
			}
		}

		private void btnGFPAddGoal_Click(object sender, EventArgs e)
		{
			AddGoalForm addGoalForm = new AddGoalForm();
			if (addGoalForm.ShowDialog() == DialogResult.OK)
			{
				FinancialGoal newGoal = addGoalForm.NewGoal;

				if (newGoal != null)
				{
					goalService.CreateFinancialGoal(newGoal);
					LoadGoals();
				}
			}

		}

		private void btnGFPDeleteGoal_Click(object sender, EventArgs e)
		{
			if (dataGridViewFinancialGoals.SelectedRows.Count > 0)
			{
				//Still working on the Logic
				int selectedIndex = dataGridViewFinancialGoals.SelectedRows[0].Index;
				SelectedGoal = goalList[selectedIndex];

				DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this goal?", "Confirm Deletion", MessageBoxButtons.YesNo);
				if (confirmResult == DialogResult.Yes)
				{
					goalService.DeleteFinancialGoal(SelectedGoal.GoalID);
					LoadGoals();
				}
			}
			else
			{
				lblGPFError.Text = "Please Select a Goal to Delete!";
			}
		}

		private void toolStripDropDownButtonGoals_DoubleClick(object sender, EventArgs e)
		{
			AddGoalForm addGoal = new AddGoalForm();
			addGoal.ShowDialog();
		}

		private void lblGPFError_TextChanged(object sender, EventArgs e)
		{

			lblGPFError.ForeColor = Color.Red;
		}

		private void btnGFPEditGoal_Click(object sender, EventArgs e)
		{
			if (dataGridViewFinancialGoals.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridViewFinancialGoals.SelectedRows[0];

				int goalIndex = dataGridViewFinancialGoals.CurrentCell.RowIndex;
				SelectedGoal = goalList[goalIndex];


				string goalName = selectedRow.Cells["Name"].Value.ToString();
				double amount = Convert.ToDouble(selectedRow.Cells["Max Amount"].Value);
				string description = selectedRow.Cells["Description"].Value.ToString();
				DateTime deadline = Convert.ToDateTime(selectedRow.Cells["Deadline"].Value.ToString());

				FinancialGoal goal = new FinancialGoal(goalName, amount, description, deadline);

				EditGoalForm editGoal = new EditGoalForm();
				editGoal.PopulateInput(goal, SelectedGoal.GoalID);
				DialogResult newGoalResult = editGoal.ShowDialog();
				if (newGoalResult == DialogResult.OK)
				{
					LoadGoals();
				}
			}
			else
			{
				lblGPFError.Text = "Please select a goal to edit";
			}

		}

		private void toolStripMenuItemRemoveContribution_Click(object sender, EventArgs e)
		{
			goalList = GetGoals();

			if (goalList == null || !goalList.Any())
			{
				MessageBox.Show("No goals available . Please add a financial goal first.", "No Goals", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (dataGridViewFinancialGoals.SelectedRows.Count > 0)
			{
				var selectedRow = dataGridViewFinancialGoals.SelectedRows[0];
				int goalIndex = dataGridViewFinancialGoals.CurrentCell.RowIndex;
				SelectedGoal = goalList[goalIndex];
				if (SelectedGoal != null)
				{
					// Open the RemoveContribution form and pass the selected goal
					RemoveContribution removeContribution = new RemoveContribution(SelectedGoal);
					removeContribution.ShowDialog();

					// Reload the contributions and goals after the dialog is closed
					LoadGoals();
				}
				else
				{
					MessageBox.Show("Failed to retrieve the selected goal. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Please select a goal to manage contributions.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}


		private void OpenAddContributionForm()
		{
			goalList = GetGoals();

			if (goalList == null || !goalList.Any())
			{
				MessageBox.Show("No goals available . Please add a financial goal first.", "No Goals", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			AddContribution addContribution = new AddContribution(goalList);
			addContribution.ShowDialog();
		}

		private void btnAddConbtribution_Click(object sender, EventArgs e)
		{
			AddContribution addContributionForm = new AddContribution();
			addContributionForm.ShowDialog();
		}

		private void btnEditContribution_Click(object sender, EventArgs e)
		{

			// I don't think it is necessary here that a user have a goal selected to edit a contribution. 
			// since the user must select a contribution that means a contribution exists and so does the goal it belongs to
			//goalList = GetGoals();

			//if (goalList == null || !goalList.Any())
			//{
			//	MessageBox.Show("No goals available . Please add a financial goal first.", "No Goals", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//	return;
			//}
			if (dataGridViewContributions.SelectedRows.Count > 0)
			{
				// this was all working with goals instead of contributions so the edit window was populating the wrong values
				var selectedRow = dataGridViewContributions.SelectedRows[0];
				int contributionIndex = dataGridViewContributions.CurrentCell.RowIndex;
				Contribution contribution = contributionsList[contributionIndex];

				
				if (SelectedGoal != null)
				{
					// Open the UpdateContribution form and pass the selected goal
					UpdateContribution updateContribution = new UpdateContribution(contribution);
					DialogResult result = updateContribution.ShowDialog();
					if(result == DialogResult.OK )
					{

						int goalID = updateContribution.GoalId;
						// Reload the contributions and goals after the dialog is closed
						// this LoadGoals() is bugging the form out
						//LoadGoals();

						LoadContributionsOfGoal(goalID);
					}

					
				}
				else
				{
					lblGPFError.Text = "Please select a goal to edit";
				}
			}
			else
			{
				MessageBox.Show("Please select a goal to manage contributions.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnDeleteContribution_Click(object sender, EventArgs e)
		{

			if (dataGridViewContributions.SelectedRows.Count > 0)
			{

				DataGridViewRow selectedRow = dataGridViewContributions.SelectedRows[0];
				int contributionIndex = dataGridViewContributions.CurrentCell.RowIndex;

				int contributionID = contributionsList[contributionIndex].ContributionID;

				int GoalID = contributionsList[contributionIndex].GoalID;

				// int budgetId = Convert.ToInt32(selectedRow.Cells["Budget ID"].Value);

				bool contributionDeleted = contributionService.RemoveContribution(contributionID);
				if (contributionDeleted)
				{
					LoadContributionsOfGoal(GoalID);
				}
			}



			//goalList = GetGoals();

			//if (goalList == null || !goalList.Any())
			//{
			//	MessageBox.Show("No goals available . Please add a financial goal first.", "No Goals", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//	return;
			//}
			//if (dataGridViewFinancialGoals.SelectedRows.Count > 0)
			//{
			//	var selectedRow = dataGridViewFinancialGoals.SelectedRows[0];
			//	int goalIndex = dataGridViewFinancialGoals.CurrentCell.RowIndex;
			//	SelectedGoal = goalList[goalIndex];
			//	if (SelectedGoal != null)
			//	{
			//		// Open the RemoveContribution form and pass the selected goal
			//		RemoveContribution removeContribution = new RemoveContribution(SelectedGoal);
			//		removeContribution.ShowDialog();

			//		// Reload the contributions and goals after the dialog is closed
			//		LoadGoals();
			//	}
			//	else
			//	{
			//		MessageBox.Show("Failed to retrieve the selected goal. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	}
			//}
			//else
			//{
			//	MessageBox.Show("Please select a goal to manage contributions.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//}
		}


		private void dataGridViewFinancialGoals_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewFinancialGoals.SelectedRows.Count > 0)
			{
				int selectedIndex = dataGridViewFinancialGoals.SelectedRows[0].Index;
				SelectedGoal = goalList[selectedIndex];
			}
			else
			{
				SelectedGoal = null;
			}
		}

		

		private void toolStripMenuItemEditGoal_Click(object sender, EventArgs e)
		{

			if (dataGridViewFinancialGoals.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridViewFinancialGoals.SelectedRows[0];

				int goalIndex = dataGridViewFinancialGoals.CurrentCell.RowIndex;
				SelectedGoal = goalList[goalIndex];


				string goalName = selectedRow.Cells["Name"].Value.ToString();
				double amount = Convert.ToDouble(selectedRow.Cells["Max Amount"].Value);
				string description = selectedRow.Cells["Description"].Value.ToString();
				DateTime deadline = Convert.ToDateTime(selectedRow.Cells["Deadline"].Value.ToString());

				FinancialGoal goal = new FinancialGoal(goalName, amount, description, deadline);

				EditGoalForm editGoal = new EditGoalForm();
				editGoal.PopulateInput(goal, SelectedGoal.GoalID);
				DialogResult newGoalResult = editGoal.ShowDialog();
				if (newGoalResult == DialogResult.OK)
				{
					LoadGoals();
					
				}
			}
			else
			{
				lblGPFError.Text = "Please select a goal to edit";
			}


		}

		private void toolStripMenuItemDeleteGoal_Click(object sender, EventArgs e)
		{
			if (dataGridViewFinancialGoals.SelectedRows.Count > 0)
			{
				//Still working on the Logic
				int selectedIndex = dataGridViewFinancialGoals.SelectedRows[0].Index;
				SelectedGoal = goalList[selectedIndex];

				DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this goal?", "Confirm Deletion", MessageBoxButtons.YesNo);
				if (confirmResult == DialogResult.Yes)
				{
					goalService.DeleteFinancialGoal(SelectedGoal.GoalID);
					LoadGoals();
				}
			}
			else
			{
				lblGPFError.Text = "Please Select a Goal to Delete!";
			}
		}











		//private void toolStripMenuItemUpdateContribution_Click(object sender, EventArgs e)
		//{
		//	goalList = GetGoals();

		//	if (goalList == null || !goalList.Any())
		//	{
		//		MessageBox.Show("No goals available . Please add a financial goal first.", "No Goals", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		//		return;
		//	}
		//	if (dataGridViewFinancialGoals.SelectedRows.Count > 0)
		//	{
		//		var selectedRow = dataGridViewFinancialGoals.SelectedRows[0];
		//		int goalIndex = dataGridViewFinancialGoals.CurrentCell.RowIndex;
		//		SelectedGoal = goalList[goalIndex];
		//		if (SelectedGoal != null)
		//		{
		//			// Open the UpdateContribution form and pass the selected goal
		//			UpdateContribution updateContribution = new UpdateContribution(SelectedGoal);
		//			updateContribution.ShowDialog();

		//			// Reload the contributions and goals after the dialog is closed
		//			LoadGoals();
		//		}
		//		else
		//		{
		//			lblGPFError.Text = "Please select a goal to edit";
		//		}
		//	}
		//	else
		//	{
		//		MessageBox.Show("Please select a goal to manage contributions.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		//	}
		//}




		//private void btnGFPViewGoal_Click(object sender, EventArgs e)
		//{
		//	contextMenuStripView.Show(btnGFPViewGoal, btnGFPViewGoal.Location);

		//}

		//private void toolStripMenuItemViewGoals_Click(object sender, EventArgs e)
		//{
		//	LoadGoals();
		//}

		//private void toolStripMenuItemViewContribution_Click(object sender, EventArgs e)
		//{
		//	LoadContribution();
		//}


	}
}
