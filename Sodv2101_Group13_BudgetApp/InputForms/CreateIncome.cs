using System;
using System.Collections.Generic;
using Sodv2101_Group13_BudgetApp.InputForms;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.DBIncome;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.DBIncome;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.BudgetServices;
using Microsoft.Identity.Client;

namespace Sodv2101_Group13_BudgetApp.InputForms
{
    public partial class CreateIncome : Form
    {

        private List<IncomeType> incomeTypes = new List<IncomeType>();
        private IncomeService incomeService = new IncomeService();

        public bool CreatedIncome = false;
        public CreateIncome()
        {
            InitializeComponent();
            LoadIncomeTypes();
        }


        private void LoadIncomeTypes()
        {
            incomeTypes = incomeService.GetIncomeTypeList();
            if (incomeTypes != null && incomeTypes.Count > 0)
            {
                comboIncomeType.DataSource = incomeTypes;
                comboIncomeType.DisplayMember = "Type";
                comboIncomeType.ValueMember = "TypeId";
            }
            else
            {
                MessageBox.Show("No income types found.");
            }

        }
        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            bool createdIncome = false;
            if (numIncomeAmount.Value > 0 && txtIncomeName.Text != "" && comboIncomeType.SelectedValue != null)
            {
                int incomeTypeId = (int)comboIncomeType.SelectedValue;

                string name = txtIncomeName.Text;
                double amount = (double)numIncomeAmount.Value;

                // if id = 1 type is salary
                if (incomeTypeId == 1)
                {
                    IncomeSalary incomeSalary = new IncomeSalary(name, amount, incomeTypeId);
                    createdIncome = incomeService.CreateIncome(incomeSalary);
                    if (createdIncome)
                    {
                        CreatedIncome = true;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error creating income!");
                        this.DialogResult = DialogResult.Cancel;
                    }

                }
                else
                {
                    IncomeHourly incomeHourly = new IncomeHourly(name, amount, incomeTypeId);
                    createdIncome = incomeService.CreateIncome(incomeHourly);
                    if (createdIncome)
                    {
                        CreatedIncome = true;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error creating income!");
                        this.DialogResult = DialogResult.Cancel;
                    }

                }

            }
            else
            {
                lblIncomeOutput.Text = "Please select income name, value and type";
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtIncomeName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
