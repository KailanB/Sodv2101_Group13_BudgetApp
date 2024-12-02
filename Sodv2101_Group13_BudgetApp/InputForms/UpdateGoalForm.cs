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

namespace Sodv2101_Group13_BudgetApp.InputForms
{
    public partial class UpdateGoalForm : Form
    {
        private FinancialGoalService goalService = new FinancialGoalService();
        private int goalID;
        public UpdateGoalForm()
        {
            InitializeComponent();
        }

        public void PopulateInput(FinancialGoal goal, int id)
        {
            txtBoxEditGoalName.Text = goal.Name;
            numEditGoalAmount.Value = (decimal)goal.MaxAmount;
            txtBoxEditGoalDescription.Text = goal.Description;
            dateTimePickerEditGoalDeadline.Value = (DateTime)goal.Deadline;

            goalID = id;
        }

        private void btnEditGoalSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxEditGoalName.Text) || numEditGoalAmount.Value <= 0)
            {
                MessageBox.Show("Please provide valid values for the goal.");
                return;
            }
            string name = txtBoxEditGoalName.Text;
            decimal amount = numEditGoalAmount.Value;
            string description = txtBoxEditGoalDescription.Text;
            DateTime deadline = dateTimePickerEditGoalDeadline.Value;

            FinancialGoal goal = new FinancialGoal(name, Convert.ToDouble(amount), description, deadline);
            goalService.EditFinancialGoal(goal, goalID);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
