namespace Sodv2101_Group13_BudgetApp.InputForms
{
    partial class CreateContribution
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
            lblAddContributionName = new Label();
            lblAddContributionAmount = new Label();
            lblAddContributionDescription = new Label();
            lblAddContributionDate = new Label();
            numAddContributionAmount = new NumericUpDown();
            txtBoxAddContributionDescription = new TextBox();
            dateTimePickerAddContribution = new DateTimePicker();
            btnAddContributionSave = new Button();
            comboBoxAddContribution = new ComboBox();
            btnCancel = new Button();
            lblCreateContribution = new Label();
            lblCreateOutput = new Label();
            ((System.ComponentModel.ISupportInitialize)numAddContributionAmount).BeginInit();
            SuspendLayout();
            // 
            // lblAddContributionName
            // 
            lblAddContributionName.AutoSize = true;
            lblAddContributionName.Location = new Point(12, 66);
            lblAddContributionName.Name = "lblAddContributionName";
            lblAddContributionName.Size = new Size(42, 15);
            lblAddContributionName.TabIndex = 0;
            lblAddContributionName.Text = "Name:";
            // 
            // lblAddContributionAmount
            // 
            lblAddContributionAmount.AutoSize = true;
            lblAddContributionAmount.Location = new Point(12, 105);
            lblAddContributionAmount.Name = "lblAddContributionAmount";
            lblAddContributionAmount.Size = new Size(54, 15);
            lblAddContributionAmount.TabIndex = 1;
            lblAddContributionAmount.Text = "Amount:";
            // 
            // lblAddContributionDescription
            // 
            lblAddContributionDescription.AutoSize = true;
            lblAddContributionDescription.Location = new Point(12, 146);
            lblAddContributionDescription.Name = "lblAddContributionDescription";
            lblAddContributionDescription.Size = new Size(70, 15);
            lblAddContributionDescription.TabIndex = 2;
            lblAddContributionDescription.Text = "Description:";
            // 
            // lblAddContributionDate
            // 
            lblAddContributionDate.AutoSize = true;
            lblAddContributionDate.Location = new Point(12, 227);
            lblAddContributionDate.Name = "lblAddContributionDate";
            lblAddContributionDate.Size = new Size(34, 15);
            lblAddContributionDate.TabIndex = 3;
            lblAddContributionDate.Text = "Date:";
            // 
            // numAddContributionAmount
            // 
            numAddContributionAmount.Location = new Point(123, 103);
            numAddContributionAmount.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numAddContributionAmount.Name = "numAddContributionAmount";
            numAddContributionAmount.Size = new Size(183, 23);
            numAddContributionAmount.TabIndex = 5;
            // 
            // txtBoxAddContributionDescription
            // 
            txtBoxAddContributionDescription.Location = new Point(123, 143);
            txtBoxAddContributionDescription.Multiline = true;
            txtBoxAddContributionDescription.Name = "txtBoxAddContributionDescription";
            txtBoxAddContributionDescription.Size = new Size(183, 59);
            txtBoxAddContributionDescription.TabIndex = 6;
            // 
            // dateTimePickerAddContribution
            // 
            dateTimePickerAddContribution.Location = new Point(123, 221);
            dateTimePickerAddContribution.Name = "dateTimePickerAddContribution";
            dateTimePickerAddContribution.Size = new Size(183, 23);
            dateTimePickerAddContribution.TabIndex = 7;
            // 
            // btnAddContributionSave
            // 
            btnAddContributionSave.BackColor = Color.Plum;
            btnAddContributionSave.Location = new Point(231, 263);
            btnAddContributionSave.Name = "btnAddContributionSave";
            btnAddContributionSave.Size = new Size(75, 23);
            btnAddContributionSave.TabIndex = 8;
            btnAddContributionSave.Text = "Save";
            btnAddContributionSave.UseVisualStyleBackColor = false;
            btnAddContributionSave.Click += btnAddContributionSave_Click;
            // 
            // comboBoxAddContribution
            // 
            comboBoxAddContribution.FormattingEnabled = true;
            comboBoxAddContribution.Location = new Point(123, 63);
            comboBoxAddContribution.Name = "comboBoxAddContribution";
            comboBoxAddContribution.Size = new Size(183, 23);
            comboBoxAddContribution.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Plum;
            btnCancel.Location = new Point(20, 263);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblCreateContribution
            // 
            lblCreateContribution.Dock = DockStyle.Top;
            lblCreateContribution.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateContribution.Location = new Point(0, 0);
            lblCreateContribution.Name = "lblCreateContribution";
            lblCreateContribution.Size = new Size(340, 57);
            lblCreateContribution.TabIndex = 19;
            lblCreateContribution.Text = "Create Contribution";
            lblCreateContribution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCreateOutput
            // 
            lblCreateOutput.AutoSize = true;
            lblCreateOutput.Location = new Point(12, 306);
            lblCreateOutput.Name = "lblCreateOutput";
            lblCreateOutput.Size = new Size(0, 15);
            lblCreateOutput.TabIndex = 20;
            // 
            // CreateContribution
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(340, 330);
            Controls.Add(lblCreateOutput);
            Controls.Add(lblCreateContribution);
            Controls.Add(btnCancel);
            Controls.Add(comboBoxAddContribution);
            Controls.Add(btnAddContributionSave);
            Controls.Add(dateTimePickerAddContribution);
            Controls.Add(txtBoxAddContributionDescription);
            Controls.Add(numAddContributionAmount);
            Controls.Add(lblAddContributionDate);
            Controls.Add(lblAddContributionDescription);
            Controls.Add(lblAddContributionAmount);
            Controls.Add(lblAddContributionName);
            Name = "CreateContribution";
            Text = "CreateContribution";
            ((System.ComponentModel.ISupportInitialize)numAddContributionAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddContributionName;
        private Label lblAddContributionAmount;
        private Label lblAddContributionDescription;
        private Label lblAddContributionDate;
        private NumericUpDown numAddContributionAmount;
        private TextBox txtBoxAddContributionDescription;
        private DateTimePicker dateTimePickerAddContribution;
        private Button btnAddContributionSave;
        private ComboBox comboBoxAddContribution;
        private Button btnCancel;
        private Label lblCreateContribution;
        private Label lblCreateOutput;
    }
}