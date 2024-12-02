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
            ((System.ComponentModel.ISupportInitialize)numExpenseAmount).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(147, 331);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // lblTimePeriod
            // 
            lblTimePeriod.AutoSize = true;
            lblTimePeriod.Location = new Point(22, 332);
            lblTimePeriod.Name = "lblTimePeriod";
            lblTimePeriod.Size = new Size(91, 20);
            lblTimePeriod.TabIndex = 22;
            lblTimePeriod.Text = "Time Period:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(303, 384);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(19, 384);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            //btnCancel.Click += btnCancel_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(147, 175);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(181, 149);
            txtDescription.TabIndex = 19;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(22, 178);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 18;
            lblDescription.Text = "Description";
            // 
            // lblExpenseAmount
            // 
            lblExpenseAmount.AutoSize = true;
            lblExpenseAmount.Location = new Point(19, 91);
            lblExpenseAmount.Name = "lblExpenseAmount";
            lblExpenseAmount.Size = new Size(65, 20);
            lblExpenseAmount.TabIndex = 17;
            lblExpenseAmount.Text = "Amount:";
            // 
            // numExpenseAmount
            // 
            numExpenseAmount.DecimalPlaces = 2;
            numExpenseAmount.Location = new Point(101, 89);
            numExpenseAmount.Margin = new Padding(3, 4, 3, 4);
            numExpenseAmount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numExpenseAmount.Name = "numExpenseAmount";
            numExpenseAmount.Size = new Size(182, 27);
            numExpenseAmount.TabIndex = 16;
            // 
            // txtExpenseName
            // 
            txtExpenseName.Location = new Point(101, 31);
            txtExpenseName.Name = "txtExpenseName";
            txtExpenseName.Size = new Size(289, 27);
            txtExpenseName.TabIndex = 15;
            // 
            // lblExpenseName
            // 
            lblExpenseName.AutoSize = true;
            lblExpenseName.Location = new Point(19, 37);
            lblExpenseName.Name = "lblExpenseName";
            lblExpenseName.Size = new Size(52, 20);
            lblExpenseName.TabIndex = 14;
            lblExpenseName.Text = "Name:";
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(28, 139);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(60, 20);
            lblBudget.TabIndex = 24;
            lblBudget.Text = "Budget:";
            // 
            // cmbBudgetList
            // 
            cmbBudgetList.FormattingEnabled = true;
            cmbBudgetList.Location = new Point(106, 136);
            cmbBudgetList.Name = "cmbBudgetList";
            cmbBudgetList.Size = new Size(283, 28);
            cmbBudgetList.TabIndex = 25;
            // 
            // NewExpense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 449);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewExpense";
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
    }
}