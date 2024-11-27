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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetPageForm));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolBtnAddExpense = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            btnToolStripBudget = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnToolStripIncome = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnToolStripGoals = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnToolStripReports = new ToolStripButton();
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
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBudgets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator2, btnToolStripBudget, toolStripSeparator1, btnToolStripIncome, toolStripSeparator3, btnToolStripGoals, toolStripSeparator4, btnToolStripReports });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.BackColor = Color.Plum;
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { toolBtnAddExpense });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(85, 24);
            toolStripDropDownButton1.Text = "Add New";
            // 
            // toolBtnAddExpense
            // 
            toolBtnAddExpense.Name = "toolBtnAddExpense";
            toolBtnAddExpense.Size = new Size(178, 26);
            toolBtnAddExpense.Text = "Add Expense";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnToolStripBudget
            // 
            btnToolStripBudget.AutoSize = false;
            btnToolStripBudget.BackColor = Color.Plum;
            btnToolStripBudget.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnToolStripBudget.ImageTransparentColor = Color.Magenta;
            btnToolStripBudget.Name = "btnToolStripBudget";
            btnToolStripBudget.Size = new Size(100, 22);
            btnToolStripBudget.Text = "Budget";
            btnToolStripBudget.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnToolStripIncome
            // 
            btnToolStripIncome.AutoSize = false;
            btnToolStripIncome.BackColor = Color.Plum;
            btnToolStripIncome.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnToolStripIncome.ImageTransparentColor = Color.Magenta;
            btnToolStripIncome.Name = "btnToolStripIncome";
            btnToolStripIncome.Size = new Size(100, 22);
            btnToolStripIncome.Text = "Income";
            btnToolStripIncome.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // btnToolStripGoals
            // 
            btnToolStripGoals.AutoSize = false;
            btnToolStripGoals.BackColor = Color.Plum;
            btnToolStripGoals.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnToolStripGoals.Image = (Image)resources.GetObject("btnToolStripGoals.Image");
            btnToolStripGoals.ImageTransparentColor = Color.Magenta;
            btnToolStripGoals.Name = "btnToolStripGoals";
            btnToolStripGoals.Size = new Size(100, 22);
            btnToolStripGoals.Text = "Goals";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // btnToolStripReports
            // 
            btnToolStripReports.AutoSize = false;
            btnToolStripReports.BackColor = Color.Plum;
            btnToolStripReports.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnToolStripReports.Image = (Image)resources.GetObject("btnToolStripReports.Image");
            btnToolStripReports.ImageTransparentColor = Color.Magenta;
            btnToolStripReports.Name = "btnToolStripReports";
            btnToolStripReports.Size = new Size(100, 22);
            btnToolStripReports.Text = "Reports";
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
            btnViewExpenses.Location = new Point(281, 67);
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
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BudgetPageForm";
            Text = "BudgetPageForm";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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