namespace Sodv2101_Group13_BudgetApp.InputForms
{
	partial class CreateExpense
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
            dateTimePicker1 = new DateTimePicker();
            lblTimePeriod = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtDescription = new TextBox();
            lblDescription = new Label();
            lblExpenseAmount = new Label();
            numExpenseAmount = new NumericUpDown();
            txtExpenseName = new TextBox();
            lblExpenseName = new Label();
            lblBudget = new Label();
            cmbBudgetList = new ComboBox();
            lblExpenseOutput = new Label();
            lblCreateExpenseHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)numExpenseAmount).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(139, 281);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(166, 23);
            dateTimePicker1.TabIndex = 23;
            // 
            // lblTimePeriod
            // 
            lblTimePeriod.AutoSize = true;
            lblTimePeriod.Location = new Point(12, 287);
            lblTimePeriod.Name = "lblTimePeriod";
            lblTimePeriod.Size = new Size(73, 15);
            lblTimePeriod.TabIndex = 22;
            lblTimePeriod.Text = "Time Period:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Plum;
            btnSave.Location = new Point(230, 323);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Plum;
            btnCancel.Location = new Point(12, 323);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(99, 184);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(206, 83);
            txtDescription.TabIndex = 19;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 187);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 18;
            lblDescription.Text = "Description";
            // 
            // lblExpenseAmount
            // 
            lblExpenseAmount.AutoSize = true;
            lblExpenseAmount.Location = new Point(12, 113);
            lblExpenseAmount.Name = "lblExpenseAmount";
            lblExpenseAmount.Size = new Size(54, 15);
            lblExpenseAmount.TabIndex = 17;
            lblExpenseAmount.Text = "Amount:";
            // 
            // numExpenseAmount
            // 
            numExpenseAmount.DecimalPlaces = 2;
            numExpenseAmount.Location = new Point(99, 111);
            numExpenseAmount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numExpenseAmount.Name = "numExpenseAmount";
            numExpenseAmount.Size = new Size(159, 23);
            numExpenseAmount.TabIndex = 16;
            // 
            // txtExpenseName
            // 
            txtExpenseName.Location = new Point(99, 73);
            txtExpenseName.Margin = new Padding(3, 2, 3, 2);
            txtExpenseName.Name = "txtExpenseName";
            txtExpenseName.Size = new Size(206, 23);
            txtExpenseName.TabIndex = 15;
            // 
            // lblExpenseName
            // 
            lblExpenseName.AutoSize = true;
            lblExpenseName.Location = new Point(12, 76);
            lblExpenseName.Name = "lblExpenseName";
            lblExpenseName.Size = new Size(42, 15);
            lblExpenseName.TabIndex = 14;
            lblExpenseName.Text = "Name:";
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(12, 149);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(48, 15);
            lblBudget.TabIndex = 24;
            lblBudget.Text = "Budget:";
            // 
            // cmbBudgetList
            // 
            cmbBudgetList.FormattingEnabled = true;
            cmbBudgetList.Location = new Point(99, 146);
            cmbBudgetList.Margin = new Padding(3, 2, 3, 2);
            cmbBudgetList.Name = "cmbBudgetList";
            cmbBudgetList.Size = new Size(206, 23);
            cmbBudgetList.TabIndex = 25;
            // 
            // lblExpenseOutput
            // 
            lblExpenseOutput.AutoSize = true;
            lblExpenseOutput.Location = new Point(12, 361);
            lblExpenseOutput.Name = "lblExpenseOutput";
            lblExpenseOutput.Size = new Size(0, 15);
            lblExpenseOutput.TabIndex = 26;
            // 
            // lblCreateExpenseHeader
            // 
            lblCreateExpenseHeader.Dock = DockStyle.Top;
            lblCreateExpenseHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateExpenseHeader.Location = new Point(0, 0);
            lblCreateExpenseHeader.Name = "lblCreateExpenseHeader";
            lblCreateExpenseHeader.Size = new Size(343, 57);
            lblCreateExpenseHeader.TabIndex = 27;
            lblCreateExpenseHeader.Text = "Create Expense";
            lblCreateExpenseHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(343, 393);
            Controls.Add(lblCreateExpenseHeader);
            Controls.Add(lblExpenseOutput);
            Controls.Add(cmbBudgetList);
            Controls.Add(lblBudget);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblTimePeriod);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblExpenseAmount);
            Controls.Add(numExpenseAmount);
            Controls.Add(txtExpenseName);
            Controls.Add(lblExpenseName);
            Name = "CreateExpense";
            Text = "NewExpense";
            ((System.ComponentModel.ISupportInitialize)numExpenseAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
		private Label lblTimePeriod;
		private Button btnSave;
		private Button btnCancel;
		private TextBox txtDescription;
		private Label lblDescription;
		private Label lblExpenseAmount;
		private NumericUpDown numExpenseAmount;
		private TextBox txtExpenseName;
		private Label lblExpenseName;
        private Label lblBudget;
        private ComboBox cmbBudgetList;
        private Label lblExpenseOutput;
        private Label lblCreateExpenseHeader;
    }
}