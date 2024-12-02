using Microsoft.Data.SqlClient;
using Sodv2101_Group13_BudgetApp.InputForms;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.BudgetServices;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.ContributionServices;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.DBIncome;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.FinancialGoalsService;
using Sodv2101_Group13_BudgetApp.SubPageForms;
using System.Drawing;

namespace Sodv2101_Group13_BudgetApp
{
    public partial class Form1 : Form
    {
        private BudgetService budgetService = new BudgetService();
        private FinancialGoalService goalService = new FinancialGoalService();
        private ContributionService ContributionService = new ContributionService();
        private IncomeService incomeService = new IncomeService();

        private List<Label> formLabels = new List<Label>();
        public Form1()
        {
            InitializeComponent();
            LoadDashboardData();

        }

        public void LoadDashboardData()
        {
            // remove all labels and renew based on new data
            foreach (Label label in formLabels)
            {
                this.Controls.Remove(label);
            }
            formLabels.Clear();
            LoadBudgetData();
            LoadIncomeData();
            LoadCustomLabels();
            LoadGoalData();
        }


        private void btnToolStripBudget_Click(object sender, EventArgs e)
        {
            BudgetPageForm budgetForm = new BudgetPageForm();
            DialogResult result = budgetForm.ShowDialog();
            // regardless of OK or cancel - Reload form data
            if (result == DialogResult.OK)
            {
                LoadDashboardData();
            }
            else
            {
                LoadDashboardData();
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GoalPageForm goalForm = new GoalPageForm();
            DialogResult result = goalForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadDashboardData();
            }
            else
            {
                LoadDashboardData();
            }
        }
        private void btnToolStripIncome_Click(object sender, EventArgs e)
        {
            IncomePageForm incomePage = new IncomePageForm();
            DialogResult result = incomePage.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadDashboardData();
            }
            else
            {
                LoadDashboardData();
            }
        }





