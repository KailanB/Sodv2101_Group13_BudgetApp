namespace Sodv2101_Group13_BudgetApp.InputForms
{
    partial class AddContribution
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
            lblAddContributionHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)numAddContributionAmount).BeginInit();
            SuspendLayout();
            // 
            // lblAddContributionName
            // 
            lblAddContributionName.AutoSize = true;
            lblAddContributionName.Location = new Point(20, 66);
            lblAddContributionName.Name = "lblAddContributionName";
            lblAddContributionName.Size = new Size(39, 15);
            lblAddContributionName.TabIndex = 0;
            lblAddContributionName.Text = "Name";
            // 
            // lblAddContributionAmount
            // 
            lblAddContributionAmount.AutoSize = true;
            lblAddContributionAmount.Location = new Point(20, 130);
            lblAddContributionAmount.Name = "lblAddContributionAmount";
            lblAddContributionAmount.Size = new Size(51, 15);
            lblAddContributionAmount.TabIndex = 1;
            lblAddContributionAmount.Text = "Amount";
            // 
            // lblAddContributionDescription
            // 
            lblAddContributionDescription.AutoSize = true;
            lblAddContributionDescription.Location = new Point(20, 184);
            lblAddContributionDescription.Name = "lblAddContributionDescription";
            lblAddContributionDescription.Size = new Size(67, 15);
            lblAddContributionDescription.TabIndex = 2;
            lblAddContributionDescription.Text = "Description";
            // 
            // lblAddContributionDate
            // 
            lblAddContributionDate.AutoSize = true;
            lblAddContributionDate.Location = new Point(28, 276);
            lblAddContributionDate.Name = "lblAddContributionDate";
            lblAddContributionDate.Size = new Size(31, 15);
            lblAddContributionDate.TabIndex = 3;
            lblAddContributionDate.Text = "Date";
            // 
            // numAddContributionAmount
            // 
            numAddContributionAmount.Location = new Point(123, 128);
            numAddContributionAmount.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numAddContributionAmount.Name = "numAddContributionAmount";
            numAddContributionAmount.Size = new Size(180, 23);
            numAddContributionAmount.TabIndex = 5;
            // 
            // txtBoxAddContributionDescription
            // 
            txtBoxAddContributionDescription.Location = new Point(123, 181);
            txtBoxAddContributionDescription.Name = "txtBoxAddContributionDescription";
            txtBoxAddContributionDescription.Size = new Size(183, 23);
            txtBoxAddContributionDescription.TabIndex = 6;
            // 
            // dateTimePickerAddContribution
            // 
            dateTimePickerAddContribution.Location = new Point(123, 270);
            dateTimePickerAddContribution.Name = "dateTimePickerAddContribution";
            dateTimePickerAddContribution.Size = new Size(183, 23);
            dateTimePickerAddContribution.TabIndex = 7;
            // 
            // btnAddContributionSave
            // 
            btnAddContributionSave.Location = new Point(119, 339);
            btnAddContributionSave.Name = "btnAddContributionSave";
            btnAddContributionSave.Size = new Size(142, 23);
            btnAddContributionSave.TabIndex = 8;
            btnAddContributionSave.Text = "Save";
            btnAddContributionSave.UseVisualStyleBackColor = true;
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
            // lblAddContributionHeader
            // 
            lblAddContributionHeader.Dock = DockStyle.Top;
            lblAddContributionHeader.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAddContributionHeader.Location = new Point(0, 0);
            lblAddContributionHeader.Name = "lblAddContributionHeader";
            lblAddContributionHeader.Size = new Size(410, 46);
            lblAddContributionHeader.TabIndex = 10;
            lblAddContributionHeader.Text = "Add Contribution";
            lblAddContributionHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblAddContributionHeader.Visible = false;
            // 
            // AddContribution
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 450);
            Controls.Add(lblAddContributionHeader);
            Controls.Add(comboBoxAddContribution);
            Controls.Add(btnAddContributionSave);
            Controls.Add(dateTimePickerAddContribution);
            Controls.Add(txtBoxAddContributionDescription);
            Controls.Add(numAddContributionAmount);
            Controls.Add(lblAddContributionDate);
            Controls.Add(lblAddContributionDescription);
            Controls.Add(lblAddContributionAmount);
            Controls.Add(lblAddContributionName);
            Name = "AddContribution";
            Text = "AddContribution";
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
        private Label lblAddContributionHeader;
    }
}