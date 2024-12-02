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
            dataGridViewFinancialGoals = new DataGridView();
            dataGridViewContributions = new DataGridView();
            btnGFPAddGoal = new Button();
            btnGFPDeleteGoal = new Button();
            btnGFPEditGoal = new Button();
            btnGFPViewGoal = new Button();
            lblGPFError = new Label();
            btnAddConbtribution = new Button();
            btnEditContribution = new Button();
            btnDeleteContribution = new Button();
            label1 = new Label();
            lblContributionOutput = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinancialGoals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContributions).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFinancialGoals
            // 
            dataGridViewFinancialGoals.AllowUserToAddRows = false;
            dataGridViewFinancialGoals.AllowUserToOrderColumns = true;
            dataGridViewFinancialGoals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFinancialGoals.Location = new Point(12, 70);
            dataGridViewFinancialGoals.Name = "dataGridViewFinancialGoals";
            dataGridViewFinancialGoals.Size = new Size(429, 310);
            dataGridViewFinancialGoals.TabIndex = 0;
            dataGridViewFinancialGoals.SelectionChanged += dataGridViewFinancialGoals_SelectionChanged;
            // 
            // dataGridViewContributions
            // 
            dataGridViewContributions.AllowUserToAddRows = false;
            dataGridViewContributions.AllowUserToOrderColumns = true;
            dataGridViewContributions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContributions.Location = new Point(515, 70);
            dataGridViewContributions.Name = "dataGridViewContributions";
            dataGridViewContributions.Size = new Size(352, 310);
            dataGridViewContributions.TabIndex = 1;
            // 
            // btnGFPAddGoal
            // 
            btnGFPAddGoal.BackColor = Color.Plum;
            btnGFPAddGoal.Location = new Point(12, 386);
            btnGFPAddGoal.Name = "btnGFPAddGoal";
            btnGFPAddGoal.Size = new Size(76, 23);
            btnGFPAddGoal.TabIndex = 5;
            btnGFPAddGoal.Text = "Add Goal";
            btnGFPAddGoal.UseVisualStyleBackColor = false;
            btnGFPAddGoal.Click += btnGFPAddGoal_Click;
            // 
            // btnGFPDeleteGoal
            // 
            btnGFPDeleteGoal.BackColor = Color.Plum;
            btnGFPDeleteGoal.Location = new Point(177, 386);
            btnGFPDeleteGoal.Name = "btnGFPDeleteGoal";
            btnGFPDeleteGoal.Size = new Size(81, 23);
            btnGFPDeleteGoal.TabIndex = 6;
            btnGFPDeleteGoal.Text = "Delete";
            btnGFPDeleteGoal.UseVisualStyleBackColor = false;
            btnGFPDeleteGoal.Click += btnGFPDeleteGoal_Click;
            // 
            // btnGFPEditGoal
            // 
            btnGFPEditGoal.BackColor = Color.Plum;
            btnGFPEditGoal.Location = new Point(94, 386);
            btnGFPEditGoal.Name = "btnGFPEditGoal";
            btnGFPEditGoal.Size = new Size(77, 23);
            btnGFPEditGoal.TabIndex = 7;
            btnGFPEditGoal.Text = "Edit";
            btnGFPEditGoal.UseVisualStyleBackColor = false;
            btnGFPEditGoal.Click += btnGFPEditGoal_Click;
            // 
            // btnGFPViewGoal
            // 
            btnGFPViewGoal.BackColor = Color.Plum;
            btnGFPViewGoal.Location = new Point(319, 41);
            btnGFPViewGoal.Name = "btnGFPViewGoal";
            btnGFPViewGoal.Size = new Size(122, 23);
            btnGFPViewGoal.TabIndex = 8;
            btnGFPViewGoal.Text = "View Contributions";
            btnGFPViewGoal.UseVisualStyleBackColor = false;
            btnGFPViewGoal.Click += btnGFPViewGoal_Click;
            // 
            // lblGPFError
            // 
            lblGPFError.AutoSize = true;
            lblGPFError.Location = new Point(12, 421);
            lblGPFError.Name = "lblGPFError";
            lblGPFError.Size = new Size(0, 15);
            lblGPFError.TabIndex = 9;
            lblGPFError.TextChanged += lblGPFError_TextChanged;
            // 
            // btnAddConbtribution
            // 
            btnAddConbtribution.BackColor = Color.Plum;
            btnAddConbtribution.Location = new Point(515, 386);
            btnAddConbtribution.Name = "btnAddConbtribution";
            btnAddConbtribution.Size = new Size(109, 23);
            btnAddConbtribution.TabIndex = 10;
            btnAddConbtribution.Text = "Add Contribution";
            btnAddConbtribution.UseVisualStyleBackColor = false;
            btnAddConbtribution.Click += btnAddConbtribution_Click;
            // 
            // btnEditContribution
            // 
            btnEditContribution.BackColor = Color.Plum;
            btnEditContribution.Location = new Point(630, 386);
            btnEditContribution.Name = "btnEditContribution";
            btnEditContribution.Size = new Size(75, 23);
            btnEditContribution.TabIndex = 11;
            btnEditContribution.Text = "Edit";
            btnEditContribution.UseVisualStyleBackColor = false;
            btnEditContribution.Click += btnEditContribution_Click;
            // 
            // btnDeleteContribution
            // 
            btnDeleteContribution.BackColor = Color.Plum;
            btnDeleteContribution.Location = new Point(711, 386);
            btnDeleteContribution.Name = "btnDeleteContribution";
            btnDeleteContribution.Size = new Size(75, 23);
            btnDeleteContribution.TabIndex = 12;
            btnDeleteContribution.Text = "Delete";
            btnDeleteContribution.UseVisualStyleBackColor = false;
            btnDeleteContribution.Click += btnDeleteContribution_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 13;
            label1.Text = "My Financial Goals";
            // 
            // lblContributionOutput
            // 
            lblContributionOutput.AutoSize = true;
            lblContributionOutput.Location = new Point(515, 421);
            lblContributionOutput.Name = "lblContributionOutput";
            lblContributionOutput.Size = new Size(0, 15);
            lblContributionOutput.TabIndex = 14;
            // 
            // GoalPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(933, 459);
            Controls.Add(lblContributionOutput);
            Controls.Add(label1);
            Controls.Add(btnDeleteContribution);
            Controls.Add(btnEditContribution);
            Controls.Add(btnAddConbtribution);
            Controls.Add(lblGPFError);
            Controls.Add(btnGFPViewGoal);
            Controls.Add(btnGFPEditGoal);
            Controls.Add(btnGFPDeleteGoal);
            Controls.Add(btnGFPAddGoal);
            Controls.Add(dataGridViewContributions);
            Controls.Add(dataGridViewFinancialGoals);
            Name = "GoalPageForm";
            Text = "GoalPageForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinancialGoals).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContributions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoalPageForm));
        //    dataGridViewFinancialGoals = new DataGridView();
        //    dataGridView2 = new DataGridView();
        //    toolStrip2 = new ToolStrip();
        //    toolStripDropDownButtonAddExpenses = new ToolStripDropDownButton();
        //    toolBtnAddBudget = new ToolStripMenuItem();
        //    toolStripMenuItemAddFinanceGoal = new ToolStripMenuItem();
        //    toolStripMenuItemAddIncome = new ToolStripMenuItem();
        //    toolStripSeparator5 = new ToolStripSeparator();
        //    toolStripDropDownButton3 = new ToolStripDropDownButton();
        //    toolStripMenuItemCreateBudget = new ToolStripMenuItem();
        //    toolStripMenuItemEditBudget = new ToolStripMenuItem();
        //    toolStripSeparator6 = new ToolStripSeparator();
        //    toolStripButton1 = new ToolStripButton();
        //    toolStripSeparator7 = new ToolStripSeparator();
        //    toolStripDropDownButtonGoals = new ToolStripDropDownButton();
        //    toolStripMenuItemAddContribution = new ToolStripMenuItem();
        //    toolStripMenuItemRemoveContribution = new ToolStripMenuItem();
        //    toolStripMenuItemUpdateContribution = new ToolStripMenuItem();
        //    toolStripMenuItemAddGoal = new ToolStripMenuItem();
        //    toolStripMenuItemEditGoal = new ToolStripMenuItem();
        //    toolStripMenuItemDeleteGoal = new ToolStripMenuItem();
        //    toolStripSeparator8 = new ToolStripSeparator();
        //    toolStripButton2 = new ToolStripButton();
        //    btnGFPAddGoal = new Button();
        //    btnGFPDeleteGoal = new Button();
        //    btnGFPEditGoal = new Button();
        //    btnGFPViewGoal = new Button();
        //    lblGPFError = new Label();
        //    ((System.ComponentModel.ISupportInitialize)dataGridViewFinancialGoals).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        //    toolStrip2.SuspendLayout();
        //    SuspendLayout();
        //    // 
        //    // dataGridViewFinancialGoals
        //    // 
        //    dataGridViewFinancialGoals.AllowUserToOrderColumns = true;
        //    dataGridViewFinancialGoals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //    dataGridViewFinancialGoals.Location = new Point(12, 65);
        //    dataGridViewFinancialGoals.Name = "dataGridViewFinancialGoals";
        //    dataGridViewFinancialGoals.Size = new Size(371, 310);
        //    dataGridViewFinancialGoals.TabIndex = 0;
        //    // 
        //    // dataGridView2
        //    // 
        //    dataGridView2.AllowUserToOrderColumns = true;
        //    dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //    dataGridView2.Location = new Point(490, 65);
        //    dataGridView2.Name = "dataGridView2";
        //    dataGridView2.Size = new Size(371, 310);
        //    dataGridView2.TabIndex = 1;
        //    // 
        //    // toolStrip2
        //    // 
        //    toolStrip2.ImageScalingSize = new Size(20, 20);
        //    toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripDropDownButtonAddExpenses, toolStripSeparator5, toolStripDropDownButton3, toolStripSeparator6, toolStripButton1, toolStripSeparator7, toolStripDropDownButtonGoals, toolStripSeparator8, toolStripButton2 });
        //    toolStrip2.Location = new Point(0, 0);
        //    toolStrip2.Name = "toolStrip2";
        //    toolStrip2.Size = new Size(1250, 25);
        //    toolStrip2.TabIndex = 4;
        //    toolStrip2.Text = "toolStrip2";
        //    // 
        //    // toolStripDropDownButtonAddExpenses
        //    // 
        //    toolStripDropDownButtonAddExpenses.BackColor = Color.Plum;
        //    toolStripDropDownButtonAddExpenses.DisplayStyle = ToolStripItemDisplayStyle.Text;
        //    toolStripDropDownButtonAddExpenses.DropDownItems.AddRange(new ToolStripItem[] { toolBtnAddBudget, toolStripMenuItemAddFinanceGoal, toolStripMenuItemAddIncome });
        //    toolStripDropDownButtonAddExpenses.Image = (Image)resources.GetObject("toolStripDropDownButtonAddExpenses.Image");
        //    toolStripDropDownButtonAddExpenses.ImageTransparentColor = Color.Magenta;
        //    toolStripDropDownButtonAddExpenses.Name = "toolStripDropDownButtonAddExpenses";
        //    toolStripDropDownButtonAddExpenses.Size = new Size(88, 22);
        //    toolStripDropDownButtonAddExpenses.Text = "Add Expense";
        //    // 
        //    // toolBtnAddBudget
        //    // 
        //    toolBtnAddBudget.Name = "toolBtnAddBudget";
        //    toolBtnAddBudget.Size = new Size(173, 22);
        //    toolBtnAddBudget.Text = "Add Budget";
        //    // 
        //    // toolStripMenuItemAddFinanceGoal
        //    // 
        //    toolStripMenuItemAddFinanceGoal.Name = "toolStripMenuItemAddFinanceGoal";
        //    toolStripMenuItemAddFinanceGoal.Size = new Size(173, 22);
        //    toolStripMenuItemAddFinanceGoal.Text = "Add Financial Goal";
        //    // 
        //    // toolStripMenuItemAddIncome
        //    // 
        //    toolStripMenuItemAddIncome.Name = "toolStripMenuItemAddIncome";
        //    toolStripMenuItemAddIncome.Size = new Size(173, 22);
        //    toolStripMenuItemAddIncome.Text = "Add Income";
        //    // 
        //    // toolStripSeparator5
        //    // 
        //    toolStripSeparator5.Name = "toolStripSeparator5";
        //    toolStripSeparator5.Size = new Size(6, 25);
        //    // 
        //    // toolStripDropDownButton3
        //    // 
        //    toolStripDropDownButton3.AutoSize = false;
        //    toolStripDropDownButton3.BackColor = Color.Plum;
        //    toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
        //    toolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemCreateBudget, toolStripMenuItemEditBudget });
        //    toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
        //    toolStripDropDownButton3.Name = "toolStripDropDownButton3";
        //    toolStripDropDownButton3.Size = new Size(100, 22);
        //    toolStripDropDownButton3.Text = "Budget";
        //    toolStripDropDownButton3.TextImageRelation = TextImageRelation.TextAboveImage;
        //    // 
        //    // toolStripMenuItemCreateBudget
        //    // 
        //    toolStripMenuItemCreateBudget.Name = "toolStripMenuItemCreateBudget";
        //    toolStripMenuItemCreateBudget.Size = new Size(149, 22);
        //    toolStripMenuItemCreateBudget.Text = "Create Budget";
        //    // 
        //    // toolStripMenuItemEditBudget
        //    // 
        //    toolStripMenuItemEditBudget.Name = "toolStripMenuItemEditBudget";
        //    toolStripMenuItemEditBudget.Size = new Size(149, 22);
        //    toolStripMenuItemEditBudget.Text = "Edit Budget";
        //    // 
        //    // toolStripSeparator6
        //    // 
        //    toolStripSeparator6.Name = "toolStripSeparator6";
        //    toolStripSeparator6.Size = new Size(6, 25);
        //    // 
        //    // toolStripButton1
        //    // 
        //    toolStripButton1.AutoSize = false;
        //    toolStripButton1.BackColor = Color.Plum;
        //    toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
        //    toolStripButton1.ImageTransparentColor = Color.Magenta;
        //    toolStripButton1.Name = "toolStripButton1";
        //    toolStripButton1.Size = new Size(100, 22);
        //    toolStripButton1.Text = "Income";
        //    toolStripButton1.TextImageRelation = TextImageRelation.TextAboveImage;
        //    // 
        //    // toolStripSeparator7
        //    // 
        //    toolStripSeparator7.Name = "toolStripSeparator7";
        //    toolStripSeparator7.Size = new Size(6, 25);
        //    // 
        //    // toolStripDropDownButtonGoals
        //    // 
        //    toolStripDropDownButtonGoals.AutoSize = false;
        //    toolStripDropDownButtonGoals.BackColor = Color.Plum;
        //    toolStripDropDownButtonGoals.DisplayStyle = ToolStripItemDisplayStyle.Text;
        //    toolStripDropDownButtonGoals.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAddContribution, toolStripMenuItemRemoveContribution, toolStripMenuItemUpdateContribution, toolStripMenuItemAddGoal, toolStripMenuItemEditGoal, toolStripMenuItemDeleteGoal });
        //    toolStripDropDownButtonGoals.Image = (Image)resources.GetObject("toolStripDropDownButtonGoals.Image");
        //    toolStripDropDownButtonGoals.ImageTransparentColor = Color.Magenta;
        //    toolStripDropDownButtonGoals.Name = "toolStripDropDownButtonGoals";
        //    toolStripDropDownButtonGoals.Size = new Size(100, 22);
        //    toolStripDropDownButtonGoals.Text = "Goals";
        //    toolStripDropDownButtonGoals.Click += toolStripDropDownButtonGoals_Click;
        //    toolStripDropDownButtonGoals.DoubleClick += toolStripDropDownButtonGoals_DoubleClick;
        //    // 
        //    // toolStripMenuItemAddContribution
        //    // 
        //    toolStripMenuItemAddContribution.Name = "toolStripMenuItemAddContribution";
        //    toolStripMenuItemAddContribution.Size = new Size(188, 22);
        //    toolStripMenuItemAddContribution.Text = "Add Contribution";
        //    // 
        //    // toolStripMenuItemRemoveContribution
        //    // 
        //    toolStripMenuItemRemoveContribution.Name = "toolStripMenuItemRemoveContribution";
        //    toolStripMenuItemRemoveContribution.Size = new Size(188, 22);
        //    toolStripMenuItemRemoveContribution.Text = "Remove Contribution";
        //    toolStripMenuItemRemoveContribution.Click += toolStripMenuItemRemoveContribution_Click;
        //    // 
        //    // toolStripMenuItemUpdateContribution
        //    // 
        //    toolStripMenuItemUpdateContribution.Name = "toolStripMenuItemUpdateContribution";
        //    toolStripMenuItemUpdateContribution.Size = new Size(188, 22);
        //    toolStripMenuItemUpdateContribution.Text = "Update Contribution";
        //    // 
        //    // toolStripMenuItemAddGoal
        //    // 
        //    toolStripMenuItemAddGoal.Name = "toolStripMenuItemAddGoal";
        //    toolStripMenuItemAddGoal.Size = new Size(188, 22);
        //    toolStripMenuItemAddGoal.Text = "Add Goal";
        //    toolStripMenuItemAddGoal.Click += toolStripMenuItemAddGoal_Click;
        //    // 
        //    // toolStripMenuItemEditGoal
        //    // 
        //    toolStripMenuItemEditGoal.Name = "toolStripMenuItemEditGoal";
        //    toolStripMenuItemEditGoal.Size = new Size(188, 22);
        //    toolStripMenuItemEditGoal.Text = "Edit Goal";
        //    // 
        //    // toolStripMenuItemDeleteGoal
        //    // 
        //    toolStripMenuItemDeleteGoal.Name = "toolStripMenuItemDeleteGoal";
        //    toolStripMenuItemDeleteGoal.Size = new Size(188, 22);
        //    toolStripMenuItemDeleteGoal.Text = "Delete Goal";
        //    // 
        //    // toolStripSeparator8
        //    // 
        //    toolStripSeparator8.Name = "toolStripSeparator8";
        //    toolStripSeparator8.Size = new Size(6, 25);
        //    // 
        //    // toolStripButton2
        //    // 
        //    toolStripButton2.AutoSize = false;
        //    toolStripButton2.BackColor = Color.Plum;
        //    toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
        //    toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
        //    toolStripButton2.ImageTransparentColor = Color.Magenta;
        //    toolStripButton2.Name = "toolStripButton2";
        //    toolStripButton2.Size = new Size(100, 22);
        //    toolStripButton2.Text = "Reports";
        //    // 
        //    // btnGFPAddGoal
        //    // 
        //    btnGFPAddGoal.Location = new Point(88, 422);
        //    btnGFPAddGoal.Name = "btnGFPAddGoal";
        //    btnGFPAddGoal.Size = new Size(132, 23);
        //    btnGFPAddGoal.TabIndex = 5;
        //    btnGFPAddGoal.Text = "ADD";
        //    btnGFPAddGoal.UseVisualStyleBackColor = true;
        //    btnGFPAddGoal.Click += btnGFPAddGoal_Click;
        //    // 
        //    // btnGFPDeleteGoal
        //    // 
        //    btnGFPDeleteGoal.Location = new Point(344, 422);
        //    btnGFPDeleteGoal.Name = "btnGFPDeleteGoal";
        //    btnGFPDeleteGoal.Size = new Size(132, 23);
        //    btnGFPDeleteGoal.TabIndex = 6;
        //    btnGFPDeleteGoal.Text = "DELETE";
        //    btnGFPDeleteGoal.UseVisualStyleBackColor = true;
        //    btnGFPDeleteGoal.Click += btnGFPDeleteGoal_Click;
        //    // 
        //    // btnGFPEditGoal
        //    // 
        //    btnGFPEditGoal.Location = new Point(577, 422);
        //    btnGFPEditGoal.Name = "btnGFPEditGoal";
        //    btnGFPEditGoal.Size = new Size(132, 23);
        //    btnGFPEditGoal.TabIndex = 7;
        //    btnGFPEditGoal.Text = "EDIT";
        //    btnGFPEditGoal.UseVisualStyleBackColor = true;
        //    btnGFPEditGoal.Click += btnGFPEditGoal_Click;
        //    // 
        //    // btnGFPViewGoal
        //    // 
        //    btnGFPViewGoal.Location = new Point(837, 422);
        //    btnGFPViewGoal.Name = "btnGFPViewGoal";
        //    btnGFPViewGoal.Size = new Size(132, 23);
        //    btnGFPViewGoal.TabIndex = 8;
        //    btnGFPViewGoal.Text = "VIEW";
        //    btnGFPViewGoal.UseVisualStyleBackColor = true;
        //    // 
        //    // lblGPFError
        //    // 
        //    lblGPFError.AutoSize = true;
        //    lblGPFError.Location = new Point(34, 393);
        //    lblGPFError.Name = "lblGPFError";
        //    lblGPFError.Size = new Size(0, 15);
        //    lblGPFError.TabIndex = 9;
        //    lblGPFError.TextChanged += lblGPFError_TextChanged;
        //    // 
        //    // GoalPageForm
        //    // 
        //    AutoScaleDimensions = new SizeF(7F, 15F);
        //    AutoScaleMode = AutoScaleMode.Font;
        //    ClientSize = new Size(1250, 496);
        //    Controls.Add(lblGPFError);
        //    Controls.Add(btnGFPViewGoal);
        //    Controls.Add(btnGFPEditGoal);
        //    Controls.Add(btnGFPDeleteGoal);
        //    Controls.Add(btnGFPAddGoal);
        //    Controls.Add(toolStrip2);
        //    Controls.Add(dataGridView2);
        //    Controls.Add(dataGridViewFinancialGoals);
        //    Name = "GoalPageForm";
        //    Text = "GoalPageForm";
        //    ((System.ComponentModel.ISupportInitialize)dataGridViewFinancialGoals).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        //    toolStrip2.ResumeLayout(false);
        //    toolStrip2.PerformLayout();
        //    ResumeLayout(false);
        //    PerformLayout();
        //}


        #endregion

        private DataGridView dataGridViewFinancialGoals;
        private DataGridView dataGridViewContributions;
        private Button btnGFPAddGoal;
        private Button btnGFPDeleteGoal;
        private Button btnGFPEditGoal;
        private Button btnGFPViewGoal;
        private Label lblGPFError;
		private Button btnAddConbtribution;
		private Button btnEditContribution;
		private Button btnDeleteContribution;
        private Label label1;
        private Label lblContributionOutput;
    }
}