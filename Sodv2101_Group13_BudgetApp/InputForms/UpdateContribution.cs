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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sodv2101_Group13_BudgetApp.InputForms
{
    public partial class UpdateContribution : Form
    {
        private ContributionService contributionService = new ContributionService();
        private List<Contribution> contributions;

        private FinancialGoalService financialGoalService = new FinancialGoalService();
        private List<FinancialGoal> financialGoals = new List<FinancialGoal>();



        // save goal ID  and contribution ID so that we can reference correct goal when updating contribution
        public int GoalId { get; set; }
        // GoalID is public so that we can pull the value after a goal has been chosen for the update
        private int ContributionId { get; set; }
        public UpdateContribution(Contribution contribution)
        {

            InitializeComponent();
            // LoadContributions();

            LoadFinancialGoalsComboBox();

            LoadCurrentContributionData(contribution);

        }

        private void LoadFinancialGoalsComboBox()
        {
            financialGoals = financialGoalService.GetFinancialGoalList();

            comboBoxUpdateContribution.DataSource = financialGoals;
            comboBoxUpdateContribution.DisplayMember = "Name";
            comboBoxUpdateContribution.ValueMember = "GoalID";
        }

        private void LoadCurrentContributionData(Contribution contribution)
        {
            FinancialGoal goal = financialGoalService.GetFinancialGoalById(contribution.GoalID);

            GoalId = goal.GoalID;
            ContributionId = contribution.ContributionID;

            comboBoxUpdateContribution.SelectedIndex = comboBoxUpdateContribution.FindStringExact(goal.Name);
            numUpdateContributionAmount.Value = (decimal)contribution.Amount;
            txtBoxUpdateContributionDescription.Text = contribution.Description;
            dateTimePickerUpdateContribution.Value = contribution.Date;


        }
        private void lblUpdateContributionError_TextChanged(object sender, EventArgs e)
        {
            lblUpdateOutput.ForeColor = Color.Red;
        }

        private void btnUpdateContributionSave_Click(object sender, EventArgs e)
        {
            int selectedGoalIndex = comboBoxUpdateContribution.SelectedIndex;
            if (selectedGoalIndex >= 0)
            {
                if(numUpdateContributionAmount.Value > 0)
                {
                    // get goalID of selected goal 
                    int goalId = financialGoals[selectedGoalIndex].GoalID;

                    GoalId = goalId;

                    double amount = Convert.ToDouble(numUpdateContributionAmount.Value);
                    string description = txtBoxUpdateContributionDescription.Text;
                    DateTime date = dateTimePickerUpdateContribution.Value.Date;

                    Contribution contribution = new Contribution(goalId, amount, description, date);

                    // pass the object AND ID to the edit budget method of budget service
                    // proceed to budget service class
                    contributionService.UpdateContribution(contribution, ContributionId);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblUpdateOutput.Text = "Please input a value greater than 0";
                }
                
            }
            else
            {
                lblUpdateOutput.Text = "Please select a goal category!";   
            }
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
