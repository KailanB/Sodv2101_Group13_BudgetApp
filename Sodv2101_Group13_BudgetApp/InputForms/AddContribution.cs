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

namespace Sodv2101_Group13_BudgetApp.InputForms
{
    public partial class AddContribution : Form
    {
        private ContributionService contributionService = new ContributionService();
        private FinancialGoalService financialGoalService = new FinancialGoalService();
        private FinancialGoal goal;

        private List<FinancialGoal> financialGoals = new List<FinancialGoal>();
        
        // added paramterless constructor so that we can use this Form outside of the GoalPageForm.
        // instead of passing a value into the constructor simply use financialGoalService to pull goal list and populate form combo box
        public AddContribution()
        {
			InitializeComponent();

            //populates combo box with financial goal options
            LoadFinancialGoalsComboBox();
		}
        public AddContribution(List<FinancialGoal> goals)
        {
            InitializeComponent();
           
            comboBoxAddContribution.DataSource = goals;
            comboBoxAddContribution.DisplayMember = "Name";
            comboBoxAddContribution.ValueMember = "GoalID";
        }


        private void LoadFinancialGoalsComboBox()
        {
			financialGoals = financialGoalService.GetFinancialGoalList();

			comboBoxAddContribution.DataSource = financialGoals;
			comboBoxAddContribution.DisplayMember = "Name";
			comboBoxAddContribution.ValueMember = "GoalID";
		}
        private void btnAddContributionSave_Click(object sender, EventArgs e)
        {

            if (comboBoxAddContribution.SelectedItem is FinancialGoal selectedGoal)
            {
                double amount;
                if (double.TryParse(numAddContributionAmount.Text, out amount) && amount > 0)
                {
                    // Create a new Contribution object
                    Contribution newContribution = new Contribution
                    {
                        GoalID = selectedGoal.GoalID,
                        Amount = amount,
                        Description = txtBoxAddContributionDescription.Text,
                        Date = dateTimePickerAddContribution.Value
                    };

                    // Add the contribution via your service
                    contributionService.AddContribution(newContribution);

                    // Notify the user and close the form
                    MessageBox.Show("Contribution added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a goal.", "No Goal Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
