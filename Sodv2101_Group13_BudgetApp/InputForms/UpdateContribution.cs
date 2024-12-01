using Sodv2101_Group13_BudgetApp.RepositoryDBContext.ContributionServices;
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
    public partial class UpdateContribution : Form
    {
        private ContributionService contributionService = new ContributionService();
        private List<Contribution> contributions;
        public UpdateContribution(FinancialGoal goal)
        {
            InitializeComponent();
            LoadContributions();
        }
        private void LoadContributions()
        {
            try
            {
                contributions = contributionService.GetContributionList(1); // 1 is for USER ID
                if (contributions.Count == 0)
                {
                    MessageBox.Show("No Contributions to Remove.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }
                comboBoxUpdateContribution.DataSource = contributions;
                comboBoxUpdateContribution.DisplayMember = "Description";
                comboBoxUpdateContribution.ValueMember = "ContributionID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contributions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void comboBoxUpdateContribution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUpdateContribution.SelectedItem is Contribution selectedContribution)
            {
                numUpdateContributionAmount.Value = (decimal)selectedContribution.Amount;
                numUpdateContributionAmount.Text = selectedContribution.Description;
                dateTimePickerUpdateContribution.Value = DateTime.Now;
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

            if (comboBoxUpdateContribution.SelectedItem is Contribution selectedContribution)
            {
                var confirmResult = MessageBox.Show($"Are you sure you want to update contribution: {selectedContribution.Description}?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    
                    Contribution updateContribution = new Contribution
                    {
                        ContributionID = selectedContribution.ContributionID,
                        GoalID = selectedContribution.GoalID,
                        Amount = Convert.ToDouble(numUpdateContributionAmount.Value),
                        Description = selectedContribution.Description,
                        Date = DateTime.Now,
                    };

                    bool isUpdated = contributionService.UpdateContribution(updateContribution, selectedContribution.ContributionID);
                    if (isUpdated)
                    {
                        MessageBox.Show("Contribution update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                        LoadContributions();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Update the contribution.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Please select a contribution to Update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Close();
        }
    }
}
