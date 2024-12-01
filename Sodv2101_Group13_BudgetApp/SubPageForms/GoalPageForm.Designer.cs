namespace Sodv2101_Group13_BudgetApp.SubPageForms
{
    partial class GoalPageForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoalPageForm));
			dataGridViewFinancialGoals = new DataGridView();
			dataGridViewContributions = new DataGridView();
			toolStrip2 = new ToolStrip();
			toolStripDropDownButtonAddExpenses = new ToolStripDropDownButton();
			toolBtnAddBudget = new ToolStripMenuItem();
			toolStripMenuItemAddFinanceGoal = new ToolStripMenuItem();
			toolStripMenuItemAddIncome = new ToolStripMenuItem();
			toolStripSeparator5 = new ToolStripSeparator();
			toolStripButton1 = new ToolStripButton();
			toolStripSeparator7 = new ToolStripSeparator();
			toolStripButton2 = new ToolStripButton();
			btnGFPAddGoal = new Button();
			btnGFPDeleteGoal = new Button();
			btnGFPEditGoal = new Button();
			btnGFPViewGoal = new Button();
			lblGPFError = new Label();
			btnAddConbtribution = new Button();
			btnEditContribution = new Button();
			btnDeleteContribution = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewFinancialGoals).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewContributions).BeginInit();
			toolStrip2.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridViewFinancialGoals
			// 
			dataGridViewFinancialGoals.AllowUserToOrderColumns = true;
			dataGridViewFinancialGoals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewFinancialGoals.Location = new Point(12, 98);
			dataGridViewFinancialGoals.Name = "dataGridViewFinancialGoals";
			dataGridViewFinancialGoals.Size = new Size(371, 310);
			dataGridViewFinancialGoals.TabIndex = 0;
			dataGridViewFinancialGoals.SelectionChanged += dataGridViewFinancialGoals_SelectionChanged;
			// 
			// dataGridViewContributions
			// 
			dataGridViewContributions.AllowUserToOrderColumns = true;
			dataGridViewContributions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewContributions.Location = new Point(477, 98);
			dataGridViewContributions.Name = "dataGridViewContributions";
			dataGridViewContributions.Size = new Size(371, 310);
			dataGridViewContributions.TabIndex = 1;
			// 
			// toolStrip2
			// 
			toolStrip2.ImageScalingSize = new Size(20, 20);
			toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripDropDownButtonAddExpenses, toolStripSeparator5, toolStripButton1, toolStripSeparator7, toolStripButton2 });
			toolStrip2.Location = new Point(0, 0);
			toolStrip2.Name = "toolStrip2";
			toolStrip2.Size = new Size(933, 25);
			toolStrip2.TabIndex = 4;
			toolStrip2.Text = "toolStrip2";
			// 
			// toolStripDropDownButtonAddExpenses
			// 
			toolStripDropDownButtonAddExpenses.BackColor = Color.Plum;
			toolStripDropDownButtonAddExpenses.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripDropDownButtonAddExpenses.DropDownItems.AddRange(new ToolStripItem[] { toolBtnAddBudget, toolStripMenuItemAddFinanceGoal, toolStripMenuItemAddIncome });
			toolStripDropDownButtonAddExpenses.Image = (Image)resources.GetObject("toolStripDropDownButtonAddExpenses.Image");
			toolStripDropDownButtonAddExpenses.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButtonAddExpenses.Name = "toolStripDropDownButtonAddExpenses";
			toolStripDropDownButtonAddExpenses.Size = new Size(88, 22);
			toolStripDropDownButtonAddExpenses.Text = "Add Expense";
			// 
			// toolBtnAddBudget
			// 
			toolBtnAddBudget.Name = "toolBtnAddBudget";
			toolBtnAddBudget.Size = new Size(173, 22);
			toolBtnAddBudget.Text = "Add Budget";
			// 
			// toolStripMenuItemAddFinanceGoal
			// 
			toolStripMenuItemAddFinanceGoal.Name = "toolStripMenuItemAddFinanceGoal";
			toolStripMenuItemAddFinanceGoal.Size = new Size(173, 22);
			toolStripMenuItemAddFinanceGoal.Text = "Add Financial Goal";
			// 
			// toolStripMenuItemAddIncome
			// 
			toolStripMenuItemAddIncome.Name = "toolStripMenuItemAddIncome";
			toolStripMenuItemAddIncome.Size = new Size(173, 22);
			toolStripMenuItemAddIncome.Text = "Add Income";
			// 
			// toolStripSeparator5
			// 
			toolStripSeparator5.Name = "toolStripSeparator5";
			toolStripSeparator5.Size = new Size(6, 25);
			// 
			// toolStripButton1
			// 
			toolStripButton1.AutoSize = false;
			toolStripButton1.BackColor = Color.Plum;
			toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(100, 22);
			toolStripButton1.Text = "Income";
			toolStripButton1.TextImageRelation = TextImageRelation.TextAboveImage;
			// 
			// toolStripSeparator7
			// 
			toolStripSeparator7.Name = "toolStripSeparator7";
			toolStripSeparator7.Size = new Size(6, 25);
			// 
			// toolStripButton2
			// 
			toolStripButton2.AutoSize = false;
			toolStripButton2.BackColor = Color.Plum;
			toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
			toolStripButton2.ImageTransparentColor = Color.Magenta;
			toolStripButton2.Name = "toolStripButton2";
			toolStripButton2.Size = new Size(100, 22);
			toolStripButton2.Text = "Reports";
			// 
			// btnGFPAddGoal
			// 
			btnGFPAddGoal.Location = new Point(12, 426);
			btnGFPAddGoal.Name = "btnGFPAddGoal";
			btnGFPAddGoal.Size = new Size(76, 23);
			btnGFPAddGoal.TabIndex = 5;
			btnGFPAddGoal.Text = "Add Goal";
			btnGFPAddGoal.UseVisualStyleBackColor = true;
			btnGFPAddGoal.Click += btnGFPAddGoal_Click;
			// 
			// btnGFPDeleteGoal
			// 
			btnGFPDeleteGoal.Location = new Point(302, 426);
			btnGFPDeleteGoal.Name = "btnGFPDeleteGoal";
			btnGFPDeleteGoal.Size = new Size(81, 23);
			btnGFPDeleteGoal.TabIndex = 6;
			btnGFPDeleteGoal.Text = "Delete";
			btnGFPDeleteGoal.UseVisualStyleBackColor = true;
			btnGFPDeleteGoal.Click += btnGFPDeleteGoal_Click;
			// 
			// btnGFPEditGoal
			// 
			btnGFPEditGoal.Location = new Point(143, 426);
			btnGFPEditGoal.Name = "btnGFPEditGoal";
			btnGFPEditGoal.Size = new Size(77, 23);
			btnGFPEditGoal.TabIndex = 7;
			btnGFPEditGoal.Text = "Edit";
			btnGFPEditGoal.UseVisualStyleBackColor = true;
			btnGFPEditGoal.Click += btnGFPEditGoal_Click;
			// 
			// btnGFPViewGoal
			// 
			btnGFPViewGoal.Location = new Point(261, 58);
			btnGFPViewGoal.Name = "btnGFPViewGoal";
			btnGFPViewGoal.Size = new Size(122, 23);
			btnGFPViewGoal.TabIndex = 8;
			btnGFPViewGoal.Text = "View Contributions";
			btnGFPViewGoal.UseVisualStyleBackColor = true;
			btnGFPViewGoal.Click += btnGFPViewGoal_Click;
			// 
			// lblGPFError
			// 
			lblGPFError.AutoSize = true;
			lblGPFError.Location = new Point(34, 393);
			lblGPFError.Name = "lblGPFError";
			lblGPFError.Size = new Size(0, 15);
			lblGPFError.TabIndex = 9;
			lblGPFError.TextChanged += lblGPFError_TextChanged;
			// 
			// btnAddConbtribution
			// 
			btnAddConbtribution.Location = new Point(477, 426);
			btnAddConbtribution.Name = "btnAddConbtribution";
			btnAddConbtribution.Size = new Size(109, 23);
			btnAddConbtribution.TabIndex = 10;
			btnAddConbtribution.Text = "Add Contribution";
			btnAddConbtribution.UseVisualStyleBackColor = true;
			btnAddConbtribution.Click += btnAddConbtribution_Click;
			// 
			// btnEditContribution
			// 
			btnEditContribution.Location = new Point(640, 426);
			btnEditContribution.Name = "btnEditContribution";
			btnEditContribution.Size = new Size(75, 23);
			btnEditContribution.TabIndex = 11;
			btnEditContribution.Text = "Edit";
			btnEditContribution.UseVisualStyleBackColor = true;
			btnEditContribution.Click += btnEditContribution_Click;
			// 
			// btnDeleteContribution
			// 
			btnDeleteContribution.Location = new Point(773, 426);
			btnDeleteContribution.Name = "btnDeleteContribution";
			btnDeleteContribution.Size = new Size(75, 23);
			btnDeleteContribution.TabIndex = 12;
			btnDeleteContribution.Text = "Delete";
			btnDeleteContribution.UseVisualStyleBackColor = true;
			btnDeleteContribution.Click += btnDeleteContribution_Click;
			// 
			// GoalPageForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(933, 496);
			Controls.Add(btnDeleteContribution);
			Controls.Add(btnEditContribution);
			Controls.Add(btnAddConbtribution);
			Controls.Add(lblGPFError);
			Controls.Add(btnGFPViewGoal);
			Controls.Add(btnGFPEditGoal);
			Controls.Add(btnGFPDeleteGoal);
			Controls.Add(btnGFPAddGoal);
			Controls.Add(toolStrip2);
			Controls.Add(dataGridViewContributions);
			Controls.Add(dataGridViewFinancialGoals);
			Name = "GoalPageForm";
			Text = "GoalPageForm";
			((System.ComponentModel.ISupportInitialize)dataGridViewFinancialGoals).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewContributions).EndInit();
			toolStrip2.ResumeLayout(false);
			toolStrip2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridViewFinancialGoals;
        private DataGridView dataGridViewContributions;
        private ToolStrip toolStrip2;
        private ToolStripDropDownButton toolStripDropDownButtonAddExpenses;
        private ToolStripMenuItem toolBtnAddBudget;
        private ToolStripMenuItem toolStripMenuItemAddFinanceGoal;
        private ToolStripMenuItem toolStripMenuItemAddIncome;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolStripButton2;
        private Button btnGFPAddGoal;
        private Button btnGFPDeleteGoal;
        private Button btnGFPEditGoal;
        private Button btnGFPViewGoal;
        private Label lblGPFError;
		private Button btnAddConbtribution;
		private Button btnEditContribution;
		private Button btnDeleteContribution;
	}
}