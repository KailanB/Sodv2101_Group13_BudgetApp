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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
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
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            createBudgetToolStripMenuItem = new ToolStripMenuItem();
            editBudgetToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateBudget
            // 
            btnCreateBudget.Location = new Point(685, 109);
            btnCreateBudget.Margin = new Padding(3, 4, 3, 4);
            btnCreateBudget.Name = "btnCreateBudget";
            btnCreateBudget.Size = new Size(121, 31);
            btnCreateBudget.TabIndex = 0;
            btnCreateBudget.Text = "Create Budget";
            btnCreateBudget.UseVisualStyleBackColor = true;
            btnCreateBudget.Click += btnCreateBudget_Click;
            // 
            // comboBudgets
            // 
            comboBudgets.FormattingEnabled = true;
            comboBudgets.Location = new Point(667, 196);
            comboBudgets.Margin = new Padding(3, 4, 3, 4);
            comboBudgets.Name = "comboBudgets";
            comboBudgets.Size = new Size(138, 28);
            comboBudgets.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(857, 300);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(14, 49);
            label1.Name = "label1";
            label1.Size = new Size(360, 37);
            label1.TabIndex = 4;
            label1.Text = "Welcome to the Budget App!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(14, 179);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 5;
            label2.Text = "Monthly Income:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(122, 300);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 203);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
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
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator2, toolStripDropDownButton2, btnToolStripBudget, toolStripSeparator1, btnToolStripIncome, toolStripSeparator3, btnToolStripGoals, toolStripSeparator4, btnToolStripReports });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1141, 27);
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
            toolStripDropDownButton2.Size = new Size(34, 24);
            toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // createBudgetToolStripMenuItem
            // 
            createBudgetToolStripMenuItem.Name = "createBudgetToolStripMenuItem";
            createBudgetToolStripMenuItem.Size = new Size(183, 26);
            createBudgetToolStripMenuItem.Text = "CreateBudget";
            // 
            // editBudgetToolStripMenuItem
            // 
            editBudgetToolStripMenuItem.Name = "editBudgetToolStripMenuItem";
            editBudgetToolStripMenuItem.Size = new Size(183, 26);
            editBudgetToolStripMenuItem.Text = "Edit Budget";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(14, 265);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 7;
            label3.Text = "Budgets";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1141, 787);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(toolStrip1);
            Controls.Add(comboBudgets);
            Controls.Add(btnCreateBudget);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateBudget;
        private ComboBox comboBudgets;
        private Button button1;
		private Label label1;
		private Label label2;
		private PictureBox pictureBox1;
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
		private ToolStrip toolStrip1;
		private Label label3;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem createBudgetToolStripMenuItem;
        private ToolStripMenuItem editBudgetToolStripMenuItem;
    }
}
