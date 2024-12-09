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
            lblUpdateIncome = new Label();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // btnEditIncome
            // 
            btnEditIncome.BackColor = Color.Plum;
            btnEditIncome.Location = new Point(257, 285);
            btnEditIncome.Margin = new Padding(3, 4, 3, 4);
            btnEditIncome.Name = "btnEditIncome";
            btnEditIncome.Size = new Size(86, 31);
            btnEditIncome.TabIndex = 11;
            btnEditIncome.Text = "Edit";
            btnEditIncome.UseVisualStyleBackColor = false;
            btnEditIncome.Click += btnEditIncome_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Plum;
            btnCancel.Location = new Point(14, 285);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 228);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 9;
            label2.Text = "Income Type:";
            // 
            // comboIncomeType
            // 
            comboIncomeType.FormattingEnabled = true;
            comboIncomeType.Location = new Point(167, 224);
            comboIncomeType.Margin = new Padding(3, 4, 3, 4);
            comboIncomeType.Name = "comboIncomeType";
            comboIncomeType.Size = new Size(175, 28);
            comboIncomeType.TabIndex = 8;
            comboIncomeType.Text = "Hourly";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 167);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 7;
            label1.Text = "Amount:";
            // 
            // numAmount
            // 
            numAmount.Location = new Point(167, 164);
            numAmount.Margin = new Padding(3, 4, 3, 4);
            numAmount.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(176, 27);
            numAmount.TabIndex = 6;
            numAmount.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 105);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 12;
            label3.Text = "Name:";
            // 
            // txtIncomeName
            // 
            txtIncomeName.Location = new Point(167, 101);
            txtIncomeName.Margin = new Padding(3, 4, 3, 4);
            txtIncomeName.Name = "txtIncomeName";
            txtIncomeName.Size = new Size(175, 27);
            txtIncomeName.TabIndex = 13;
            txtIncomeName.Text = "tom";
            // 
            // lblIncomeOutput
            // 
            lblIncomeOutput.AutoSize = true;
            lblIncomeOutput.ForeColor = SystemColors.ControlText;
            lblIncomeOutput.Location = new Point(14, 335);
            lblIncomeOutput.Name = "lblIncomeOutput";
            lblIncomeOutput.Size = new Size(0, 20);
            lblIncomeOutput.TabIndex = 14;
            // 
            // lblUpdateIncome
            // 
            lblUpdateIncome.Dock = DockStyle.Top;
            lblUpdateIncome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdateIncome.Location = new Point(0, 0);
            lblUpdateIncome.Name = "lblUpdateIncome";
            lblUpdateIncome.Size = new Size(391, 76);
            lblUpdateIncome.TabIndex = 15;
            lblUpdateIncome.Text = "Update Income";
            lblUpdateIncome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpdateIncome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(391, 379);
            Controls.Add(lblUpdateIncome);
            Controls.Add(lblIncomeOutput);
            Controls.Add(txtIncomeName);
            Controls.Add(label3);
            Controls.Add(btnEditIncome);
            Controls.Add(btnCancel);
            Controls.Add(label2);
            Controls.Add(comboIncomeType);
            Controls.Add(label1);
            Controls.Add(numAmount);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblUpdateIncome;
    }
}