        private void toolBtnAddBudget_Click(object sender, EventArgs e)
        {
            CreateBudget budgetForm = new CreateBudget();
            DialogResult result = budgetForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadDashboardData();
            }
        }

        private void addExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateExpense newExpense = new CreateExpense();
            DialogResult result = newExpense.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadDashboardData();
            }
        }

        private void addGoalContributionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateContribution addContribution = new CreateContribution();
            DialogResult result = addContribution.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadDashboardData();
            }
        }

        private void toolStripMenuItemAddFinanceGoal_Click(object sender, EventArgs e)
        {
            CreateGoalForm addGoalForm = new CreateGoalForm();
            DialogResult result = addGoalForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadDashboardData();
            }
        }

        private void toolStripMenuItemAddIncome_Click(object sender, EventArgs e)
        {
            CreateIncome createIncome = new CreateIncome();
            DialogResult result = createIncome.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadDashboardData();
            }
        }

        private void LoadBudgetData()
        {

            List<Budget> budgets = budgetService.GetBudgetList();
            int locationYIncrease = 0;
            Bitmap bitmap = new Bitmap(250, 250);

            // The dashboard can onyl display a maximum of 8 budgets
            int maxBudgetDisplayCounter = 1;
            foreach (Budget budget in budgets)
            {
                Label label = new Label();
                label.Location = new Point(40, 135 + locationYIncrease);
                label.Text = budget.Name;
                this.Controls.Add(label);
                formLabels.Add(label);

                // get current date
                DateTime date = DateTime.Now;
                // pass month to get only expenses for that month
                double expensesTotal = budget.GetExpenseTotalByMonth(date.Month);
                Label labelExpense = new Label();
                labelExpense.AutoSize = false;
                labelExpense.Width = 300;
                labelExpense.Location = new Point(420, 135 + locationYIncrease);
                labelExpense.Text = $"Max: {budget.Max} | Spent: {expensesTotal} | {(budget.Max - expensesTotal >= 0 ? "Remaining: " + (budget.Max - expensesTotal).ToString() : "OVER BUDGET!" )}";
                formLabels.Add(labelExpense);

                this.Controls.Add(labelExpense);

                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // calculate percentage spent
                    double percentSpent = ((expensesTotal * 100) / budget.Max) / 100;

                    // define bar of spent amount
                    int spent = (Int32)(percentSpent * 250);
                    // define bar of remainder
                    int remaining = 250 - spent;
                    // rectangle x axis here start "spent" percent over since that portion will be red
                    // recntangle width is then remaining amount
                    Rectangle rectRemainder = new Rectangle(0 + spent, 0 + locationYIncrease + 5, remaining, 20);
                    // rectangle here is simply width of spent
                    Rectangle rectSpent = new Rectangle(0, 0 + locationYIncrease + 5, spent, 20);

                    // draw green
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 150, 25)))
                    {
                        g.FillRectangle(brush, rectRemainder);
                    }
                    // draw red
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(210, 15, 15)))
                    {
                        g.FillRectangle(brush, rectSpent);
                    }
                }
                locationYIncrease += 30;

                maxBudgetDisplayCounter++;
                // The dashboard can onyl display a maximum of 8 budgets
                if (maxBudgetDisplayCounter > 8)
                    break;
            }

            picBudgetGraphs.Image = bitmap;

        }

        private void LoadIncomeData()
        {

            Label monthlyEarning = new Label();
            monthlyEarning.AutoSize = false;
            monthlyEarning.Width = 250;
            monthlyEarning.Location = new Point(20, 70);
            monthlyEarning.Font = new Font("Segoe UI", 12);
            formLabels.Add(monthlyEarning);

            List<Income> incomes = incomeService.GetIncomeList();

            double incomeTotal = 0;
            foreach (Income income in incomes)
            {
                // get current date
                DateTime date = DateTime.Now;
                // pass month to get only expenses for that month
                incomeTotal += income.GetMonthlyEarnings(date.Month);

            }
            monthlyEarning.Text = $"Monthly Earnings: ${incomeTotal.ToString()}";
            this.Controls.Add(monthlyEarning);

        }



        private void LoadGoalData()
        {

            List<FinancialGoal> goals = goalService.GetFinancialGoalList();
            int locationYIncrease = 0;
            int locationYStart = 500;
            int locationXStart = 20;
            Bitmap bitmap = new Bitmap(250, 250);

            // The dashboard can onyl display a maximum of 8 budgets
            int maxGoalDisplayCounter = 1;
            foreach (FinancialGoal goal in goals)
            {
                Label label = new Label();
                label.Location = new Point(locationXStart, locationYStart + locationYIncrease);
                label.Text = goal.Name;
                this.Controls.Add(label);
                formLabels.Add(label);

                // get current date
                DateTime date = DateTime.Now;
                // pass month to get only expenses for that month
                double totalContributions = goal.GetContributionTotal();
                Label labelExpense = new Label();
                labelExpense.AutoSize = false;
                labelExpense.Width = 250;
                labelExpense.Location = new Point(400 + locationXStart, locationYStart + locationYIncrease);
                labelExpense.Text = $"Goal: {goal.MaxAmount} | Saved: {totalContributions} | {(goal.MaxAmount - totalContributions > 0 ? goal.MaxAmount - totalContributions + " To go!!" : "GOAL MET!" )}";
                formLabels.Add(labelExpense);

                this.Controls.Add(labelExpense);

                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // calculate percentage spent
                    double percentSpent = ((totalContributions * 100) / goal.MaxAmount) / 100;

                    // define bar of spent amount
                    int spent = (Int32)(percentSpent * 250);
                    // define bar of remainder
                    int remaining = 250 - spent;
                    // rectangle x axis here start "spent" percent over since that portion will be red
                    // recntangle width is then remaining amount
                    Rectangle rectRemainder = new Rectangle(0 + spent, 0 + locationYIncrease + 5, remaining, 20);
                    // rectangle here is simply width of spent
                    Rectangle rectSpent = new Rectangle(0, 0 + locationYIncrease + 5, spent, 20);

                    // draw blue
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 25, 150)))
                    {
                        g.FillRectangle(brush, rectRemainder);
                    }
                    // draw green
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 150, 25)))
                    {
                        g.FillRectangle(brush, rectSpent);
                    }
                }
                locationYIncrease += 30;

                maxGoalDisplayCounter++;
                // The dashboard can onyl display a maximum of 8 budgets
                if (maxGoalDisplayCounter > 8)
                    break;
            }

            picGoalGraph.Image = bitmap;

        }

        // these labels are created and tracked via custom methods to accomodate for different screen sizes
        // otherwise creating custom labels to display dynamic data causes errors in the UI
        private void LoadCustomLabels()
        {
            // Welcome to app label
            Label budgetApp = new Label();
            budgetApp.AutoSize = false;
            budgetApp.Width = 350;
            budgetApp.Height = 30;
            budgetApp.Location = new Point(10, 30);
            budgetApp.Font = new Font("Segoe UI", 14);
            budgetApp.Text = "Welcome to the Budget App!";
            this.Controls.Add(budgetApp);
            formLabels.Add(budgetApp);
            //650
            // Budgets List label
            Label budgetLabel = new Label();
            budgetLabel.AutoSize = false;
            budgetLabel.Width = 100;
            budgetLabel.Height = 20;
            budgetLabel.Location = new Point(20, 110);
            budgetLabel.Font = new Font("Segoe UI", 10);
            budgetLabel.Text = "Budgets";
            this.Controls.Add(budgetLabel);
            formLabels.Add(budgetLabel);
            // 
            // Goal list label
            Label goalLabel = new Label();
            goalLabel.AutoSize = false;
            goalLabel.Width = 100;
            goalLabel.Height = 20;
            goalLabel.Location = new Point(20, 405);
            goalLabel.Font = new Font("Segoe UI", 10);
            goalLabel.Text = "Financial Goals";
            this.Controls.Add(goalLabel);
            formLabels.Add(goalLabel);

        }



        // ----------------------------------------------------------------------------------------------
        // GOAL SECTION
        //private void toolStripDropDownButtonGoals_Click(object sender, EventArgs e)
        //{
        //	GoalPageForm goalForm = new GoalPageForm();
        //	goalForm.ShowDialog();
        //}

        //private void toolStripMenuItemAddGoal_Click(object sender, EventArgs e)
        //{
        //    CreateGoalForm addGoal = new CreateGoalForm();
        //    addGoal.ShowDialog();
        //}

        //private void toolStripDropDownButtonGoals_DoubleClick(object sender, EventArgs e)
        //{
        //	GoalPageForm goalForm = new GoalPageForm();
        //	goalForm.ShowDialog();
        //}

        //private void toolStripMenuItemEditGoal_Click(object sender, EventArgs e)
        //{
        //	GoalPageForm goalForm = new GoalPageForm();
        //	goalForm.ShowDialog();
        //	if (DialogResult == DialogResult.OK)
        //	{
        //		FinancialGoal selectedGoal = goalForm.SelectedGoal;

        //		if (selectedGoal != null)
        //		{
        //			EditGoalForm editGoal = new EditGoalForm();
        //			editGoal.PopulateInput(selectedGoal, selectedGoal.GoalID);
        //			DialogResult result = editGoal.ShowDialog();
        //			if (result == DialogResult.OK)
        //			{
        //				goalForm.LoadGoals();
        //			}
        //		}
        //		else
        //		{
        //			Label errorLabel = new Label();
        //			errorLabel.Text = "No goal was selected to edit.";
        //		}


        //	}

        //}

        //private void toolStripMenuItemDeleteGoal_Click(object sender, EventArgs e)
        //{
        //	GoalPageForm goalForm = new GoalPageForm();
        //	goalForm.ShowDialog();
        //	if (DialogResult == DialogResult.OK)
        //	{
        //		FinancialGoal selectedGoal = goalForm.SelectedGoal;

        //        if (selectedGoal != null)
        //        {
        //            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this goal?", "Confirm Deletion", MessageBoxButtons.YesNo);
        //            if (confirmResult == DialogResult.Yes)
        //            {
        //                goalService.DeleteFinancialGoal(selectedGoal.GoalID);
        //                goalForm.LoadGoals();

        //            }
        //        }
        //    }
        //    goalForm.Close();
        //}
    }
}
