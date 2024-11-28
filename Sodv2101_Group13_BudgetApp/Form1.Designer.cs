﻿namespace Sodv2101_Group13_BudgetApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			btnCreateBudget = new Button();
			comboBudgets = new ComboBox();
			button1 = new Button();
			label1 = new Label();
			label2 = new Label();
			picBudgetGraphs = new PictureBox();
			toolStripDropDownButton1 = new ToolStripDropDownButton();
			toolBtnAddExpense = new ToolStripMenuItem();
			toolStripSeparator2 = new ToolStripSeparator();
			btnToolStripBudget = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			btnToolStripIncome = new ToolStripButton();
			toolStripSeparator3 = new ToolStripSeparator();
			//btnToolStripGoals = new ToolStripButton();
			toolStripSeparator4 = new ToolStripSeparator();
			btnToolStripReports = new ToolStripButton();
			toolStrip1 = new ToolStrip();
			toolStripDropDownButton2 = new ToolStripDropDownButton();
			createBudgetToolStripMenuItem = new ToolStripMenuItem();
			editBudgetToolStripMenuItem = new ToolStripMenuItem();
			label3 = new Label();
			btnToolStripDropDownButtonGoals = new ToolStripDropDownButton();
			toolStripMenuItemAddContribution = new ToolStripMenuItem();
			toolStripMenuItemRemoveContribution = new ToolStripMenuItem();
			toolStripMenuItemUpdateContribution = new ToolStripMenuItem();
			toolStripMenuItemAddGoal = new ToolStripMenuItem();
			toolStripMenuItemEditGoal = new ToolStripMenuItem();
			toolStripMenuItemDeleteGoal = new ToolStripMenuItem();

			((System.ComponentModel.ISupportInitialize)picBudgetGraphs).BeginInit();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// btnCreateBudget
			// 
			btnCreateBudget.Location = new Point(747, 67);
			btnCreateBudget.Name = "btnCreateBudget";
			btnCreateBudget.Size = new Size(106, 23);
			btnCreateBudget.TabIndex = 0;
			btnCreateBudget.Text = "Create Budget";
			btnCreateBudget.UseVisualStyleBackColor = true;
			btnCreateBudget.Click += btnCreateBudget_Click;
			// 
			// comboBudgets
			// 
			comboBudgets.FormattingEnabled = true;
			comboBudgets.Location = new Point(732, 132);
			comboBudgets.Name = "comboBudgets";
			comboBudgets.Size = new Size(121, 23);
			comboBudgets.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(898, 210);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 3;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 16F);
			label1.Location = new Point(12, 37);
			label1.Name = "label1";
			label1.Size = new Size(295, 30);
			label1.TabIndex = 4;
			label1.Text = "Welcome to the Budget App!";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(12, 134);
			label2.Name = "label2";
			label2.Size = new Size(126, 21);
			label2.TabIndex = 5;
			label2.Text = "Monthly Income:";
			// 
			// picBudgetGraphs
			// 
			picBudgetGraphs.Location = new Point(107, 225);
			picBudgetGraphs.Name = "picBudgetGraphs";
			picBudgetGraphs.Size = new Size(250, 150);
			picBudgetGraphs.TabIndex = 6;
			picBudgetGraphs.TabStop = false;
			// 
			// toolStripDropDownButton1
			// 
			toolStripDropDownButton1.BackColor = Color.Plum;
			toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { toolBtnAddExpense });
			toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
			toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			toolStripDropDownButton1.Size = new Size(69, 24);
			toolStripDropDownButton1.Text = "Add New";
			// 
			// toolBtnAddExpense
			// 
			toolBtnAddExpense.Name = "toolBtnAddExpense";
			toolBtnAddExpense.Size = new Size(142, 22);
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
			btnToolStripBudget.Click += btnToolStripBudget_Click;
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
			//btnToolStripGoals.AutoSize = false;
			//btnToolStripGoals.BackColor = Color.Plum;
			//btnToolStripGoals.DisplayStyle = ToolStripItemDisplayStyle.Text;
			//btnToolStripGoals.Image = (Image)resources.GetObject("btnToolStripGoals.Image");
			//btnToolStripGoals.ImageTransparentColor = Color.Magenta;
			//btnToolStripGoals.Name = "btnToolStripGoals";
			//btnToolStripGoals.Size = new Size(100, 22);
			//btnToolStripGoals.Text = "Goals";
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
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(20, 20);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator2, toolStripDropDownButton2, btnToolStripBudget, toolStripSeparator1, btnToolStripIncome, toolStripSeparator3, toolStripSeparator4, btnToolStripReports });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(998, 27);
			toolStrip1.TabIndex = 2;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton2
			// 
			toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { createBudgetToolStripMenuItem, editBudgetToolStripMenuItem });
			toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
			toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			toolStripDropDownButton2.Size = new Size(33, 24);
			toolStripDropDownButton2.Text = "toolStripDropDownButton2";
			// 
			// createBudgetToolStripMenuItem
			// 
			createBudgetToolStripMenuItem.Name = "createBudgetToolStripMenuItem";
			createBudgetToolStripMenuItem.Size = new Size(146, 22);
			createBudgetToolStripMenuItem.Text = "CreateBudget";
			// 
			// editBudgetToolStripMenuItem
			// 
			editBudgetToolStripMenuItem.Name = "editBudgetToolStripMenuItem";
			editBudgetToolStripMenuItem.Size = new Size(146, 22);
			editBudgetToolStripMenuItem.Text = "Edit Budget";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.Location = new Point(12, 199);
			label3.Name = "label3";
			label3.Size = new Size(66, 21);
			label3.TabIndex = 7;
			label3.Text = "Budgets";
			// 
			// btnToolStripDropDownButtonGoals
			// 
			btnToolStripDropDownButtonGoals.AutoSize = false;
			btnToolStripDropDownButtonGoals.BackColor = Color.Plum;
			btnToolStripDropDownButtonGoals.DisplayStyle = ToolStripItemDisplayStyle.Text;
			btnToolStripDropDownButtonGoals.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAddContribution, toolStripMenuItemRemoveContribution, toolStripMenuItemUpdateContribution, toolStripMenuItemAddGoal, toolStripMenuItemEditGoal, toolStripMenuItemDeleteGoal });
			btnToolStripDropDownButtonGoals.Image = (Image)resources.GetObject("btnToolStripDropDownButtonGoals.Image");
			btnToolStripDropDownButtonGoals.ImageTransparentColor = Color.Magenta;
			btnToolStripDropDownButtonGoals.Name = "btnToolStripDropDownButtonGoals";
			btnToolStripDropDownButtonGoals.Size = new Size(100, 22);
			btnToolStripDropDownButtonGoals.Text = "Goals";
			btnToolStripDropDownButtonGoals.Click += btnToolStripDropDownButtonGoals_Click;
			// 
			// toolStripMenuItemAddContribution
			// 
			toolStripMenuItemAddContribution.Name = "toolStripMenuItemAddContribution";
			toolStripMenuItemAddContribution.Size = new Size(188, 22);
			toolStripMenuItemAddContribution.Text = "Add Contribution";
			// 
			// toolStripMenuItemRemoveContribution
			// 
			toolStripMenuItemRemoveContribution.Name = "toolStripMenuItemRemoveContribution";
			toolStripMenuItemRemoveContribution.Size = new Size(188, 22);
			toolStripMenuItemRemoveContribution.Text = "Remove Contribution";
			// 
			// toolStripMenuItemUpdateContribution
			// 
			toolStripMenuItemUpdateContribution.Name = "toolStripMenuItemUpdateContribution";
			toolStripMenuItemUpdateContribution.Size = new Size(188, 22);
			toolStripMenuItemUpdateContribution.Text = "Update Contribution";
			// 
			// toolStripMenuItemAddGoal
			// 
			toolStripMenuItemAddGoal.Name = "toolStripMenuItemAddGoal";
			toolStripMenuItemAddGoal.Size = new Size(188, 22);
			toolStripMenuItemAddGoal.Text = "Add Goal";
			// 
			// toolStripMenuItemEditGoal
			// 
			toolStripMenuItemEditGoal.Name = "toolStripMenuItemEditGoal";
			toolStripMenuItemEditGoal.Size = new Size(188, 22);
			toolStripMenuItemEditGoal.Text = "Edit Goal";
			// 
			// toolStripMenuItemDeleteGoal
			// 
			toolStripMenuItemDeleteGoal.Name = "toolStripMenuItemDeleteGoal";
			toolStripMenuItemDeleteGoal.Size = new Size(188, 22);
			toolStripMenuItemDeleteGoal.Text = "Delete Goal";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(998, 590);
			Controls.Add(label3);
			Controls.Add(picBudgetGraphs);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(toolStrip1);
			Controls.Add(comboBudgets);
			Controls.Add(btnCreateBudget);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)picBudgetGraphs).EndInit();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        
		#endregion

		private Button btnCreateBudget;
        private ComboBox comboBudgets;
        private Button button1;
		private Label label1;
		private Label label2;
		private PictureBox picBudgetGraphs;
		private ToolStripDropDownButton toolStripDropDownButton1;
		private ToolStripMenuItem toolBtnAddExpense;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripButton btnToolStripBudget;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton btnToolStripIncome;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripButton btnToolStripReports;
		private ToolStrip toolStrip1;
		private Label label3;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem createBudgetToolStripMenuItem;
        private ToolStripMenuItem editBudgetToolStripMenuItem;
        private ToolStripDropDownButton btnToolStripDropDownButtonGoals;
        private ToolStripMenuItem toolStripMenuItemAddContribution;
        private ToolStripMenuItem toolStripMenuItemRemoveContribution;
        private ToolStripMenuItem toolStripMenuItemUpdateContribution;
        private ToolStripMenuItem toolStripMenuItemAddGoal;
        private ToolStripMenuItem toolStripMenuItemEditGoal;
        private ToolStripMenuItem toolStripMenuItemDeleteGoal;
    }
}




