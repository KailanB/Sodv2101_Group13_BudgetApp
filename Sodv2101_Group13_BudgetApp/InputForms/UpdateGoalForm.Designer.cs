namespace Sodv2101_Group13_BudgetApp.InputForms
{
    partial class UpdateGoalForm
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
            lblEditGoalName = new Label();
            btnEditGoalSave = new Button();
            lblEditGoalDescription = new Label();
            lblEditGoalAmount = new Label();
            numEditGoalAmount = new NumericUpDown();
            txtBoxEditGoalDescription = new TextBox();
            lblUpdateGoalFormHeader = new Label();
            lblEditGoalDeadline = new Label();
            dateTimePickerEditGoalDeadline = new DateTimePicker();
            txtBoxEditGoalName = new TextBox();
            btnCancel = new Button();
            lblErrorOutput = new Label();
            ((System.ComponentModel.ISupportInitialize)numEditGoalAmount).BeginInit();
            SuspendLayout();
            // 
            // lblEditGoalName
            // 
            lblEditGoalName.AutoSize = true;
            lblEditGoalName.Location = new Point(12, 75);
            lblEditGoalName.Name = "lblEditGoalName";
            lblEditGoalName.Size = new Size(42, 15);
            lblEditGoalName.TabIndex = 0;
            lblEditGoalName.Text = "Name:";
            // 
            // btnEditGoalSave
            // 
            btnEditGoalSave.BackColor = Color.Plum;
            btnEditGoalSave.Location = new Point(219, 296);
            btnEditGoalSave.Name = "btnEditGoalSave";
            btnEditGoalSave.Size = new Size(84, 23);
            btnEditGoalSave.TabIndex = 2;
            btnEditGoalSave.Text = "Save";
            btnEditGoalSave.UseVisualStyleBackColor = false;
            btnEditGoalSave.Click += btnEditGoalSave_Click;
            // 
            // lblEditGoalDescription
            // 
            lblEditGoalDescription.AutoSize = true;
            lblEditGoalDescription.Location = new Point(12, 157);
            lblEditGoalDescription.Name = "lblEditGoalDescription";
            lblEditGoalDescription.Size = new Size(70, 15);
            lblEditGoalDescription.TabIndex = 4;
            lblEditGoalDescription.Text = "Description:";
            // 
            // lblEditGoalAmount
            // 
            lblEditGoalAmount.AutoSize = true;
            lblEditGoalAmount.Location = new Point(13, 113);
            lblEditGoalAmount.Name = "lblEditGoalAmount";
            lblEditGoalAmount.Size = new Size(81, 15);
            lblEditGoalAmount.TabIndex = 5;
            lblEditGoalAmount.Text = "Goal Amount:";
            // 
            // numEditGoalAmount
            // 
            numEditGoalAmount.Location = new Point(130, 111);
            numEditGoalAmount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numEditGoalAmount.Name = "numEditGoalAmount";
            numEditGoalAmount.Size = new Size(173, 23);
            numEditGoalAmount.TabIndex = 8;
            // 
            // txtBoxEditGoalDescription
            // 
            txtBoxEditGoalDescription.Location = new Point(130, 154);
            txtBoxEditGoalDescription.Multiline = true;
            txtBoxEditGoalDescription.Name = "txtBoxEditGoalDescription";
            txtBoxEditGoalDescription.Size = new Size(173, 77);
            txtBoxEditGoalDescription.TabIndex = 9;
            // 
            // lblUpdateGoalFormHeader
            // 
            lblUpdateGoalFormHeader.Dock = DockStyle.Top;
            lblUpdateGoalFormHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdateGoalFormHeader.Location = new Point(0, 0);
            lblUpdateGoalFormHeader.Name = "lblUpdateGoalFormHeader";
            lblUpdateGoalFormHeader.Size = new Size(338, 57);
            lblUpdateGoalFormHeader.TabIndex = 10;
            lblUpdateGoalFormHeader.Text = "Update Goal";
            lblUpdateGoalFormHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEditGoalDeadline
            // 
            lblEditGoalDeadline.AutoSize = true;
            lblEditGoalDeadline.Location = new Point(13, 253);
            lblEditGoalDeadline.Name = "lblEditGoalDeadline";
            lblEditGoalDeadline.Size = new Size(110, 15);
            lblEditGoalDeadline.TabIndex = 11;
            lblEditGoalDeadline.Text = "Deadline (Optional)";
            // 
            // dateTimePickerEditGoalDeadline
            // 
            dateTimePickerEditGoalDeadline.Location = new Point(130, 247);
            dateTimePickerEditGoalDeadline.Name = "dateTimePickerEditGoalDeadline";
            dateTimePickerEditGoalDeadline.Size = new Size(173, 23);
            dateTimePickerEditGoalDeadline.TabIndex = 12;
            // 
            // txtBoxEditGoalName
            // 
            txtBoxEditGoalName.Location = new Point(130, 72);
            txtBoxEditGoalName.Name = "txtBoxEditGoalName";
            txtBoxEditGoalName.Size = new Size(173, 23);
            txtBoxEditGoalName.TabIndex = 13;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Plum;
            btnCancel.Location = new Point(13, 296);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblErrorOutput
            // 
            lblErrorOutput.AutoSize = true;
            lblErrorOutput.ForeColor = SystemColors.ControlText;
            lblErrorOutput.Location = new Point(12, 332);
            lblErrorOutput.Name = "lblErrorOutput";
            lblErrorOutput.Size = new Size(0, 15);
            lblErrorOutput.TabIndex = 15;
            // 
            // UpdateGoalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(338, 375);
            Controls.Add(lblErrorOutput);
            Controls.Add(btnCancel);
            Controls.Add(txtBoxEditGoalName);
            Controls.Add(dateTimePickerEditGoalDeadline);
            Controls.Add(lblEditGoalDeadline);
            Controls.Add(lblUpdateGoalFormHeader);
            Controls.Add(txtBoxEditGoalDescription);
            Controls.Add(numEditGoalAmount);
            Controls.Add(lblEditGoalAmount);
            Controls.Add(lblEditGoalDescription);
            Controls.Add(btnEditGoalSave);
            Controls.Add(lblEditGoalName);
            Name = "UpdateGoalForm";
            Text = "UpdateGoalForm";
            ((System.ComponentModel.ISupportInitialize)numEditGoalAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEditGoalName;
        private Button btnEditGoalSave;
        private Label lblEditGoalDescription;
        private Label lblEditGoalAmount;
        private NumericUpDown numEditGoalAmount;
        private TextBox txtBoxEditGoalDescription;
        private Label lblUpdateGoalFormHeader;
        private Label lblEditGoalDeadline;
        private DateTimePicker dateTimePickerEditGoalDeadline;
        private TextBox txtBoxEditGoalName;
        private Button btnCancel;
        private Label lblErrorOutput;
    }
}