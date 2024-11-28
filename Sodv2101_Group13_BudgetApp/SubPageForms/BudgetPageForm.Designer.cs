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
            ((System.ComponentModel.ISupportInitialize)dataGridViewBudgets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 81);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 4;
            label1.Text = "My Budgets";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(481, 81);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 5;
            label2.Text = "Budget Expenses: ";
            // 
            // lblExpenseList
            // 
            lblExpenseList.AutoSize = true;
            lblExpenseList.Location = new Point(605, 81);
            lblExpenseList.Name = "lblExpenseList";
            lblExpenseList.Size = new Size(0, 20);
            lblExpenseList.TabIndex = 6;
            // 
            // dataGridViewBudgets
            // 
            dataGridViewBudgets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBudgets.Location = new Point(25, 105);
            dataGridViewBudgets.Margin = new Padding(3, 4, 3, 4);
            dataGridViewBudgets.Name = "dataGridViewBudgets";
            dataGridViewBudgets.RowHeadersWidth = 51;
            dataGridViewBudgets.Size = new Size(378, 387);
            dataGridViewBudgets.TabIndex = 7;
            // 
            // dataGridViewExpenses
            // 
            dataGridViewExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExpenses.Location = new Point(481, 105);
            dataGridViewExpenses.Margin = new Padding(3, 4, 3, 4);
            dataGridViewExpenses.Name = "dataGridViewExpenses";
            dataGridViewExpenses.RowHeadersWidth = 51;
            dataGridViewExpenses.Size = new Size(419, 387);
            dataGridViewExpenses.TabIndex = 8;
            // 
            // btnNewBudget
            // 
            btnNewBudget.BackColor = Color.Plum;
            btnNewBudget.Location = new Point(25, 516);
            btnNewBudget.Margin = new Padding(3, 4, 3, 4);
            btnNewBudget.Name = "btnNewBudget";
            btnNewBudget.Size = new Size(94, 31);
            btnNewBudget.TabIndex = 9;
            btnNewBudget.Text = "New Budget";
            btnNewBudget.UseVisualStyleBackColor = false;
            btnNewBudget.Click += btnNewBudget_Click;
            // 
            // btnEditBudget
            // 
            btnEditBudget.BackColor = Color.Plum;
            btnEditBudget.Location = new Point(162, 516);
            btnEditBudget.Margin = new Padding(3, 4, 3, 4);
            btnEditBudget.Name = "btnEditBudget";
            btnEditBudget.Size = new Size(97, 31);
            btnEditBudget.TabIndex = 10;
            btnEditBudget.Text = "Edit Budget";
            btnEditBudget.UseVisualStyleBackColor = false;
            btnEditBudget.Click += btnEditBudget_Click;
            // 
            // btnDeleteBudget
            // 
            btnDeleteBudget.BackColor = Color.Plum;
            btnDeleteBudget.Location = new Point(299, 516);
            btnDeleteBudget.Margin = new Padding(3, 4, 3, 4);
            btnDeleteBudget.Name = "btnDeleteBudget";
            btnDeleteBudget.Size = new Size(104, 31);
            btnDeleteBudget.TabIndex = 11;
            btnDeleteBudget.Text = "Delete Budget";
            btnDeleteBudget.UseVisualStyleBackColor = false;
            btnDeleteBudget.Click += btnDeleteBudget_Click;
            // 
            // btnNewExpense
            // 
            btnNewExpense.BackColor = Color.Plum;
            btnNewExpense.Location = new Point(481, 516);
            btnNewExpense.Margin = new Padding(3, 4, 3, 4);
            btnNewExpense.Name = "btnNewExpense";
            btnNewExpense.Size = new Size(117, 31);
            btnNewExpense.TabIndex = 12;
            btnNewExpense.Text = "New Expense";
            btnNewExpense.UseVisualStyleBackColor = false;
            btnNewExpense.UseWaitCursor = true;
            btnNewExpense.Click += btnNewExpense_Click;
            // 
            // btnEditExpense
            // 
            btnEditExpense.BackColor = Color.Plum;
            btnEditExpense.Location = new Point(642, 516);
            btnEditExpense.Margin = new Padding(3, 4, 3, 4);
            btnEditExpense.Name = "btnEditExpense";
            btnEditExpense.Size = new Size(107, 31);
            btnEditExpense.TabIndex = 13;
            btnEditExpense.Text = "Edit Expense";
            btnEditExpense.UseVisualStyleBackColor = false;
            // 
            // btnDeleteExpense
            // 
            btnDeleteExpense.BackColor = Color.Plum;
            btnDeleteExpense.Location = new Point(787, 516);
            btnDeleteExpense.Margin = new Padding(3, 4, 3, 4);
            btnDeleteExpense.Name = "btnDeleteExpense";
            btnDeleteExpense.Size = new Size(113, 31);
            btnDeleteExpense.TabIndex = 14;
            btnDeleteExpense.Text = "Delete Expense";
            btnDeleteExpense.UseVisualStyleBackColor = false;
            // 
            // btnViewExpenses
            // 
            btnViewExpenses.BackColor = Color.Plum;
            btnViewExpenses.Location = new Point(281, 48);
            btnViewExpenses.Margin = new Padding(3, 4, 3, 4);
            btnViewExpenses.Name = "btnViewExpenses";
            btnViewExpenses.Size = new Size(122, 31);
            btnViewExpenses.TabIndex = 15;
            btnViewExpenses.Text = "View Expenses";
            btnViewExpenses.UseVisualStyleBackColor = false;
            btnViewExpenses.Click += btnViewExpenses_Click;
            // 
            // BudgetPageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(914, 576);
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
            Margin = new Padding(3, 4, 3, 4);
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
	}
}