using Microsoft.Data.SqlClient;
using Sodv2101_Group13_BudgetApp.InputForms;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.BudgetServices;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.FinancialGoalsService;
using Sodv2101_Group13_BudgetApp.SubPageForms;
using System.Drawing;

namespace Sodv2101_Group13_BudgetApp
{
    public partial class Form1 : Form
    {



        private BudgetService budgetService = new BudgetService();
        private FinancialGoalService goalService = new FinancialGoalService();
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
            Bitmap bitmap = new Bitmap(250, 150);

            foreach (Budget budget in budgets)
            {
                Label label = new Label();
                label.Location = new Point(20, 225 + locationYIncrease);
                label.Text = budget.Name;
                this.Controls.Add(label);


                // get current date
                DateTime date = DateTime.Now;
                // pass month to get only expenses for that month
                double expensesTotal = budget.GetExpenseTotalByMonth(date.Month);
                Label labelExpense = new Label();
                labelExpense.AutoSize = false;
                labelExpense.Width = 250;
                labelExpense.Location = new Point(370, 225 + locationYIncrease);
                labelExpense.Text = $"Max: {budget.Max}. Spent: {expensesTotal}. Remaining: {budget.Max - expensesTotal}";

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
                    Rectangle rectRemainder = new Rectangle(0 + spent, 0 + locationYIncrease, remaining, 20);
                    // rectangle here is simply width of spent
                    Rectangle rectSpent = new Rectangle(0, 0 + locationYIncrease, spent, 20);

                    // draw green
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 255, 0)))
                    {
                        g.FillRectangle(brush, rectRemainder);
                    }
                    // draw red
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 0, 0)))
                    {
                        g.FillRectangle(brush, rectSpent);
                    }
                }



                locationYIncrease += 30;
            }

            picBudgetGraphs.Image = bitmap;

        }

        private void toolStripMenuItemCreateBudget_Click(object sender, EventArgs e)
        {
            CreateBudget budgetForm = new CreateBudget();
            budgetForm.ShowDialog();
        }
        // ----------------------------------------------------------------------------------------------
        // GOAL SECTION
        private void toolStripDropDownButtonGoals_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemAddGoal_Click(object sender, EventArgs e)
        {
            AddGoalForm addGoal = new AddGoalForm();
            addGoal.ShowDialog();
        }




        private void toolStripDropDownButtonGoals_DoubleClick(object sender, EventArgs e)
        {
            GoalPageForm goalForm = new GoalPageForm();
            goalForm.ShowDialog();
        }

        private void toolStripMenuItemEditGoal_Click(object sender, EventArgs e)
        {
            GoalPageForm goalForm = new GoalPageForm();
            goalForm.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                FinancialGoal selectedGoal = goalForm.SelectedGoal;

                if (selectedGoal != null)
                {
                    EditGoalForm editGoal = new EditGoalForm();
                    editGoal.PopulateInput(selectedGoal, selectedGoal.GoalID);
                    DialogResult result = editGoal.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        goalForm.LoadGoals();
                    }
                }
                else
                {
                    Label errorLabel = new Label();
                    errorLabel.Text = "No goal was selected to edit.";
                }


            }

        }

        private void toolStripMenuItemDeleteGoal_Click(object sender, EventArgs e)
        {
            GoalPageForm goalForm = new GoalPageForm();
            goalForm.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                FinancialGoal selectedGoal = goalForm.SelectedGoal;

                if (selectedGoal != null)
                {
                    DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this goal?", "Confirm Deletion", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        goalService.DeleteFinancialGoal(selectedGoal.GoalID);
                        goalForm.LoadGoals();

                    }
                }
            }
            goalForm.Close();
        }

        //----------------EXPENSE SECTION ---------------------//
        private void newExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewExpense newExpense = new NewExpense();
            newExpense.ShowDialog();

        }
        private void editExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateExpense updateExpense = new UpdateExpense();
            updateExpense.ShowDialog();

        }
        //added but not too sure why if it in update form
        //private void deleteExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            
        //}
    }
}
