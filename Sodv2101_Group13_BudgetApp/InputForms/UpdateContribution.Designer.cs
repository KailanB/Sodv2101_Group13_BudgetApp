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
            lblUpdateContributionHeader = new Label();
            comboBoxUpdateContribution = new ComboBox();
            btnUpdateContributionSave = new Button();
            dateTimePickerUpdateContribution = new DateTimePicker();
            txtBoxUpdateContributionDescription = new TextBox();
            numUpdateContributionAmount = new NumericUpDown();
            lblUpdateContributionDate = new Label();
            lblUpdateContributionDescription = new Label();
            lblUpdateContributionAmount = new Label();
            lblUpdateContributionName = new Label();
            lblUpdateContributionError = new Label();
            ((System.ComponentModel.ISupportInitialize)numUpdateContributionAmount).BeginInit();
            SuspendLayout();
            // 
            // lblUpdateContributionHeader
            // 
            lblUpdateContributionHeader.Dock = DockStyle.Top;
            lblUpdateContributionHeader.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUpdateContributionHeader.Location = new Point(0, 0);
            lblUpdateContributionHeader.Name = "lblUpdateContributionHeader";
            lblUpdateContributionHeader.Size = new Size(383, 46);
            lblUpdateContributionHeader.TabIndex = 30;
            lblUpdateContributionHeader.Text = "Update Contribution";
            lblUpdateContributionHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblUpdateContributionHeader.Visible = false;
            // 
            // comboBoxUpdateContribution
            // 
            comboBoxUpdateContribution.FormattingEnabled = true;
            comboBoxUpdateContribution.Location = new Point(125, 91);
            comboBoxUpdateContribution.Name = "comboBoxUpdateContribution";
            comboBoxUpdateContribution.Size = new Size(183, 23);
            comboBoxUpdateContribution.TabIndex = 29;
            comboBoxUpdateContribution.SelectedIndexChanged += comboBoxUpdateContribution_SelectedIndexChanged;
            // 
            // btnUpdateContributionSave
            // 
            btnUpdateContributionSave.Location = new Point(121, 364);
            btnUpdateContributionSave.Name = "btnUpdateContributionSave";
            btnUpdateContributionSave.Size = new Size(142, 23);
            btnUpdateContributionSave.TabIndex = 28;
            btnUpdateContributionSave.Text = "Update";
            btnUpdateContributionSave.UseVisualStyleBackColor = true;
            btnUpdateContributionSave.Click += btnUpdateContributionSave_Click;
            // 
            // dateTimePickerUpdateContribution
            // 
            dateTimePickerUpdateContribution.Location = new Point(125, 295);
            dateTimePickerUpdateContribution.Name = "dateTimePickerUpdateContribution";
            dateTimePickerUpdateContribution.Size = new Size(183, 23);
            dateTimePickerUpdateContribution.TabIndex = 27;
            // 
            // txtBoxUpdateContributionDescription
            // 
            txtBoxUpdateContributionDescription.Location = new Point(125, 206);
            txtBoxUpdateContributionDescription.Name = "txtBoxUpdateContributionDescription";
            txtBoxUpdateContributionDescription.Size = new Size(183, 23);
            txtBoxUpdateContributionDescription.TabIndex = 26;
            // 
            // numUpdateContributionAmount
            // 
            numUpdateContributionAmount.Location = new Point(125, 153);
            numUpdateContributionAmount.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numUpdateContributionAmount.Name = "numUpdateContributionAmount";
            numUpdateContributionAmount.Size = new Size(180, 23);
            numUpdateContributionAmount.TabIndex = 25;
            // 
            // lblUpdateContributionDate
            // 
            lblUpdateContributionDate.AutoSize = true;
            lblUpdateContributionDate.Location = new Point(30, 301);
            lblUpdateContributionDate.Name = "lblUpdateContributionDate";
            lblUpdateContributionDate.Size = new Size(31, 15);
            lblUpdateContributionDate.TabIndex = 24;
            lblUpdateContributionDate.Text = "Date";
            // 
            // lblUpdateContributionDescription
            // 
            lblUpdateContributionDescription.AutoSize = true;
            lblUpdateContributionDescription.Location = new Point(22, 209);
            lblUpdateContributionDescription.Name = "lblUpdateContributionDescription";
            lblUpdateContributionDescription.Size = new Size(67, 15);
            lblUpdateContributionDescription.TabIndex = 23;
            lblUpdateContributionDescription.Text = "Description";
            // 
            // lblUpdateContributionAmount
            // 
            lblUpdateContributionAmount.AutoSize = true;
            lblUpdateContributionAmount.Location = new Point(22, 155);
            lblUpdateContributionAmount.Name = "lblUpdateContributionAmount";
            lblUpdateContributionAmount.Size = new Size(51, 15);
            lblUpdateContributionAmount.TabIndex = 22;
            lblUpdateContributionAmount.Text = "Amount";
            // 
            // lblUpdateContributionName
            // 
            lblUpdateContributionName.AutoSize = true;
            lblUpdateContributionName.Location = new Point(22, 91);
            lblUpdateContributionName.Name = "lblUpdateContributionName";
            lblUpdateContributionName.Size = new Size(39, 15);
            lblUpdateContributionName.TabIndex = 21;
            lblUpdateContributionName.Text = "Name";
            // 
            // lblUpdateContributionError
            // 
            lblUpdateContributionError.AutoSize = true;
            lblUpdateContributionError.Location = new Point(22, 408);
            lblUpdateContributionError.Name = "lblUpdateContributionError";
            lblUpdateContributionError.Size = new Size(0, 15);
            lblUpdateContributionError.TabIndex = 31;
            lblUpdateContributionError.TextChanged += lblUpdateContributionError_TextChanged;
            // 
            // UpdateContribution
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 450);
            Controls.Add(lblUpdateContributionError);
            Controls.Add(lblUpdateContributionHeader);
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

        private Label lblUpdateContributionHeader;
        private ComboBox comboBoxUpdateContribution;
        private Button btnUpdateContributionSave;
        private DateTimePicker dateTimePickerUpdateContribution;
        private TextBox txtBoxUpdateContributionDescription;
        private NumericUpDown numUpdateContributionAmount;
        private Label lblUpdateContributionDate;
        private Label lblUpdateContributionDescription;
        private Label lblUpdateContributionAmount;
        private Label lblUpdateContributionName;
        private Label lblUpdateContributionError;
    }
}