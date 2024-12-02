using System;
using Sodv2101_Group13_BudgetApp.InputForms;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.DBIncome;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.BudgetServices;

namespace Sodv2101_Group13_BudgetApp.SubPageForms
{
    public partial class IncomePageForm : Form
    {


        private List<Income> incomeList = new List<Income>();

        private IncomeService incomeService = new IncomeService();

        public IncomePageForm()
        {
            InitializeComponent();
            LoadIncomes();
        }


        private void LoadIncomes()
        {
            incomeList = incomeService.GetIncomeList();

            DataTable incomeTable = new DataTable();
            incomeTable.Columns.Add("Name", typeof(string));
            incomeTable.Columns.Add("Amount", typeof(double));
            incomeTable.Columns.Add("Type", typeof(string));
            foreach (var income in incomeList)
            {
                incomeTable.Rows.Add(income.Name, income.Amount, income.Type);
            }
            dataGridViewIncome.DataSource = incomeTable;

        }

        private void btnNewIncome_Click(object sender, EventArgs e)
        {
            CreateIncome createIncome = new CreateIncome();
            DialogResult result = createIncome.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadIncomes();
                lblIncomeOutput.Text = $"Income created successfully!";
            }
        }

        private void btnDeleteIncome_Click(object sender, EventArgs e)
        {
            if (dataGridViewIncome.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewIncome.SelectedRows[0];
                int incomeListIndex = dataGridViewIncome.CurrentCell.RowIndex;
                int incomeId = incomeList[incomeListIndex].IncomeId;

                bool budgetDeleted = incomeService.DeleteIncome(incomeId);
                if (budgetDeleted)
                {
                    LoadIncomes();
                    lblIncomeOutput.Text = "Income deleted successfully";
                }
            }
        }

        private void btnEditIncome_Click(object sender, EventArgs e)
        {
            if (dataGridViewIncome.SelectedRows.Count > 0 && dataGridViewIncome.SelectedRows.Count < 2)
            {
                DataGridViewRow selectedRow = dataGridViewIncome.SelectedRows[0];
                int incomeListIndex = dataGridViewIncome.CurrentCell.RowIndex;
                int incomeId = incomeList[incomeListIndex].IncomeId;

                string name = selectedRow.Cells["Name"].Value.ToString();
                double amount = Convert.ToDouble(selectedRow.Cells["Amount"].Value);
                string type = selectedRow.Cells["Type"].Value.ToString();

                UpdateIncome updateIncome = new UpdateIncome();

                updateIncome.PopulateInputs(name, amount, type, incomeId);
                DialogResult result = updateIncome.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadIncomes();
                    lblIncomeOutput.Text = "Income updated successfully!";
                }

            }
            else
            {
                lblIncomeOutput.Text = "Please select an Income to update";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridViewIncome.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewIncome.SelectedRows[0];
                int incomeListIndex = dataGridViewIncome.CurrentCell.RowIndex;
                string type = selectedRow.Cells["Type"].Value.ToString();

                if (type == "Hourly")
                {
                    var incomeHourly = incomeList[incomeListIndex] as IncomeHourly;

                    DataTable hoursTable = new DataTable();
                    hoursTable.Columns.Add("Hours", typeof(double));
                    hoursTable.Columns.Add("Date", typeof(string));
                    foreach (var hours in incomeHourly.HoursList)
                    {
                        hoursTable.Rows.Add(hours.Hours, hours.Date.ToString("yyyy/MM/dd"));
                    }
                    dataGridViewHours.DataSource = hoursTable;

                }
                else
                {
                    lblIncomeOutput.Text = "Please select an hourly income to view hours!";
                }
            }
            else
            {
                lblIncomeOutput.Text = "Please select an hourly income to view hours!";
            }
            


        }
    }
}
