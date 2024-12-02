using Sodv2101_Group13_BudgetApp.RepositoryDBContext.DBIncome;
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
    public partial class UpdateIncome : Form
    {

        private List<IncomeType> incomeTypes = new List<IncomeType>();
        private IncomeService incomeService = new IncomeService();

        private int incomeId = 0;

        public UpdateIncome()
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



        public void PopulateInputs(string name, double amount, string type, int id)
        {
            txtIncomeName.Text = name;
            numAmount.Value = (decimal)amount;
            comboIncomeType.SelectedIndex = comboIncomeType.FindStringExact(type);

            incomeId = id;
        }

        private void btnEditIncome_Click(object sender, EventArgs e)
        {



            bool createdIncome = false;
            if (numAmount.Value > 0 && txtIncomeName.Text != "" && comboIncomeType.SelectedValue != null)
            {
                int incomeTypeId = (int)comboIncomeType.SelectedValue;

                string name = txtIncomeName.Text;
                double amount = (double)numAmount.Value;

                // if id = 1 type is salary
                if (incomeTypeId == 1)
                {
                    IncomeSalary incomeSalary = new IncomeSalary(name, amount, incomeTypeId);
                    createdIncome = incomeService.EditIncome(incomeSalary, incomeId);
                    if (createdIncome)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        lblIncomeOutput.Text = "Error editing income!";
                        this.DialogResult = DialogResult.Cancel;
                    }

                }
                else
                {
                    IncomeHourly incomeHourly = new IncomeHourly(name, amount, incomeTypeId);
                    createdIncome = incomeService.EditIncome(incomeHourly, incomeId);
                    if (createdIncome)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        lblIncomeOutput.Text = "Error editing income!";
                        this.DialogResult = DialogResult.Cancel;
                    }

                }

            }
            else
            {
                lblIncomeOutput.Text = "Please select income name, value, and type";
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
