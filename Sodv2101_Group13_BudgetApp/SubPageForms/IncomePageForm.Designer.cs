namespace Sodv2101_Group13_BudgetApp.SubPageForms
{
    partial class IncomePageForm
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
            dataGridViewIncome = new DataGridView();
            label1 = new Label();
            btnNewIncome = new Button();
            btnEditIncome = new Button();
            btnDeleteIncome = new Button();
            lblIncomeOutput = new Label();
            button1 = new Button();
            dataGridViewHours = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIncome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHours).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewIncome
            // 
            dataGridViewIncome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIncome.Location = new Point(19, 70);
            dataGridViewIncome.Name = "dataGridViewIncome";
            dataGridViewIncome.Size = new Size(335, 255);
            dataGridViewIncome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 52);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Incomes";
            // 
            // btnNewIncome
            // 
            btnNewIncome.BackColor = Color.Plum;
            btnNewIncome.Location = new Point(19, 331);
            btnNewIncome.Name = "btnNewIncome";
            btnNewIncome.Size = new Size(91, 23);
            btnNewIncome.TabIndex = 2;
            btnNewIncome.Text = "New Income";
            btnNewIncome.UseVisualStyleBackColor = false;
            btnNewIncome.Click += btnNewIncome_Click;
            // 
            // btnEditIncome
            // 
            btnEditIncome.BackColor = Color.Plum;
            btnEditIncome.Location = new Point(116, 331);
            btnEditIncome.Name = "btnEditIncome";
            btnEditIncome.Size = new Size(75, 23);
            btnEditIncome.TabIndex = 3;
            btnEditIncome.Text = "Edit";
            btnEditIncome.UseVisualStyleBackColor = false;
            btnEditIncome.Click += btnEditIncome_Click;
            // 
            // btnDeleteIncome
            // 
            btnDeleteIncome.BackColor = Color.Plum;
            btnDeleteIncome.Location = new Point(197, 331);
            btnDeleteIncome.Name = "btnDeleteIncome";
            btnDeleteIncome.Size = new Size(75, 23);
            btnDeleteIncome.TabIndex = 4;
            btnDeleteIncome.Text = "Delete";
            btnDeleteIncome.UseVisualStyleBackColor = false;
            btnDeleteIncome.Click += btnDeleteIncome_Click;
            // 
            // lblIncomeOutput
            // 
            lblIncomeOutput.AutoSize = true;
            lblIncomeOutput.Location = new Point(19, 367);
            lblIncomeOutput.Name = "lblIncomeOutput";
            lblIncomeOutput.Size = new Size(0, 15);
            lblIncomeOutput.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Plum;
            button1.Location = new Point(270, 41);
            button1.Name = "button1";
            button1.Size = new Size(84, 23);
            button1.TabIndex = 6;
            button1.Text = "View Hours";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewHours
            // 
            dataGridViewHours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHours.Location = new Point(389, 70);
            dataGridViewHours.Name = "dataGridViewHours";
            dataGridViewHours.Size = new Size(237, 255);
            dataGridViewHours.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 49);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 8;
            label2.Text = "Hours Worked";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(19, 9);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 9;
            label3.Text = "My Incomes";
            // 
            // IncomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(681, 414);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridViewHours);
            Controls.Add(button1);
            Controls.Add(lblIncomeOutput);
            Controls.Add(btnDeleteIncome);
            Controls.Add(btnEditIncome);
            Controls.Add(btnNewIncome);
            Controls.Add(label1);
            Controls.Add(dataGridViewIncome);
            Name = "IncomePageForm";
            Text = "IncomePageForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewIncome).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewIncome;
        private Label label1;
        private Button btnNewIncome;
        private Button btnEditIncome;
        private Button btnDeleteIncome;
        private Label lblIncomeOutput;
        private Button button1;
        private DataGridView dataGridViewHours;
        private Label label2;
        private Label label3;
    }
}