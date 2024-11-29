namespace Sodv2101_Group13_BudgetApp.InputForms
{
    partial class UpdateExpense
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
			lblExpenseName = new Label();
			txtExpenseName = new TextBox();
			numExpenseAmount = new NumericUpDown();
			lblExpenseAmount = new Label();
			lblDescription = new Label();
			txtDescription = new TextBox();
			btnCancel = new Button();
			btnEditExpense = new Button();
			lblTimePeriod = new Label();
			dateTimePicker1 = new DateTimePicker();
			((System.ComponentModel.ISupportInitialize)numExpenseAmount).BeginInit();
			SuspendLayout();
			// 
			// lblExpenseName
			// 
			lblExpenseName.AutoSize = true;
			lblExpenseName.Location = new Point(22, 34);
			lblExpenseName.Name = "lblExpenseName";
			lblExpenseName.Size = new Size(42, 15);
			lblExpenseName.TabIndex = 0;
			lblExpenseName.Text = "Name:";
			// 
			// txtExpenseName
			// 
			txtExpenseName.Location = new Point(93, 29);
			txtExpenseName.Margin = new Padding(3, 2, 3, 2);
			txtExpenseName.Name = "txtExpenseName";
			txtExpenseName.Size = new Size(253, 23);
			txtExpenseName.TabIndex = 1;
			// 
			// numExpenseAmount
			// 
			numExpenseAmount.DecimalPlaces = 2;
			numExpenseAmount.Location = new Point(93, 73);
			numExpenseAmount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
			numExpenseAmount.Name = "numExpenseAmount";
			numExpenseAmount.Size = new Size(159, 23);
			numExpenseAmount.TabIndex = 6;
			// 
			// lblExpenseAmount
			// 
			lblExpenseAmount.AutoSize = true;
			lblExpenseAmount.Location = new Point(22, 74);
			lblExpenseAmount.Name = "lblExpenseAmount";
			lblExpenseAmount.Size = new Size(54, 15);
			lblExpenseAmount.TabIndex = 7;
			lblExpenseAmount.Text = "Amount:";
			// 
			// lblDescription
			// 
			lblDescription.AutoSize = true;
			lblDescription.Location = new Point(22, 115);
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new Size(67, 15);
			lblDescription.TabIndex = 8;
			lblDescription.Text = "Description";
			// 
			// txtDescription
			// 
			txtDescription.Location = new Point(124, 113);
			txtDescription.Multiline = true;
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(159, 113);
			txtDescription.TabIndex = 9;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(22, 294);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 10;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnEditExpense
			// 
			btnEditExpense.Location = new Point(270, 294);
			btnEditExpense.Name = "btnEditExpense";
			btnEditExpense.Size = new Size(75, 23);
			btnEditExpense.TabIndex = 11;
			btnEditExpense.Text = "Edit";
			btnEditExpense.UseVisualStyleBackColor = true;
			btnEditExpense.Click += btnEditExpense_Click;
			// 
			// lblTimePeriod
			// 
			lblTimePeriod.AutoSize = true;
			lblTimePeriod.Location = new Point(24, 255);
			lblTimePeriod.Name = "lblTimePeriod";
			lblTimePeriod.Size = new Size(73, 15);
			lblTimePeriod.TabIndex = 12;
			lblTimePeriod.Text = "Time Period:";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(134, 254);
			dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(213, 23);
			dateTimePicker1.TabIndex = 13;
			// 
			// UpdateExpense
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(407, 338);
			Controls.Add(dateTimePicker1);
			Controls.Add(lblTimePeriod);
			Controls.Add(btnEditExpense);
			Controls.Add(btnCancel);
			Controls.Add(txtDescription);
			Controls.Add(lblDescription);
			Controls.Add(lblExpenseAmount);
			Controls.Add(numExpenseAmount);
			Controls.Add(txtExpenseName);
			Controls.Add(lblExpenseName);
			Margin = new Padding(3, 2, 3, 2);
			Name = "UpdateExpense";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "UpdateExpense";
			((System.ComponentModel.ISupportInitialize)numExpenseAmount).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblExpenseName;
        private TextBox txtExpenseName;
        private NumericUpDown numExpenseAmount;
        private Label lblExpenseAmount;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnCancel;
        private Button btnEditExpense;
        private Label lblTimePeriod;
        private DateTimePicker dateTimePicker1;
    }
}