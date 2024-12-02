namespace Sodv2101_Group13_BudgetApp.SubPageForms
{
	partial class BudgetPageForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblExpenseList = new Label();
            dataGridViewBudgets = new DataGridView();
            dataGridViewExpenses = new DataGridView();
            btnNewBudget = new Button();
            btnEditBudget = new Button();
            btnDeleteBudget = new Button();
            btnNewExpense = new Button();
            btnEditExpense = new Button();
            btnDeleteExpense = new Button();
            btnViewExpenses = new Button();
            lblBudgetOutput = new Label();
            lblExpenseOutput = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBudgets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 61);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 4;
            label1.Text = "My Budgets";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 61);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 5;
            label2.Text = "Budget Expenses: ";
            // 
            // lblExpenseList
            // 
            lblExpenseList.AutoSize = true;
            lblExpenseList.Location = new Point(529, 61);
            lblExpenseList.Name = "lblExpenseList";
            lblExpenseList.Size = new Size(0, 15);
            lblExpenseList.TabIndex = 6;
            // 
            // dataGridViewBudgets
            // 
            dataGridViewBudgets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBudgets.Location = new Point(22, 79);
            dataGridViewBudgets.Name = "dataGridViewBudgets";
            dataGridViewBudgets.RowHeadersWidth = 51;
            dataGridViewBudgets.Size = new Size(341, 290);
            dataGridViewBudgets.TabIndex = 7;
            // 
            // dataGridViewExpenses
            // 
            dataGridViewExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExpenses.Location = new Point(421, 79);
            dataGridViewExpenses.Name = "dataGridViewExpenses";
            dataGridViewExpenses.RowHeadersWidth = 51;
            dataGridViewExpenses.Size = new Size(462, 290);
            dataGridViewExpenses.TabIndex = 8;
            // 
            // btnNewBudget
            // 
            btnNewBudget.BackColor = Color.Plum;
            btnNewBudget.Location = new Point(22, 375);
            btnNewBudget.Name = "btnNewBudget";
            btnNewBudget.Size = new Size(82, 23);
            btnNewBudget.TabIndex = 9;
            btnNewBudget.Text = "New Budget";
            btnNewBudget.UseVisualStyleBackColor = false;
            btnNewBudget.Click += btnNewBudget_Click;
            // 
            // btnEditBudget
            // 
            btnEditBudget.BackColor = Color.Plum;
            btnEditBudget.Location = new Point(110, 375);
            btnEditBudget.Name = "btnEditBudget";
            btnEditBudget.Size = new Size(85, 23);
            btnEditBudget.TabIndex = 10;
            btnEditBudget.Text = "Edit Budget";
            btnEditBudget.UseVisualStyleBackColor = false;
            btnEditBudget.Click += btnEditBudget_Click;
            // 
            // btnDeleteBudget
            // 
            btnDeleteBudget.BackColor = Color.Plum;
            btnDeleteBudget.Location = new Point(201, 375);
            btnDeleteBudget.Name = "btnDeleteBudget";
            btnDeleteBudget.Size = new Size(91, 23);
            btnDeleteBudget.TabIndex = 11;
            btnDeleteBudget.Text = "Delete Budget";
            btnDeleteBudget.UseVisualStyleBackColor = false;
            btnDeleteBudget.Click += btnDeleteBudget_Click;
            // 
            // btnNewExpense
            // 
            btnNewExpense.BackColor = Color.Plum;
            btnNewExpense.Location = new Point(421, 375);
            btnNewExpense.Name = "btnNewExpense";
            btnNewExpense.Size = new Size(102, 23);
            btnNewExpense.TabIndex = 12;
            btnNewExpense.Text = "New Expense";
            btnNewExpense.UseVisualStyleBackColor = false;
            btnNewExpense.UseWaitCursor = true;
            btnNewExpense.Click += btnNewExpense_Click;
            // 
            // btnEditExpense
            // 
            btnEditExpense.BackColor = Color.Plum;
            btnEditExpense.Location = new Point(529, 375);
            btnEditExpense.Name = "btnEditExpense";
            btnEditExpense.Size = new Size(94, 23);
            btnEditExpense.TabIndex = 13;
            btnEditExpense.Text = "Edit Expense";
            btnEditExpense.UseVisualStyleBackColor = false;
            btnEditExpense.Click += btnEditExpense_Click;
            // 
            // btnDeleteExpense
            // 
            btnDeleteExpense.BackColor = Color.Plum;
            btnDeleteExpense.Location = new Point(629, 375);
            btnDeleteExpense.Name = "btnDeleteExpense";
            btnDeleteExpense.Size = new Size(99, 23);
            btnDeleteExpense.TabIndex = 14;
            btnDeleteExpense.Text = "Delete Expense";
            btnDeleteExpense.UseVisualStyleBackColor = false;
            btnDeleteExpense.Click += btnDeleteExpense_Click;
            // 
            // btnViewExpenses
            // 
            btnViewExpenses.BackColor = Color.Plum;
            btnViewExpenses.Location = new Point(256, 50);
            btnViewExpenses.Name = "btnViewExpenses";
            btnViewExpenses.Size = new Size(107, 23);
            btnViewExpenses.TabIndex = 15;
            btnViewExpenses.Text = "View Expenses";
            btnViewExpenses.UseVisualStyleBackColor = false;
            btnViewExpenses.Click += btnViewExpenses_Click;
            // 
            // lblBudgetOutput
            // 
            lblBudgetOutput.AutoSize = true;
            lblBudgetOutput.Location = new Point(22, 413);
            lblBudgetOutput.Name = "lblBudgetOutput";
            lblBudgetOutput.Size = new Size(0, 15);
            lblBudgetOutput.TabIndex = 16;
            // 
            // lblExpenseOutput
            // 
            lblExpenseOutput.AutoSize = true;
            lblExpenseOutput.Location = new Point(421, 413);
            lblExpenseOutput.Name = "lblExpenseOutput";
            lblExpenseOutput.Size = new Size(0, 15);
            lblExpenseOutput.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 18;
            label3.Text = "My Budgets";
            // 
            // BudgetPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(927, 452);
            Controls.Add(label3);
            Controls.Add(lblExpenseOutput);
            Controls.Add(lblBudgetOutput);
            Controls.Add(btnViewExpenses);
            Controls.Add(btnDeleteExpense);
            Controls.Add(btnEditExpense);
            Controls.Add(btnNewExpense);
            Controls.Add(btnDeleteBudget);
            Controls.Add(btnEditBudget);
            Controls.Add(btnNewBudget);
            Controls.Add(dataGridViewExpenses);
            Controls.Add(dataGridViewBudgets);
            Controls.Add(lblExpenseList);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BudgetPageForm";
            Text = "BudgetPageForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBudgets).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
		private ToolStripDropDownButton toolStripDropDownButton1;
		private ToolStripMenuItem toolBtnAddExpense;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripButton btnToolStripBudget;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton btnToolStripIncome;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripButton btnToolStripGoals;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripButton btnToolStripReports;
		private Label label1;
		private Label label2;
		private Label lblExpenseList;
		private DataGridView dataGridViewBudgets;
		private DataGridView dataGridViewExpenses;
		private Button btnNewBudget;
		private Button btnEditBudget;
		private Button btnDeleteBudget;
		private Button btnNewExpense;
		private Button btnEditExpense;
		private Button btnDeleteExpense;
		private Button btnViewExpenses;
        private Label lblBudgetOutput;
        private Label lblExpenseOutput;
        private Label label3;
    }
}