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
        private List<FinancialGoal> goalList = new List<FinancialGoal>();
        private FinancialGoalService goalService = new FinancialGoalService();
        private ContributionService ContributionService = new ContributionService();
        public GoalPageForm()
        {
            InitializeComponent();
            LoadGoals();
        }
        private void LoadGoals()
        {
            goalList = goalService.GetFinancialGoalList();
            DataTable goalTable = new DataTable();
            goalTable.Columns.Add("Name", typeof(string));
            goalTable.Columns.Add("MaxAmount", typeof(double));
            goalTable.Columns.Add("Description", typeof(string));
            goalTable.Columns.Add("Deadline", typeof(DateTime));

            foreach(var goal in goalList)
            {
                goalTable.Rows.Add(goal.Name, goal.MaxAmount, goal.Description, goal.Deadline);
            }
            dataGridViewFinancialGoals.DataSource = goalTable;

        }

        private void toolStripDropDownButtonGoals_Click(object sender, EventArgs e)
        {
            LoadGoals();
        }

        private void toolStripMenuItemAddGoal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGFPAddGoal_Click(object sender, EventArgs e)
        {
            AddGoalForm addGoalForm = new AddGoalForm();
            if(addGoalForm.ShowDialog() == DialogResult.OK)
            {
                FinancialGoal newGoal = addGoalForm.NewGoal;

                if(newGoal != null)
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
                FinancialGoal selectedGoal = goalList[selectedIndex];

                DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this goal?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if(confirmResult == DialogResult.Yes)
                {
                    goalService.DeleteFinancialGoal(selectedGoal.GoalID);
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
    }
}
