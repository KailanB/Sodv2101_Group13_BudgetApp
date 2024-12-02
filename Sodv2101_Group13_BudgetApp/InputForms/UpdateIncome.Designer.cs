namespace Sodv2101_Group13_BudgetApp.InputForms
{
    partial class UpdateIncome
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
            btnEditIncome = new Button();
            btnCancel = new Button();
            label2 = new Label();
            comboIncomeType = new ComboBox();
            label1 = new Label();
            numAmount = new NumericUpDown();
            label3 = new Label();
            txtIncomeName = new TextBox();
            lblIncomeOutput = new Label();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // btnEditIncome
            // 
            btnEditIncome.BackColor = Color.Plum;
            btnEditIncome.Location = new Point(235, 198);
            btnEditIncome.Name = "btnEditIncome";
            btnEditIncome.Size = new Size(75, 23);
            btnEditIncome.TabIndex = 11;
            btnEditIncome.Text = "Edit";
            btnEditIncome.UseVisualStyleBackColor = false;
            btnEditIncome.Click += btnEditIncome_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Plum;
            btnCancel.Location = new Point(20, 198);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 129);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 9;
            label2.Text = "Income Type:";
            // 
            // comboIncomeType
            // 
            comboIncomeType.FormattingEnabled = true;
            comboIncomeType.Location = new Point(141, 126);
            comboIncomeType.Name = "comboIncomeType";
            comboIncomeType.Size = new Size(121, 23);
            comboIncomeType.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 78);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "Amount:";
            // 
            // numAmount
            // 
            numAmount.Location = new Point(142, 76);
            numAmount.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(120, 23);
            numAmount.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 32);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 12;
            label3.Text = "Name:";
            // 
            // txtIncomeName
            // 
            txtIncomeName.Location = new Point(141, 29);
            txtIncomeName.Name = "txtIncomeName";
            txtIncomeName.Size = new Size(121, 23);
            txtIncomeName.TabIndex = 13;
            // 
            // lblIncomeOutput
            // 
            lblIncomeOutput.AutoSize = true;
            lblIncomeOutput.Location = new Point(20, 237);
            lblIncomeOutput.Name = "lblIncomeOutput";
            lblIncomeOutput.Size = new Size(0, 15);
            lblIncomeOutput.TabIndex = 14;
            // 
            // UpdateIncome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(342, 261);
            Controls.Add(lblIncomeOutput);
            Controls.Add(txtIncomeName);
            Controls.Add(label3);
            Controls.Add(btnEditIncome);
            Controls.Add(btnCancel);
            Controls.Add(label2);
            Controls.Add(comboIncomeType);
            Controls.Add(label1);
            Controls.Add(numAmount);
            Name = "UpdateIncome";
            Text = "UpdateIncome";
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditIncome;
        private Button btnCancel;
        private Label label2;
        private ComboBox comboIncomeType;
        private Label label1;
        private NumericUpDown numAmount;
        private Label label3;
        private TextBox txtIncomeName;
        private Label lblIncomeOutput;
    }
}