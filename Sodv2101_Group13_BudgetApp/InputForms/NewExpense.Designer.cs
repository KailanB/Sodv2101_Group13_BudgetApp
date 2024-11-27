namespace Sodv2101_Group13_BudgetApp.InputForms
{
	partial class NewExpense
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
			txtBudgetDescription = new TextBox();
			lblDescription = new Label();
			lblExpenseAmount = new Label();
			numExpenseAmount = new NumericUpDown();
			txtExpenseName = new TextBox();
			lblExpenseName = new Label();
			((System.ComponentModel.ISupportInitialize)numExpenseAmount).BeginInit();
			SuspendLayout();
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(129, 248);
			dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(213, 23);
			dateTimePicker1.TabIndex = 23;
			// 
			// lblTimePeriod
			// 
			lblTimePeriod.AutoSize = true;
			lblTimePeriod.Location = new Point(19, 249);
			lblTimePeriod.Name = "lblTimePeriod";
			lblTimePeriod.Size = new Size(73, 15);
			lblTimePeriod.TabIndex = 22;
			lblTimePeriod.Text = "Time Period:";
			// 
			// btnSave
			// 
			btnSave.Location = new Point(265, 288);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(75, 23);
			btnSave.TabIndex = 21;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(17, 288);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 20;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// txtBudgetDescription
			// 
			txtBudgetDescription.Location = new Point(119, 107);
			txtBudgetDescription.Multiline = true;
			txtBudgetDescription.Name = "txtBudgetDescription";
			txtBudgetDescription.Size = new Size(159, 113);
			txtBudgetDescription.TabIndex = 19;
			// 
			// lblDescription
			// 
			lblDescription.AutoSize = true;
			lblDescription.Location = new Point(17, 109);
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new Size(67, 15);
			lblDescription.TabIndex = 18;
			lblDescription.Text = "Description";
			// 
			// lblExpenseAmount
			// 
			lblExpenseAmount.AutoSize = true;
			lblExpenseAmount.Location = new Point(17, 68);
			lblExpenseAmount.Name = "lblExpenseAmount";
			lblExpenseAmount.Size = new Size(54, 15);
			lblExpenseAmount.TabIndex = 17;
			lblExpenseAmount.Text = "Amount:";
			// 
			// numExpenseAmount
			// 
			numExpenseAmount.DecimalPlaces = 2;
			numExpenseAmount.Location = new Point(88, 67);
			numExpenseAmount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
			numExpenseAmount.Name = "numExpenseAmount";
			numExpenseAmount.Size = new Size(159, 23);
			numExpenseAmount.TabIndex = 16;
			// 
			// txtExpenseName
			// 
			txtExpenseName.Location = new Point(88, 23);
			txtExpenseName.Margin = new Padding(3, 2, 3, 2);
			txtExpenseName.Name = "txtExpenseName";
			txtExpenseName.Size = new Size(253, 23);
			txtExpenseName.TabIndex = 15;
			// 
			// lblExpenseName
			// 
			lblExpenseName.AutoSize = true;
			lblExpenseName.Location = new Point(17, 28);
			lblExpenseName.Name = "lblExpenseName";
			lblExpenseName.Size = new Size(42, 15);
			lblExpenseName.TabIndex = 14;
			lblExpenseName.Text = "Name:";
			// 
			// NewExpense
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(397, 337);
			Controls.Add(dateTimePicker1);
			Controls.Add(lblTimePeriod);
			Controls.Add(btnSave);
			Controls.Add(btnCancel);
			Controls.Add(txtBudgetDescription);
			Controls.Add(lblDescription);
			Controls.Add(lblExpenseAmount);
			Controls.Add(numExpenseAmount);
			Controls.Add(txtExpenseName);
			Controls.Add(lblExpenseName);
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
		private TextBox txtBudgetDescription;
		private Label lblDescription;
		private Label lblExpenseAmount;
		private NumericUpDown numExpenseAmount;
		private TextBox txtExpenseName;
		private Label lblExpenseName;
	}
}