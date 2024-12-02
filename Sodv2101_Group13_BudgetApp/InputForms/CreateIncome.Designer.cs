namespace Sodv2101_Group13_BudgetApp.InputForms
{
    partial class CreateIncome
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
            numIncomeAmount = new NumericUpDown();
            label1 = new Label();
            comboIncomeType = new ComboBox();
            label2 = new Label();
            btnCancel = new Button();
            btnAddIncome = new Button();
            txtIncomeName = new TextBox();
            label3 = new Label();
            lblIncomeOutput = new Label();
            ((System.ComponentModel.ISupportInitialize)numIncomeAmount).BeginInit();
            SuspendLayout();
            // 
            // numIncomeAmount
            // 
            numIncomeAmount.Location = new Point(138, 79);
            numIncomeAmount.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numIncomeAmount.Name = "numIncomeAmount";
            numIncomeAmount.Size = new Size(120, 23);
            numIncomeAmount.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 81);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Amount:";
            // 
            // comboIncomeType
            // 
            comboIncomeType.FormattingEnabled = true;
            comboIncomeType.Location = new Point(137, 129);
            comboIncomeType.Name = "comboIncomeType";
            comboIncomeType.Size = new Size(121, 23);
            comboIncomeType.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 132);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 3;
            label2.Text = "Income Type:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Plum;
            btnCancel.Location = new Point(16, 201);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddIncome
            // 
            btnAddIncome.BackColor = Color.Plum;
            btnAddIncome.Location = new Point(231, 201);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(75, 23);
            btnAddIncome.TabIndex = 5;
            btnAddIncome.Text = "Add";
            btnAddIncome.UseVisualStyleBackColor = false;
            btnAddIncome.Click += btnAddIncome_Click;
            // 
            // txtIncomeName
            // 
            txtIncomeName.Location = new Point(138, 30);
            txtIncomeName.Name = "txtIncomeName";
            txtIncomeName.Size = new Size(121, 23);
            txtIncomeName.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 30);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 15;
            label3.Text = "Name:";
            // 
            // lblIncomeOutput
            // 
            lblIncomeOutput.AutoSize = true;
            lblIncomeOutput.Location = new Point(16, 245);
            lblIncomeOutput.Name = "lblIncomeOutput";
            lblIncomeOutput.Size = new Size(0, 15);
            lblIncomeOutput.TabIndex = 16;
            // 
            // CreateIncome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(340, 269);
            Controls.Add(lblIncomeOutput);
            Controls.Add(label3);
            Controls.Add(txtIncomeName);
            Controls.Add(btnAddIncome);
            Controls.Add(btnCancel);
            Controls.Add(label2);
            Controls.Add(comboIncomeType);
            Controls.Add(label1);
            Controls.Add(numIncomeAmount);
            Name = "CreateIncome";
            Text = "CreateIncome";
            ((System.ComponentModel.ISupportInitialize)numIncomeAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numIncomeAmount;
        private Label label1;
        private ComboBox comboIncomeType;
        private Label label2;
        private Button btnCancel;
        private Button btnAddIncome;
        private TextBox txtIncomeName;
        private Label label3;
        private Label lblIncomeOutput;
    }
}