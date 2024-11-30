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
            goalTable.Columns.Add("Max", typeof(double));
            goalTable.Columns.Add("Description", typeof(string));
            goalTable.Columns.Add("Deadline", typeof(DateTime));

            foreach(var goal in goalList)
            {
                goalTable.Rows.Add(goal.Name, goal.Max, goal.Description, goal.Deadline);
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
            

        }

        private void btnGFPDeleteGoal_Click(object sender, EventArgs e)
        {
            if (dataGridViewFinancialGoals.SelectedRows != null)
            {
                //Still working on the Logic
                //selectedGoal.Remove(goal);
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
