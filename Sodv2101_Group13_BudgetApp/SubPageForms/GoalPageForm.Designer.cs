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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoalPageForm));
            dataGridViewFinancialGoals = new DataGridView();
            dataGridViewContributions = new DataGridView();
            toolStrip2 = new ToolStrip();
            toolStripDropDownButtonAddExpenses = new ToolStripDropDownButton();
            toolBtnAddBudget = new ToolStripMenuItem();
            toolStripMenuItemAddFinanceGoal = new ToolStripMenuItem();
            toolStripMenuItemAddIncome = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripDropDownButton3 = new ToolStripDropDownButton();
            toolStripMenuItemCreateBudget = new ToolStripMenuItem();
            toolStripMenuItemEditBudget = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripDropDownButtonGoals = new ToolStripDropDownButton();
            toolStripMenuItemAddContribution = new ToolStripMenuItem();
            toolStripMenuItemRemoveContribution = new ToolStripMenuItem();
            toolStripMenuItemUpdateContribution = new ToolStripMenuItem();
            toolStripMenuItemAddGoal = new ToolStripMenuItem();
            toolStripMenuItemEditGoal = new ToolStripMenuItem();
            toolStripMenuItemDeleteGoal = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            btnGFPAddGoal = new Button();
            btnGFPDeleteGoal = new Button();
            btnGFPEditGoal = new Button();
            btnGFPViewGoal = new Button();
            contextMenuStripView = new ContextMenuStrip(components);
            toolStripMenuItemViewGoals = new ToolStripMenuItem();
            toolStripMenuItemViewContribution = new ToolStripMenuItem();
            lblGPFError = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinancialGoals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContributions).BeginInit();
            toolStrip2.SuspendLayout();
            contextMenuStripView.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewFinancialGoals
            // 
            dataGridViewFinancialGoals.AllowUserToOrderColumns = true;
            dataGridViewFinancialGoals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFinancialGoals.Location = new Point(12, 65);
            dataGridViewFinancialGoals.Name = "dataGridViewFinancialGoals";
            dataGridViewFinancialGoals.Size = new Size(371, 310);
            dataGridViewFinancialGoals.TabIndex = 0;
            dataGridViewFinancialGoals.SelectionChanged += dataGridViewFinancialGoals_SelectionChanged;
            // 
            // dataGridViewContributions
            // 
            dataGridViewContributions.AllowUserToOrderColumns = true;
            dataGridViewContributions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContributions.Location = new Point(490, 65);
            dataGridViewContributions.Name = "dataGridViewContributions";
            dataGridViewContributions.Size = new Size(371, 310);
            dataGridViewContributions.TabIndex = 1;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripDropDownButtonAddExpenses, toolStripSeparator5, toolStripDropDownButton3, toolStripSeparator6, toolStripButton1, toolStripSeparator7, toolStripDropDownButtonGoals, toolStripSeparator8, toolStripButton2 });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1250, 25);
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
            // toolStripDropDownButton3
            // 
            toolStripDropDownButton3.AutoSize = false;
            toolStripDropDownButton3.BackColor = Color.Plum;
            toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemCreateBudget, toolStripMenuItemEditBudget });
            toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            toolStripDropDownButton3.Size = new Size(100, 22);
            toolStripDropDownButton3.Text = "Budget";
            toolStripDropDownButton3.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // toolStripMenuItemCreateBudget
            // 
            toolStripMenuItemCreateBudget.Name = "toolStripMenuItemCreateBudget";
            toolStripMenuItemCreateBudget.Size = new Size(149, 22);
            toolStripMenuItemCreateBudget.Text = "Create Budget";
            // 
            // toolStripMenuItemEditBudget
            // 
            toolStripMenuItemEditBudget.Name = "toolStripMenuItemEditBudget";
            toolStripMenuItemEditBudget.Size = new Size(149, 22);
            toolStripMenuItemEditBudget.Text = "Edit Budget";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
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
            // toolStripDropDownButtonGoals
            // 
            toolStripDropDownButtonGoals.AutoSize = false;
            toolStripDropDownButtonGoals.BackColor = Color.Plum;
            toolStripDropDownButtonGoals.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButtonGoals.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAddContribution, toolStripMenuItemRemoveContribution, toolStripMenuItemUpdateContribution, toolStripMenuItemAddGoal, toolStripMenuItemEditGoal, toolStripMenuItemDeleteGoal });
            toolStripDropDownButtonGoals.Image = (Image)resources.GetObject("toolStripDropDownButtonGoals.Image");
            toolStripDropDownButtonGoals.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButtonGoals.Name = "toolStripDropDownButtonGoals";
            toolStripDropDownButtonGoals.Size = new Size(100, 22);
            toolStripDropDownButtonGoals.Text = "Goals";
            toolStripDropDownButtonGoals.Click += toolStripDropDownButtonGoals_Click;
            toolStripDropDownButtonGoals.DoubleClick += toolStripDropDownButtonGoals_DoubleClick;
            // 
            // toolStripMenuItemAddContribution
            // 
            toolStripMenuItemAddContribution.Name = "toolStripMenuItemAddContribution";
            toolStripMenuItemAddContribution.Size = new Size(188, 22);
            toolStripMenuItemAddContribution.Text = "Add Contribution";
            toolStripMenuItemAddContribution.Click += toolStripMenuItemAddContribution_Click;
            // 
            // toolStripMenuItemRemoveContribution
            // 
            toolStripMenuItemRemoveContribution.Name = "toolStripMenuItemRemoveContribution";
            toolStripMenuItemRemoveContribution.Size = new Size(188, 22);
            toolStripMenuItemRemoveContribution.Text = "Remove Contribution";
            toolStripMenuItemRemoveContribution.Click += toolStripMenuItemRemoveContribution_Click;
            // 
            // toolStripMenuItemUpdateContribution
            // 
            toolStripMenuItemUpdateContribution.Name = "toolStripMenuItemUpdateContribution";
            toolStripMenuItemUpdateContribution.Size = new Size(188, 22);
            toolStripMenuItemUpdateContribution.Text = "Update Contribution";
            toolStripMenuItemUpdateContribution.Click += toolStripMenuItemUpdateContribution_Click;
            // 
            // toolStripMenuItemAddGoal
            // 
            toolStripMenuItemAddGoal.Name = "toolStripMenuItemAddGoal";
            toolStripMenuItemAddGoal.Size = new Size(188, 22);
            toolStripMenuItemAddGoal.Text = "Add Goal";
            toolStripMenuItemAddGoal.Click += toolStripMenuItemAddGoal_Click;
            // 
            // toolStripMenuItemEditGoal
            // 
            toolStripMenuItemEditGoal.Name = "toolStripMenuItemEditGoal";
            toolStripMenuItemEditGoal.Size = new Size(188, 22);
            toolStripMenuItemEditGoal.Text = "Edit Goal";
            toolStripMenuItemEditGoal.Click += toolStripMenuItemEditGoal_Click;
            // 
            // toolStripMenuItemDeleteGoal
            // 
            toolStripMenuItemDeleteGoal.Name = "toolStripMenuItemDeleteGoal";
            toolStripMenuItemDeleteGoal.Size = new Size(188, 22);
            toolStripMenuItemDeleteGoal.Text = "Delete Goal";
            toolStripMenuItemDeleteGoal.Click += toolStripMenuItemDeleteGoal_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 25);
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
            btnGFPAddGoal.Location = new Point(88, 422);
            btnGFPAddGoal.Name = "btnGFPAddGoal";
            btnGFPAddGoal.Size = new Size(132, 23);
            btnGFPAddGoal.TabIndex = 5;
            btnGFPAddGoal.Text = "ADD";
            btnGFPAddGoal.UseVisualStyleBackColor = true;
            btnGFPAddGoal.Click += btnGFPAddGoal_Click;
            // 
            // btnGFPDeleteGoal
            // 
            btnGFPDeleteGoal.Location = new Point(344, 422);
            btnGFPDeleteGoal.Name = "btnGFPDeleteGoal";
            btnGFPDeleteGoal.Size = new Size(132, 23);
            btnGFPDeleteGoal.TabIndex = 6;
            btnGFPDeleteGoal.Text = "DELETE";
            btnGFPDeleteGoal.UseVisualStyleBackColor = true;
            btnGFPDeleteGoal.Click += btnGFPDeleteGoal_Click;
            // 
            // btnGFPEditGoal
            // 
            btnGFPEditGoal.Location = new Point(577, 422);
            btnGFPEditGoal.Name = "btnGFPEditGoal";
            btnGFPEditGoal.Size = new Size(132, 23);
            btnGFPEditGoal.TabIndex = 7;
            btnGFPEditGoal.Text = "EDIT";
            btnGFPEditGoal.UseVisualStyleBackColor = true;
            btnGFPEditGoal.Click += btnGFPEditGoal_Click;
            // 
            // btnGFPViewGoal
            // 
            btnGFPViewGoal.ContextMenuStrip = contextMenuStripView;
            btnGFPViewGoal.Location = new Point(837, 422);
            btnGFPViewGoal.Name = "btnGFPViewGoal";
            btnGFPViewGoal.Size = new Size(132, 23);
            btnGFPViewGoal.TabIndex = 8;
            btnGFPViewGoal.Text = "VIEW";
            btnGFPViewGoal.UseVisualStyleBackColor = true;
            btnGFPViewGoal.Click += btnGFPViewGoal_Click;
            // 
            // contextMenuStripView
            // 
            contextMenuStripView.Items.AddRange(new ToolStripItem[] { toolStripMenuItemViewGoals, toolStripMenuItemViewContribution });
            contextMenuStripView.Name = "contextMenuStripView";
            contextMenuStripView.Size = new Size(176, 48);
            contextMenuStripView.Text = "View Goals";
            // 
            // toolStripMenuItemViewGoals
            // 
            toolStripMenuItemViewGoals.Name = "toolStripMenuItemViewGoals";
            toolStripMenuItemViewGoals.Size = new Size(175, 22);
            toolStripMenuItemViewGoals.Text = "View Goals";
            toolStripMenuItemViewGoals.Click += toolStripMenuItemViewGoals_Click;
            // 
            // toolStripMenuItemViewContribution
            // 
            toolStripMenuItemViewContribution.Name = "toolStripMenuItemViewContribution";
            toolStripMenuItemViewContribution.Size = new Size(175, 22);
            toolStripMenuItemViewContribution.Text = "View Contributions";
            toolStripMenuItemViewContribution.Click += toolStripMenuItemViewContribution_Click;
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
            // GoalPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 496);
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
            contextMenuStripView.ResumeLayout(false);
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
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripMenuItem toolStripMenuItemCreateBudget;
        private ToolStripMenuItem toolStripMenuItemEditBudget;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripDropDownButton toolStripDropDownButtonGoals;
        private ToolStripMenuItem toolStripMenuItemAddContribution;
        private ToolStripMenuItem toolStripMenuItemRemoveContribution;
        private ToolStripMenuItem toolStripMenuItemUpdateContribution;
        private ToolStripMenuItem toolStripMenuItemAddGoal;
        private ToolStripMenuItem toolStripMenuItemEditGoal;
        private ToolStripMenuItem toolStripMenuItemDeleteGoal;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton toolStripButton2;
        private Button btnGFPAddGoal;
        private Button btnGFPDeleteGoal;
        private Button btnGFPEditGoal;
        private Button btnGFPViewGoal;
        private Label lblGPFError;
        private ContextMenuStrip contextMenuStripView;
        private ToolStripMenuItem toolStripMenuItemViewGoals;
        private ToolStripMenuItem toolStripMenuItemViewContribution;
    }
}