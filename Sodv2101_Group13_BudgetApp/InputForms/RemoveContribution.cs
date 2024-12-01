using Sodv2101_Group13_BudgetApp.RepositoryDBContext.ContributionServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Sodv2101_Group13_BudgetApp.InputForms
{
    public partial class RemoveContribution : Form
    {
        private ContributionService contributionService = new ContributionService();
        private List<Contribution> contributions;
        public RemoveContribution(FinancialGoal goal)
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
                comboBoxRemoveContribution.DataSource = contributions;
                comboBoxRemoveContribution.DisplayMember = "Description";
                comboBoxRemoveContribution.ValueMember = "ContributionID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contributions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRemoveContributionSave_Click(object sender, EventArgs e)
        {
            if (comboBoxRemoveContribution.SelectedItem is Contribution selectedContribution)
            {
                var confirmResult = MessageBox.Show($"Are you sure you want to remove contribution: {selectedContribution.Description}?", "Removal Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    bool isRemoved = contributionService.RemoveContribution(selectedContribution.ContributionID);

                    if (isRemoved)
                    {
                        MessageBox.Show("Contribution removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        contributions.Remove(selectedContribution);
                        LoadContributions();
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove the contribution.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Please select a contribution to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void comboBoxRemoveContribution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxRemoveContribution.SelectedItem is Contribution selectedContribution)
            {
                numRemoveContributionAmount.Value = (decimal)selectedContribution.Amount;
                txtBoxRemoveContributionDescription.Text = selectedContribution.Description;
                dateTimePickerRemoveContribution.Value = (DateTime)selectedContribution.Date;
            }
            else
            {
                numRemoveContributionAmount.Value = 0;
                txtBoxRemoveContributionDescription.Text = string.Empty;
                dateTimePickerRemoveContribution.Value = DateTime.Now;
            }
        }
    }
}
