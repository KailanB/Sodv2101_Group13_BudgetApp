namespace Sodv2101_Group13_BudgetApp
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
			// toolStrip1
			// 
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator2, btnToolStripBudget, toolStripSeparator1, btnToolStripIncome, toolStripSeparator3, btnToolStripGoals, toolStripSeparator4, btnToolStripReports });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(930, 25);
			toolStrip1.TabIndex = 2;
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
			toolStripDropDownButton1.Size = new Size(69, 22);
			toolStripDropDownButton1.Text = "Add New";
			// 
			// toolBtnAddExpense
			// 
			toolBtnAddExpense.Name = "toolBtnAddExpense";
			toolBtnAddExpense.Size = new Size(180, 22);
			toolBtnAddExpense.Text = "Add Expense";
			toolBtnAddExpense.Click += toolBtnAddExpense_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 25);
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
			toolStripSeparator1.Size = new Size(6, 25);
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
			toolStripSeparator3.Size = new Size(6, 25);
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
			toolStripSeparator4.Size = new Size(6, 25);
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
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(930, 475);
			Controls.Add(toolStrip1);
			Controls.Add(comboBudgets);
			Controls.Add(btnCreateBudget);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "Form1";
			Text = "Form1";
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCreateBudget;
        private ComboBox comboBudgets;
		private ToolStrip toolStrip1;
		private ToolStripDropDownButton toolStripDropDownButton1;
		private ToolStripButton btnToolStripBudget;
		private ToolStripButton btnToolStripIncome;
		private ToolStripMenuItem toolBtnAddExpense;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripButton btnToolStripGoals;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripButton btnToolStripReports;
	}
}
