using Sodv2101_Group13_BudgetApp.RepositoryDBContext.BudgetServices;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.ContributionService;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.FinancialGoals;
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
            DataTable goalTable = goalService.GetBudgetTable();

            dataGridViewFinancialGoals.DataSource = goalTable;

        }
    }
}
