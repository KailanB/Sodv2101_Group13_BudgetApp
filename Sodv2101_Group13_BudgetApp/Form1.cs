using Microsoft.Data.SqlClient;
using Sodv2101_Group13_BudgetApp.InputForms;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.BudgetServices;
using Sodv2101_Group13_BudgetApp.SubPageForms;

namespace Sodv2101_Group13_BudgetApp
{
    public partial class Form1 : Form
    {



        private BudgetService budgetService = new BudgetService();
        public Form1()
        {
            InitializeComponent();


            LoadBudgetData();

        }

        private void btnCreateBudget_Click(object sender, EventArgs e)
        {

            // create a new budget form on button click and show it 
            // proceed to the budget form
            CreateBudget budgetForm = new CreateBudget();
            budgetForm.ShowDialog();

        }

        private void btnToolStripBudget_Click(object sender, EventArgs e)
        {
            BudgetPageForm budgetForm = new BudgetPageForm();
            budgetForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void LoadBudgetData()
        {
            List<Budget> budgets = budgetService.GetBudgetList();
            int locationYIncrease = 0;
            foreach (Budget budget in budgets)
            {
                Label label = new Label();
                label.Location = new Point(20, 225 + locationYIncrease);
                label.Text = budget.Name;
                this.Controls.Add(label);
                locationYIncrease += 30;



            }
            //MessageBox.Show(budgets.Count.ToString());
        }

        private void btnToolStripDropDownButtonGoals_Click(object sender, EventArgs e)
        {
            GoalPageForm goalForm = new GoalPageForm();
            goalForm.ShowDialog();
        }
    }
}
