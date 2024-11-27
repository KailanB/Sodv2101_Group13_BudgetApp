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
            txtBudgetDescription = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            lblTimePeriod = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numExpenseAmount).BeginInit();
            SuspendLayout();
            // 
            // lblExpenseName
            // 
            lblExpenseName.AutoSize = true;
            lblExpenseName.Location = new Point(25, 46);
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
            lblDescription.Location = new Point(25, 153);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description";
            // 
            // txtBudgetDescription
            // 
            txtBudgetDescription.Location = new Point(142, 151);
            txtBudgetDescription.Margin = new Padding(3, 4, 3, 4);
            txtBudgetDescription.Multiline = true;
            txtBudgetDescription.Name = "txtBudgetDescription";
            txtBudgetDescription.Size = new Size(181, 149);
            txtBudgetDescription.TabIndex = 9;
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
            // btnSave
            // 
            btnSave.Location = new Point(309, 392);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
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
            dateTimePicker1.Location = new Point(153, 338);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // UpdateExpense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 450);
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
        private TextBox txtBudgetDescription;
        private Button btnCancel;
        private Button btnSave;
        private Label lblTimePeriod;
        private DateTimePicker dateTimePicker1;
    }
}