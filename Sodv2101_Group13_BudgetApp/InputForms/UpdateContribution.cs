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


        // this function pulls all contributions for userId 1 and then tries to load it into the edit form. 
        // In this case we simply need to prepopulate the form with values from the selected contribution
        //private void LoadContributions()
        //{

        //    try
        //    {
        //        contributions = contributionService.GetContributionList(1); // 1 is for USER ID
        //        if (contributions.Count == 0)
        //        {
        //            MessageBox.Show("No Contributions to Remove.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            this.Close();
        //            return;
        //        }
        //        comboBoxUpdateContribution.DataSource = contributions;
        //        comboBoxUpdateContribution.DisplayMember = "Description";
        //        comboBoxUpdateContribution.ValueMember = "ContributionID";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error loading contributions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}
        private void comboBoxUpdateContribution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUpdateContribution.SelectedItem is Contribution selectedContribution)
            {
                numUpdateContributionAmount.Value = (decimal)selectedContribution.Amount;
                numUpdateContributionAmount.Text = selectedContribution.Description;
                dateTimePickerUpdateContribution.Value = selectedContribution.Date;
            }
            else
            {
                lblUpdateContributionError.Text = "Select a Contribution to Update";
            }
        }

        private void lblUpdateContributionError_TextChanged(object sender, EventArgs e)
        {
            lblUpdateContributionError.ForeColor = Color.Red;
        }

        private void btnUpdateContributionSave_Click(object sender, EventArgs e)
        {

            int selectedGoalIndex = comboBoxUpdateContribution.SelectedIndex;
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

            //if (comboBoxUpdateContribution.SelectedItem is Contribution selectedContribution)
            //{
            //    var confirmResult = MessageBox.Show($"Are you sure you want to update contribution: {selectedContribution.Description}?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (confirmResult == DialogResult.Yes)
            //    {

            //        Contribution updateContribution = new Contribution
            //        {
            //            ContributionID = selectedContribution.ContributionID,
            //            GoalID = selectedContribution.GoalID,
            //            Amount = Convert.ToDouble(numUpdateContributionAmount.Value),
            //            Description = selectedContribution.Description,
            //            Date = DateTime.Now,
            //        };

            //        bool isUpdated = contributionService.UpdateContribution(updateContribution, selectedContribution.ContributionID);
            //        if (isUpdated)
            //        {
            //            MessageBox.Show("Contribution update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
            //            // LoadContributions();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Failed to Update the contribution.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select a contribution to Update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