/*
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
				btnCreateBudget = new Button();
				comboBudgets = new ComboBox();
				button1 = new Button();
				label1 = new Label();
				label2 = new Label();
				toolStripDropDownButton1 = new ToolStripDropDownButton();
				toolBtnAddExpense = new ToolStripMenuItem();
				toolStripSeparator2 = new ToolStripSeparator();
				btnToolStripBudget = new ToolStripButton();
				toolStripSeparator1 = new ToolStripSeparator();
				btnToolStripIncome = new ToolStripButton();
				toolStripSeparator3 = new ToolStripSeparator();
				toolStripSeparator4 = new ToolStripSeparator();
				btnToolStripReports = new ToolStripButton();
				toolStrip1 = new ToolStrip();
				toolStripDropDownButton2 = new ToolStripDropDownButton();
				createBudgetToolStripMenuItem = new ToolStripMenuItem();
				editBudgetToolStripMenuItem = new ToolStripMenuItem();
				label3 = new Label();
				btnToolStripDropDownButtonGoals = new ToolStripDropDownButton();
				toolStripMenuItemAddContribution = new ToolStripMenuItem();
				toolStripMenuItemRemoveContribution = new ToolStripMenuItem();
				toolStripMenuItemUpdateContribution = new ToolStripMenuItem();
				toolStripMenuItemAddGoal = new ToolStripMenuItem();
				toolStripMenuItemEditGoal = new ToolStripMenuItem();
				toolStripMenuItemDeleteGoal = new ToolStripMenuItem();
				toolStrip1.SuspendLayout();
				SuspendLayout();
				// 
				// btnCreateBudget
				// 
				btnCreateBudget.Location = new Point(599, 82);
				btnCreateBudget.Name = "btnCreateBudget";
				btnCreateBudget.Size = new Size(106, 23);
				btnCreateBudget.TabIndex = 0;
				btnCreateBudget.Text = "Create Budget";
				btnCreateBudget.UseVisualStyleBackColor = true;
				btnCreateBudget.Click += btnCreateBudget_Click;
				// 
				// comboBudgets
				// 
				comboBudgets.FormattingEnabled = true;
				comboBudgets.Location = new Point(584, 147);
				comboBudgets.Name = "comboBudgets";
				comboBudgets.Size = new Size(121, 23);
				comboBudgets.TabIndex = 1;
				// 
				// button1
				// 
				button1.Location = new Point(750, 225);
				button1.Name = "button1";
				button1.Size = new Size(75, 23);
				button1.TabIndex = 3;
				button1.Text = "button1";
				button1.UseVisualStyleBackColor = true;
				button1.Click += button1_Click;
				// 
				// label1
				// 
				label1.AutoSize = true;
				label1.Font = new Font("Segoe UI", 16F);
				label1.Location = new Point(12, 37);
				label1.Name = "label1";
				label1.Size = new Size(295, 30);
				label1.TabIndex = 4;
				label1.Text = "Welcome to the Budget App!";
				// 
				// label2
				// 
				label2.AutoSize = true;
				label2.Font = new Font("Segoe UI", 12F);
				label2.Location = new Point(12, 134);
				label2.Name = "label2";
				label2.Size = new Size(126, 21);
				label2.TabIndex = 5;
				label2.Text = "Monthly Income:";
				// 
				// toolStripDropDownButton1
				// 
				toolStripDropDownButton1.BackColor = Color.Plum;
				toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
				toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { toolBtnAddExpense });
				toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
				toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
				toolStripDropDownButton1.Name = "toolStripDropDownButton1";
				toolStripDropDownButton1.Size = new Size(69, 24);
				toolStripDropDownButton1.Text = "Add New";
				// 
				// toolBtnAddExpense
				// 
				toolBtnAddExpense.Name = "toolBtnAddExpense";
				toolBtnAddExpense.Size = new Size(180, 22);
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
				btnToolStripBudget.Click += btnToolStripBudget_Click;
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
				// toolStrip1
				// 
				toolStrip1.ImageScalingSize = new Size(20, 20);
				toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator2, toolStripDropDownButton2, btnToolStripBudget, toolStripSeparator1, btnToolStripIncome, toolStripSeparator3, btnToolStripDropDownButtonGoals, toolStripSeparator4, btnToolStripReports });
				toolStrip1.Location = new Point(0, 0);
				toolStrip1.Name = "toolStrip1";
				toolStrip1.Size = new Size(998, 27);
				toolStrip1.TabIndex = 2;
				toolStrip1.Text = "toolStrip1";
				// 
				// toolStripDropDownButton2
				// 
				toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
				toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { createBudgetToolStripMenuItem, editBudgetToolStripMenuItem });
				toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
				toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
				toolStripDropDownButton2.Name = "toolStripDropDownButton2";
				toolStripDropDownButton2.Size = new Size(33, 24);
				toolStripDropDownButton2.Text = "toolStripDropDownButton2";
				// 
				// createBudgetToolStripMenuItem
				// 
				createBudgetToolStripMenuItem.Name = "createBudgetToolStripMenuItem";
				createBudgetToolStripMenuItem.Size = new Size(146, 22);
				createBudgetToolStripMenuItem.Text = "CreateBudget";
				// 
				// editBudgetToolStripMenuItem
				// 
				editBudgetToolStripMenuItem.Name = "editBudgetToolStripMenuItem";
				editBudgetToolStripMenuItem.Size = new Size(146, 22);
				editBudgetToolStripMenuItem.Text = "Edit Budget";
				// 
				// label3
				// 
				label3.AutoSize = true;
				label3.Font = new Font("Segoe UI", 12F);
				label3.Location = new Point(12, 199);
				label3.Name = "label3";
				label3.Size = new Size(66, 21);
				label3.TabIndex = 7;
				label3.Text = "Budgets";
				// 
				// btnToolStripDropDownButtonGoals
				// 
				btnToolStripDropDownButtonGoals.AutoSize = false;
				btnToolStripDropDownButtonGoals.BackColor = Color.Plum;
				btnToolStripDropDownButtonGoals.DisplayStyle = ToolStripItemDisplayStyle.Text;
				btnToolStripDropDownButtonGoals.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAddContribution, toolStripMenuItemRemoveContribution, toolStripMenuItemUpdateContribution, toolStripMenuItemAddGoal, toolStripMenuItemEditGoal, toolStripMenuItemDeleteGoal });
				btnToolStripDropDownButtonGoals.Image = (Image)resources.GetObject("btnToolStripDropDownButtonGoals.Image");
				btnToolStripDropDownButtonGoals.ImageTransparentColor = Color.Magenta;
				btnToolStripDropDownButtonGoals.Name = "btnToolStripDropDownButtonGoals";
				btnToolStripDropDownButtonGoals.Size = new Size(100, 22);
				btnToolStripDropDownButtonGoals.Text = "Goals";
				btnToolStripDropDownButtonGoals.Click += btnToolStripDropDownButtonGoals_Click;
				
				// 
				// toolStripMenuItemAddContribution
				// 
				toolStripMenuItemAddContribution.Name = "toolStripMenuItemAddContribution";
				toolStripMenuItemAddContribution.Size = new Size(188, 22);
				toolStripMenuItemAddContribution.Text = "Add Contribution";
				// 
				// toolStripMenuItemRemoveContribution
				// 
				toolStripMenuItemRemoveContribution.Name = "toolStripMenuItemRemoveContribution";
				toolStripMenuItemRemoveContribution.Size = new Size(188, 22);
				toolStripMenuItemRemoveContribution.Text = "Remove Contribution";
				// 
				// toolStripMenuItemUpdateContribution
				// 
				toolStripMenuItemUpdateContribution.Name = "toolStripMenuItemUpdateContribution";
				toolStripMenuItemUpdateContribution.Size = new Size(188, 22);
				toolStripMenuItemUpdateContribution.Text = "Update Contribution";
				// 
				// toolStripMenuItemAddGoal
				// 
				toolStripMenuItemAddGoal.Name = "toolStripMenuItemAddGoal";
				toolStripMenuItemAddGoal.Size = new Size(188, 22);
				toolStripMenuItemAddGoal.Text = "Add Goal";
				// 
				// toolStripMenuItemEditGoal
				// 
				toolStripMenuItemEditGoal.Name = "toolStripMenuItemEditGoal";
				toolStripMenuItemEditGoal.Size = new Size(188, 22);
				toolStripMenuItemEditGoal.Text = "Edit Goal";
				// 
				// toolStripMenuItemDeleteGoal
				// 
				toolStripMenuItemDeleteGoal.Name = "toolStripMenuItemDeleteGoal";
				toolStripMenuItemDeleteGoal.Size = new Size(188, 22);
				toolStripMenuItemDeleteGoal.Text = "Delete Goal";
				// 
				// Form1
				// 
				AutoScaleDimensions = new SizeF(7F, 15F);
				AutoScaleMode = AutoScaleMode.Font;
				BackColor = SystemColors.GradientInactiveCaption;
				ClientSize = new Size(998, 590);
				Controls.Add(label3);
				//Controls.Add(pictureBox1);
				Controls.Add(label2);
				Controls.Add(label1);
				Controls.Add(button1);
				Controls.Add(toolStrip1);
				Controls.Add(comboBudgets);
				Controls.Add(btnCreateBudget);
				FormBorderStyle = FormBorderStyle.FixedSingle;
				Name = "Form1";
				Text = "Form1";
				//((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
				toolStrip1.ResumeLayout(false);
				toolStrip1.PerformLayout();
				ResumeLayout(false);
				PerformLayout();
			}
*/