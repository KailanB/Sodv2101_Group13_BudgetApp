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
            lblCreateIncome = new Label();
            ((System.ComponentModel.ISupportInitialize)numIncomeAmount).BeginInit();
            SuspendLayout();
            // 
            // numIncomeAmount
            // 
            numIncomeAmount.Location = new Point(155, 156);
            numIncomeAmount.Margin = new Padding(3, 4, 3, 4);
            numIncomeAmount.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numIncomeAmount.Name = "numIncomeAmount";
            numIncomeAmount.Size = new Size(173, 27);
            numIncomeAmount.TabIndex = 0;
            numIncomeAmount.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 159);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "Amount:";
            // 
            // comboIncomeType
            // 
            comboIncomeType.FormattingEnabled = true;
            comboIncomeType.Location = new Point(155, 213);
            comboIncomeType.Margin = new Padding(3, 4, 3, 4);
            comboIncomeType.Name = "comboIncomeType";
            comboIncomeType.Size = new Size(172, 28);
            comboIncomeType.TabIndex = 2;
            comboIncomeType.Text = "Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 217);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 3;
            label2.Text = "Income Type:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Plum;
            btnCancel.Location = new Point(17, 277);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddIncome
            // 
            btnAddIncome.BackColor = Color.Plum;
            btnAddIncome.Location = new Point(242, 277);
            btnAddIncome.Margin = new Padding(3, 4, 3, 4);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(86, 31);
            btnAddIncome.TabIndex = 5;
            btnAddIncome.Text = "Add";
            btnAddIncome.UseVisualStyleBackColor = false;
            btnAddIncome.Click += btnAddIncome_Click;
            // 
            // txtIncomeName
            // 
            txtIncomeName.Location = new Point(155, 101);
            txtIncomeName.Margin = new Padding(3, 4, 3, 4);
            txtIncomeName.Name = "txtIncomeName";
            txtIncomeName.Size = new Size(172, 27);
            txtIncomeName.TabIndex = 14;
            txtIncomeName.Text = "tom";
            txtIncomeName.TextChanged += txtIncomeName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 105);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 15;
            label3.Text = "Name:";
            // 
            // lblIncomeOutput
            // 
            lblIncomeOutput.AutoSize = true;
            lblIncomeOutput.Location = new Point(17, 332);
            lblIncomeOutput.Name = "lblIncomeOutput";
            lblIncomeOutput.Size = new Size(0, 20);
            lblIncomeOutput.TabIndex = 16;
            // 
            // lblCreateIncome
            // 
            lblCreateIncome.Dock = DockStyle.Top;
            lblCreateIncome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateIncome.Location = new Point(0, 0);
            lblCreateIncome.Name = "lblCreateIncome";
            lblCreateIncome.Size = new Size(369, 76);
            lblCreateIncome.TabIndex = 18;
            lblCreateIncome.Text = "Create Income";
            lblCreateIncome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateIncome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(369, 377);
            Controls.Add(lblCreateIncome);
            Controls.Add(lblIncomeOutput);
            Controls.Add(label3);
            Controls.Add(txtIncomeName);
            Controls.Add(btnAddIncome);
            Controls.Add(btnCancel);
            Controls.Add(label2);
            Controls.Add(comboIncomeType);
            Controls.Add(label1);
            Controls.Add(numIncomeAmount);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblCreateIncome;
    }
}