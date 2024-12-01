using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sodv2101_Group13_BudgetApp.SubPageForms
{
    public partial class IncomePage : Form
    {
        private List<Income> incomes = new List<Income>();
        private ListBox lstIncomes;
        private Button btnNewIncome, btnEditIncome, btnDeleteIncome, btnSave, btnCancel;
        private Label lblName, lblAmount, lblTimePeriod, lblIncomeType;
        private TextBox txtName, txtAmount, txtTimePeriod;
        private ComboBox cmbIncomeType;

        // Constructor for the form
        public IncomePage()
        {
            InitializeComponent();  
            SetupUI();  
        }


        private void SetupUI()
        {
            // Initialize and set properties for the controls
            lstIncomes = new ListBox
            {
                Location = new System.Drawing.Point(40, 40),
                Size = new System.Drawing.Size(500, 184)
            };
            Controls.Add(lstIncomes);

            // New Income button
            btnNewIncome = new Button
            {
                Text = "New Income",
                Location = new System.Drawing.Point(40, 240),
                Size = new System.Drawing.Size(100, 30),
                BackColor = System.Drawing.Color.Magenta
            };
            btnNewIncome.Click += ShowIncomeFormForNew;
            Controls.Add(btnNewIncome);

            // Edit Income button
            btnEditIncome = new Button
            {
                Text = "Edit",
                Location = new System.Drawing.Point(200, 240),
                Size = new System.Drawing.Size(100, 30),
                BackColor = System.Drawing.Color.Magenta
            };
            btnEditIncome.Click += ShowIncomeFormForEdit;
            Controls.Add(btnEditIncome);

            // Delete Income button
            btnDeleteIncome = new Button
            {
                Text = "Delete",
                Location = new System.Drawing.Point(360, 240),
                Size = new System.Drawing.Size(100, 30),
                BackColor = System.Drawing.Color.Magenta
            };
            btnDeleteIncome.Click += DeleteSelectedIncome;
            Controls.Add(btnDeleteIncome);

            // Input fields for New/Edit Income (Initially hidden)
            lblName = new Label { Text = "Name:", Location = new Point(40, 280), Visible = false };
            txtName = new TextBox { Location = new Point(100, 280), Size = new Size(200, 20), Visible = false };

            lblAmount = new Label { Text = "Amount:", Location = new Point(40, 320), Visible = false };
            txtAmount = new TextBox { Location = new Point(100, 320), Size = new Size(200, 20), Visible = false };

            lblTimePeriod = new Label { Text = "Time Period:", Location = new Point(40, 360), Visible = false };
            txtTimePeriod = new TextBox { Location = new Point(100, 360), Size = new Size(200, 20), Visible = false };

            lblIncomeType = new Label { Text = "Income Type:", Location = new Point(40, 400), Visible = false };
            cmbIncomeType = new ComboBox
            {
                Location = new Point(100, 400),
                Size = new Size(200, 20),
                Visible = false
            };
            cmbIncomeType.Items.AddRange(new[] { "Salary", "Hourly", "Yearly" });

            btnSave = new Button
            {
                Text = "Save",
                Location = new Point(40, 440),
                Size = new Size(100, 30),
                BackColor = Color.Magenta,
                Visible = false
            };
            btnSave.Click += SaveIncome;

            btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(150, 440),
                Size = new Size(100, 30),
                BackColor = Color.Magenta,
                Visible = false
            };
            btnCancel.Click += HideIncomeForm;

            // Add the controls to the form
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblAmount);
            Controls.Add(txtAmount);
            Controls.Add(lblTimePeriod);
            Controls.Add(txtTimePeriod);
            Controls.Add(lblIncomeType);
            Controls.Add(cmbIncomeType);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
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
                txtTimePeriod.Text = selectedIncome.TimePeriod;
                cmbIncomeType.SelectedItem = selectedIncome.IncomeType;
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
                incomes.Add(new Income(name, amount, timePeriod, incomeType));
                MessageBox.Show("Income added successfully!");
            }
            else if (btnSave.Tag.ToString() == "Edit" && btnSave.Tag is Income incomeToEdit)
            {
                incomeToEdit.Name = name;
                incomeToEdit.Amount = amount;
                incomeToEdit.TimePeriod = timePeriod;
                incomeToEdit.IncomeType = incomeType;
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
