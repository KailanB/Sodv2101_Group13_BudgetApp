using Microsoft.Identity.Client;
using Sodv2101_Group13_BudgetApp.InputForms;
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


namespace Sodv2101_Group13_BudgetApp.SubPageForms
{
    public partial class IncomePage : Form
    {

        private List<Income> incomes = new List<Income>();
        public IncomePage()
        {
            InitializeComponent();
            SetupUI();

        }


        private void ShowIncomeFormForNew(object sender, EventArgs e)
        {
            ClearIncomeForm();
            btnSave.Tag = "New"; // Mark as New Income
            ToggleIncomeForm(true); // Show the input form
        }

        private void ShowIncomeFormForEdit(object sender, EventArgs e)
        {
            if (lstIncomes.SelectedItem is Income selectedIncome)
            {
                txtName.Text = selectedIncome.Name;
                txtAmount.Text = selectedIncome.Amount.ToString();
                //txtTimePeriod.Text = selectedIncome.TimePeriod;
                //cmbIncomeType.SelectedItem = selectedIncome.IncomeType;
                btnSave.Tag = "Edit";
                btnSave.Tag = selectedIncome;
                ToggleIncomeForm(true); // Show the input form for editing
            }
            else
            {
                MessageBox.Show("Please select an income to edit.");
            }
        }

        private void DeleteSelectedIncome(object sender, EventArgs e)
        {
            if (lstIncomes.SelectedItem is Income selectedIncome)
            {
                incomes.Remove(selectedIncome);
                RefreshIncomeList();
                MessageBox.Show("Income deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select an income to delete.");
            }
        }

        private void SaveIncome(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var amount = double.Parse(txtAmount.Text);
            var timePeriod = txtTimePeriod.Text;
            var incomeType = cmbIncomeType.SelectedItem.ToString();

            if (btnSave.Tag.ToString() == "New")
            {
                //incomes.Add(new Income(name, amount, timePeriod, incomeType));
                MessageBox.Show("Income added successfully!");
            }
            else if (btnSave.Tag.ToString() == "Edit" && btnSave.Tag is Income incomeToEdit)
            {
                incomeToEdit.Name = name;
                incomeToEdit.Amount = amount;
                //incomeToEdit.TimePeriod = timePeriod;
                //incomeToEdit.IncomeType = incomeType;
                MessageBox.Show("Income updated successfully!");
            }

            RefreshIncomeList();
            ToggleIncomeForm(false); // Hide the input form after saving
        }


        private void RefreshIncomeList()
        {
            lstIncomes.DataSource = null;
            lstIncomes.DataSource = incomes;
        }

        private void ClearIncomeForm()
        {
            txtName.Clear();
            txtAmount.Clear();
            txtTimePeriod.Clear();
            cmbIncomeType.SelectedIndex = -1;
        }

        private void ToggleIncomeForm(bool isVisible)
        {
            lblName.Visible = isVisible;
            txtName.Visible = isVisible;
            lblAmount.Visible = isVisible;
            txtAmount.Visible = isVisible;
            lblTimePeriod.Visible = isVisible;
            txtTimePeriod.Visible = isVisible;
            lblIncomeType.Visible = isVisible;
            cmbIncomeType.Visible = isVisible;
            btnSave.Visible = isVisible;
            btnCancel.Visible = isVisible;
        }

        private void HideIncomeForm(object sender, EventArgs e)
        {
            ToggleIncomeForm(false);
        }
    }

}