namespace Sodv2101_Group13_BudgetApp.InputForms
{
    partial class UpdateContribution
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
            comboBoxUpdateContribution = new ComboBox();
            btnUpdateContributionSave = new Button();
            dateTimePickerUpdateContribution = new DateTimePicker();
            txtBoxUpdateContributionDescription = new TextBox();
            numUpdateContributionAmount = new NumericUpDown();
            lblUpdateContributionDate = new Label();
            lblUpdateContributionDescription = new Label();
            lblUpdateContributionAmount = new Label();
            lblUpdateContributionName = new Label();
            lblUpdateOutput = new Label();
            btnCancel = new Button();
            lblUpdateContribution = new Label();
            ((System.ComponentModel.ISupportInitialize)numUpdateContributionAmount).BeginInit();
            SuspendLayout();
            // 
            // comboBoxUpdateContribution
            // 
            comboBoxUpdateContribution.FormattingEnabled = true;
            comboBoxUpdateContribution.Location = new Point(125, 75);
            comboBoxUpdateContribution.Name = "comboBoxUpdateContribution";
            comboBoxUpdateContribution.Size = new Size(183, 23);
            comboBoxUpdateContribution.TabIndex = 29;
            // 
            // btnUpdateContributionSave
            // 
            btnUpdateContributionSave.BackColor = Color.Plum;
            btnUpdateContributionSave.Location = new Point(233, 254);
            btnUpdateContributionSave.Name = "btnUpdateContributionSave";
            btnUpdateContributionSave.Size = new Size(75, 23);
            btnUpdateContributionSave.TabIndex = 28;
            btnUpdateContributionSave.Text = "Update";
            btnUpdateContributionSave.UseVisualStyleBackColor = false;
            btnUpdateContributionSave.Click += btnUpdateContributionSave_Click;
            // 
            // dateTimePickerUpdateContribution
            // 
            dateTimePickerUpdateContribution.Location = new Point(125, 205);
            dateTimePickerUpdateContribution.Name = "dateTimePickerUpdateContribution";
            dateTimePickerUpdateContribution.Size = new Size(183, 23);
            dateTimePickerUpdateContribution.TabIndex = 27;
            // 
            // txtBoxUpdateContributionDescription
            // 
            txtBoxUpdateContributionDescription.Location = new Point(125, 162);
            txtBoxUpdateContributionDescription.Name = "txtBoxUpdateContributionDescription";
            txtBoxUpdateContributionDescription.Size = new Size(183, 23);
            txtBoxUpdateContributionDescription.TabIndex = 26;
            // 
            // numUpdateContributionAmount
            // 
            numUpdateContributionAmount.Location = new Point(125, 118);
            numUpdateContributionAmount.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numUpdateContributionAmount.Name = "numUpdateContributionAmount";
            numUpdateContributionAmount.Size = new Size(180, 23);
            numUpdateContributionAmount.TabIndex = 25;
            // 
            // lblUpdateContributionDate
            // 
            lblUpdateContributionDate.AutoSize = true;
            lblUpdateContributionDate.Location = new Point(22, 211);
            lblUpdateContributionDate.Name = "lblUpdateContributionDate";
            lblUpdateContributionDate.Size = new Size(34, 15);
            lblUpdateContributionDate.TabIndex = 24;
            lblUpdateContributionDate.Text = "Date:";
            // 
            // lblUpdateContributionDescription
            // 
            lblUpdateContributionDescription.AutoSize = true;
            lblUpdateContributionDescription.Location = new Point(22, 165);
            lblUpdateContributionDescription.Name = "lblUpdateContributionDescription";
            lblUpdateContributionDescription.Size = new Size(70, 15);
            lblUpdateContributionDescription.TabIndex = 23;
            lblUpdateContributionDescription.Text = "Description:";
            // 
            // lblUpdateContributionAmount
            // 
            lblUpdateContributionAmount.AutoSize = true;
            lblUpdateContributionAmount.Location = new Point(22, 120);
            lblUpdateContributionAmount.Name = "lblUpdateContributionAmount";
            lblUpdateContributionAmount.Size = new Size(54, 15);
            lblUpdateContributionAmount.TabIndex = 22;
            lblUpdateContributionAmount.Text = "Amount:";
            // 
            // lblUpdateContributionName
            // 
            lblUpdateContributionName.AutoSize = true;
            lblUpdateContributionName.Location = new Point(22, 78);
            lblUpdateContributionName.Name = "lblUpdateContributionName";
            lblUpdateContributionName.Size = new Size(42, 15);
            lblUpdateContributionName.TabIndex = 21;
            lblUpdateContributionName.Text = "Name:";
            // 
            // lblUpdateOutput
            // 
            lblUpdateOutput.AutoSize = true;
            lblUpdateOutput.Location = new Point(22, 298);
            lblUpdateOutput.Name = "lblUpdateOutput";
            lblUpdateOutput.Size = new Size(0, 15);
            lblUpdateOutput.TabIndex = 31;
            lblUpdateOutput.TextChanged += lblUpdateContributionError_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Plum;
            btnCancel.Location = new Point(22, 254);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblUpdateContribution
            // 
            lblUpdateContribution.Dock = DockStyle.Top;
            lblUpdateContribution.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdateContribution.Location = new Point(0, 0);
            lblUpdateContribution.Name = "lblUpdateContribution";
            lblUpdateContribution.Size = new Size(345, 57);
            lblUpdateContribution.TabIndex = 33;
            lblUpdateContribution.Text = "Update Contribution";
            lblUpdateContribution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpdateContribution
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(345, 328);
            Controls.Add(lblUpdateContribution);
            Controls.Add(btnCancel);
            Controls.Add(lblUpdateOutput);
            Controls.Add(comboBoxUpdateContribution);
            Controls.Add(btnUpdateContributionSave);
            Controls.Add(dateTimePickerUpdateContribution);
            Controls.Add(txtBoxUpdateContributionDescription);
            Controls.Add(numUpdateContributionAmount);
            Controls.Add(lblUpdateContributionDate);
            Controls.Add(lblUpdateContributionDescription);
            Controls.Add(lblUpdateContributionAmount);
            Controls.Add(lblUpdateContributionName);
            Name = "UpdateContribution";
            Text = "UpdateContribution";
            ((System.ComponentModel.ISupportInitialize)numUpdateContributionAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxUpdateContribution;
        private Button btnUpdateContributionSave;
        private DateTimePicker dateTimePickerUpdateContribution;
        private TextBox txtBoxUpdateContributionDescription;
        private NumericUpDown numUpdateContributionAmount;
        private Label lblUpdateContributionDate;
        private Label lblUpdateContributionDescription;
        private Label lblUpdateContributionAmount;
        private Label lblUpdateContributionName;
        private Label lblUpdateOutput;
        private Button btnCancel;
        private Label lblUpdateContribution;
    }
}