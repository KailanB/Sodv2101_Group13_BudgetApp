namespace Sodv2101_Group13_BudgetApp.InputForms
{
    partial class RemoveContribution
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
            comboBoxRemoveContribution = new ComboBox();
            btnRemoveContributionSave = new Button();
            dateTimePickerRemoveContribution = new DateTimePicker();
            txtBoxRemoveContributionDescription = new TextBox();
            numRemoveContributionAmount = new NumericUpDown();
            lblRemoveContributionDate = new Label();
            lblRemoveContributionDescription = new Label();
            lblRemoveContributionAmount = new Label();
            lblRemoveContributionName = new Label();
            btnCancel = new Button();
            lblUpdateContribution = new Label();
            ((System.ComponentModel.ISupportInitialize)numRemoveContributionAmount).BeginInit();
            SuspendLayout();
            // 
            // comboBoxRemoveContribution
            // 
            comboBoxRemoveContribution.FormattingEnabled = true;
            comboBoxRemoveContribution.Location = new Point(142, 107);
            comboBoxRemoveContribution.Name = "comboBoxRemoveContribution";
            comboBoxRemoveContribution.Size = new Size(183, 23);
            comboBoxRemoveContribution.TabIndex = 19;
            comboBoxRemoveContribution.SelectedIndexChanged += comboBoxRemoveContribution_SelectedIndexChanged;
            // 
            // btnRemoveContributionSave
            // 
            btnRemoveContributionSave.BackColor = Color.Plum;
            btnRemoveContributionSave.Location = new Point(250, 383);
            btnRemoveContributionSave.Name = "btnRemoveContributionSave";
            btnRemoveContributionSave.Size = new Size(78, 23);
            btnRemoveContributionSave.TabIndex = 18;
            btnRemoveContributionSave.Text = "Delete";
            btnRemoveContributionSave.UseVisualStyleBackColor = false;
            btnRemoveContributionSave.Click += btnRemoveContributionSave_Click;
            // 
            // dateTimePickerRemoveContribution
            // 
            dateTimePickerRemoveContribution.Location = new Point(145, 314);
            dateTimePickerRemoveContribution.Name = "dateTimePickerRemoveContribution";
            dateTimePickerRemoveContribution.Size = new Size(183, 23);
            dateTimePickerRemoveContribution.TabIndex = 17;
            // 
            // txtBoxRemoveContributionDescription
            // 
            txtBoxRemoveContributionDescription.Location = new Point(145, 225);
            txtBoxRemoveContributionDescription.Name = "txtBoxRemoveContributionDescription";
            txtBoxRemoveContributionDescription.Size = new Size(183, 23);
            txtBoxRemoveContributionDescription.TabIndex = 16;
            // 
            // numRemoveContributionAmount
            // 
            numRemoveContributionAmount.Location = new Point(145, 172);
            numRemoveContributionAmount.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numRemoveContributionAmount.Name = "numRemoveContributionAmount";
            numRemoveContributionAmount.Size = new Size(180, 23);
            numRemoveContributionAmount.TabIndex = 15;
            // 
            // lblRemoveContributionDate
            // 
            lblRemoveContributionDate.AutoSize = true;
            lblRemoveContributionDate.Location = new Point(28, 320);
            lblRemoveContributionDate.Name = "lblRemoveContributionDate";
            lblRemoveContributionDate.Size = new Size(31, 15);
            lblRemoveContributionDate.TabIndex = 14;
            lblRemoveContributionDate.Text = "Date";
            // 
            // lblRemoveContributionDescription
            // 
            lblRemoveContributionDescription.AutoSize = true;
            lblRemoveContributionDescription.Location = new Point(20, 228);
            lblRemoveContributionDescription.Name = "lblRemoveContributionDescription";
            lblRemoveContributionDescription.Size = new Size(67, 15);
            lblRemoveContributionDescription.TabIndex = 13;
            lblRemoveContributionDescription.Text = "Description";
            // 
            // lblRemoveContributionAmount
            // 
            lblRemoveContributionAmount.AutoSize = true;
            lblRemoveContributionAmount.Location = new Point(20, 174);
            lblRemoveContributionAmount.Name = "lblRemoveContributionAmount";
            lblRemoveContributionAmount.Size = new Size(51, 15);
            lblRemoveContributionAmount.TabIndex = 12;
            lblRemoveContributionAmount.Text = "Amount";
            // 
            // lblRemoveContributionName
            // 
            lblRemoveContributionName.AutoSize = true;
            lblRemoveContributionName.Location = new Point(20, 110);
            lblRemoveContributionName.Name = "lblRemoveContributionName";
            lblRemoveContributionName.Size = new Size(39, 15);
            lblRemoveContributionName.TabIndex = 11;
            lblRemoveContributionName.Text = "Name";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Plum;
            btnCancel.Location = new Point(20, 383);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 21;
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
            lblUpdateContribution.Size = new Size(376, 57);
            lblUpdateContribution.TabIndex = 35;
            lblUpdateContribution.Text = "Delete Contribution";
            lblUpdateContribution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RemoveContribution
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(376, 450);
            Controls.Add(lblUpdateContribution);
            Controls.Add(btnCancel);
            Controls.Add(comboBoxRemoveContribution);
            Controls.Add(btnRemoveContributionSave);
            Controls.Add(dateTimePickerRemoveContribution);
            Controls.Add(txtBoxRemoveContributionDescription);
            Controls.Add(numRemoveContributionAmount);
            Controls.Add(lblRemoveContributionDate);
            Controls.Add(lblRemoveContributionDescription);
            Controls.Add(lblRemoveContributionAmount);
            Controls.Add(lblRemoveContributionName);
            Name = "RemoveContribution";
            Text = "RemoveContribution";
            ((System.ComponentModel.ISupportInitialize)numRemoveContributionAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxRemoveContribution;
        private Button btnRemoveContributionSave;
        private DateTimePicker dateTimePickerRemoveContribution;
        private TextBox txtBoxRemoveContributionDescription;
        private NumericUpDown numRemoveContributionAmount;
        private Label lblRemoveContributionDate;
        private Label lblRemoveContributionDescription;
        private Label lblRemoveContributionAmount;
        private Label lblRemoveContributionName;
        private Button btnCancel;
        private Label lblUpdateContribution;
    }
}