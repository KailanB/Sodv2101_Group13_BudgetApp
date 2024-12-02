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
            cmbExpense = new ComboBox();
            lblBudget = new Label();
            lblUpdateExpense = new Label();
            ((System.ComponentModel.ISupportInitialize)numExpenseAmount).BeginInit();
            SuspendLayout();
            // 
            // lblExpenseName
            // 
            lblExpenseName.AutoSize = true;
            lblExpenseName.Location = new Point(25, 45);
            lblExpenseName.Name = "lblExpenseName";
            lblExpenseName.Size = new Size(52, 20);
            lblExpenseName.TabIndex = 0;
            lblExpenseName.Text = "Name:";
            // 
            // txtExpenseName
            // 
            txtExpenseName.Location = new Point(106, 39);
            txtExpenseName.Name = "txtExpenseName";
            txtExpenseName.Size = new Size(289, 27);
            txtExpenseName.TabIndex = 1;
            // 
            // numExpenseAmount
            // 
            numExpenseAmount.DecimalPlaces = 2;
            numExpenseAmount.Location = new Point(106, 97);
            numExpenseAmount.Margin = new Padding(3, 4, 3, 4);
            numExpenseAmount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numExpenseAmount.Name = "numExpenseAmount";
            numExpenseAmount.Size = new Size(182, 27);
            numExpenseAmount.TabIndex = 6;
            // 
            // lblExpenseAmount
            // 
            lblExpenseAmount.AutoSize = true;
            lblExpenseAmount.Location = new Point(25, 99);
            lblExpenseAmount.Name = "lblExpenseAmount";
            lblExpenseAmount.Size = new Size(65, 20);
            lblExpenseAmount.TabIndex = 7;
            lblExpenseAmount.Text = "Amount:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(27, 183);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(153, 183);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(181, 149);
            txtDescription.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(25, 392);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEditExpense
            // 
            btnEditExpense.Location = new Point(309, 392);
            btnEditExpense.Margin = new Padding(3, 4, 3, 4);
            btnEditExpense.Name = "btnEditExpense";
            btnEditExpense.Size = new Size(86, 31);
            btnEditExpense.TabIndex = 11;
            btnEditExpense.Text = "Edit";
            btnEditExpense.UseVisualStyleBackColor = true;
            btnEditExpense.Click += btnEditExpense_Click;
            // 
            // lblTimePeriod
            // 
            lblTimePeriod.AutoSize = true;
            lblTimePeriod.Location = new Point(27, 340);
            lblTimePeriod.Name = "lblTimePeriod";
            lblTimePeriod.Size = new Size(91, 20);
            lblTimePeriod.TabIndex = 12;
            lblTimePeriod.Text = "Time Period:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(153, 339);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // cmbExpense
            // 
            cmbExpense.FormattingEnabled = true;
            cmbExpense.Location = new Point(103, 141);
            cmbExpense.Name = "cmbExpense";
            cmbExpense.Size = new Size(292, 28);
            cmbExpense.TabIndex = 14;
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(27, 149);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(64, 20);
            lblBudget.TabIndex = 15;
            lblBudget.Text = "Budget: ";
            // 
            // lblUpdateExpense
            // 
            lblUpdateExpense.AutoSize = true;
            lblUpdateExpense.Location = new Point(25, 438);
            lblUpdateExpense.Name = "lblUpdateExpense";
            lblUpdateExpense.Size = new Size(0, 20);
            lblUpdateExpense.TabIndex = 16;
            // 
            // UpdateExpense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 476);
            Controls.Add(lblUpdateExpense);
            Controls.Add(lblBudget);
            Controls.Add(cmbExpense);
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
        private ComboBox cmbExpense;
        private Label lblBudget;
        private Label lblUpdateExpense;
    }
}