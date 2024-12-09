using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sodv2101_Group13_BudgetApp;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.FinancialGoalsService;

namespace Sodv2101_Group13_BudgetApp.InputForms
{
    public partial class CreateGoalForm : Form
    {
        internal FinancialGoal NewGoal = new FinancialGoal();
        public bool CreatedGoal;
        public CreateGoalForm()
        {
            InitializeComponent();
        }

        private void btnSaveGoal_Click(object sender, EventArgs e)
        {
            string name = txtBoxAddGoalName.Text;
            if (string.IsNullOrEmpty(name))
            {
                lblErrorOutput.Text = "Goal Name is required";
                return;
            }
            if (!double.TryParse(numericUpDownAddGoalAmount.Text, out double amount) || amount <= 0)
            {
                lblErrorOutput.Text = "Please Enter a valid amount";
                return;
            }
            string description = txtBoxAddGoalDescription.Text;
            DateTime deadline = dateTimePickerAddGoalDeadline.Value;

            NewGoal = new FinancialGoal
            {
                Name = name,
                MaxAmount = amount,
                Description = description,
                Deadline = deadline
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void lblAddGoalErrorMessage_TextChanged(object sender, EventArgs e)
        {
            lblErrorOutput.ForeColor = Color.Red;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
