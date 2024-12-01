namespace Sodv2101_Group13_BudgetApp.InputForms
{
    partial class EditGoalForm
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
            lblEditGoalFormHeader = new Label();
            lblEditGoalDeadline = new Label();
            dateTimePickerEditGoalDeadline = new DateTimePicker();
            txtBoxEditGoalName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numEditGoalAmount).BeginInit();
            SuspendLayout();
            // 
            // lblEditGoalName
            // 
            lblEditGoalName.AutoSize = true;
            lblEditGoalName.Location = new Point(24, 79);
            lblEditGoalName.Name = "lblEditGoalName";
            lblEditGoalName.Size = new Size(39, 15);
            lblEditGoalName.TabIndex = 0;
            lblEditGoalName.Text = "Name";
            // 
            // btnEditGoalSave
            // 
<<<<<<< Updated upstream
            btnEditGoalSave.Location = new Point(105, 373);
=======
            btnEditGoalSave.Location = new Point(100, 343);
>>>>>>> Stashed changes
            btnEditGoalSave.Name = "btnEditGoalSave";
            btnEditGoalSave.Size = new Size(146, 36);
            btnEditGoalSave.TabIndex = 2;
            btnEditGoalSave.Text = "Save";
            btnEditGoalSave.UseVisualStyleBackColor = true;
            btnEditGoalSave.Click += btnEditGoalSave_Click;
            // 
            // lblEditGoalDescription
            // 
            lblEditGoalDescription.AutoSize = true;
            lblEditGoalDescription.Location = new Point(24, 179);
            lblEditGoalDescription.Name = "lblEditGoalDescription";
            lblEditGoalDescription.Size = new Size(67, 15);
            lblEditGoalDescription.TabIndex = 4;
            lblEditGoalDescription.Text = "Description";
            // 
            // lblEditGoalAmount
            // 
            lblEditGoalAmount.AutoSize = true;
            lblEditGoalAmount.Location = new Point(12, 131);
            lblEditGoalAmount.Name = "lblEditGoalAmount";
            lblEditGoalAmount.Size = new Size(105, 15);
            lblEditGoalAmount.TabIndex = 5;
            lblEditGoalAmount.Text = "New Goal Amount";
            // 
            // numEditGoalAmount
            // 
            numEditGoalAmount.Location = new Point(162, 129);
            numEditGoalAmount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numEditGoalAmount.Name = "numEditGoalAmount";
            numEditGoalAmount.Size = new Size(197, 23);
            numEditGoalAmount.TabIndex = 8;
            numEditGoalAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxEditGoalDescription
            // 
            txtBoxEditGoalDescription.Location = new Point(162, 179);
            txtBoxEditGoalDescription.Multiline = true;
            txtBoxEditGoalDescription.Name = "txtBoxEditGoalDescription";
            txtBoxEditGoalDescription.Size = new Size(197, 77);
            txtBoxEditGoalDescription.TabIndex = 9;
            // 
            // lblEditGoalFormHeader
            // 
            lblEditGoalFormHeader.Dock = DockStyle.Top;
            lblEditGoalFormHeader.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditGoalFormHeader.Location = new Point(0, 0);
            lblEditGoalFormHeader.Name = "lblEditGoalFormHeader";
            lblEditGoalFormHeader.Size = new Size(397, 57);
            lblEditGoalFormHeader.TabIndex = 10;
            lblEditGoalFormHeader.Text = "Edit Goal";
            lblEditGoalFormHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEditGoalDeadline
            // 
            lblEditGoalDeadline.AutoSize = true;
            lblEditGoalDeadline.Location = new Point(12, 286);
            lblEditGoalDeadline.Name = "lblEditGoalDeadline";
            lblEditGoalDeadline.Size = new Size(110, 15);
            lblEditGoalDeadline.TabIndex = 11;
            lblEditGoalDeadline.Text = "Deadline (Optional)";
            // 
            // dateTimePickerEditGoalDeadline
            // 
            dateTimePickerEditGoalDeadline.Location = new Point(162, 280);
            dateTimePickerEditGoalDeadline.Name = "dateTimePickerEditGoalDeadline";
            dateTimePickerEditGoalDeadline.Size = new Size(200, 23);
            dateTimePickerEditGoalDeadline.TabIndex = 12;
            // 
            // txtBoxEditGoalName
            // 
            txtBoxEditGoalName.Location = new Point(162, 72);
            txtBoxEditGoalName.Name = "txtBoxEditGoalName";
            txtBoxEditGoalName.Size = new Size(197, 23);
            txtBoxEditGoalName.TabIndex = 13;
            // 
            // EditGoalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 421);
            Controls.Add(txtBoxEditGoalName);
            Controls.Add(dateTimePickerEditGoalDeadline);
            Controls.Add(lblEditGoalDeadline);
            Controls.Add(lblEditGoalFormHeader);
            Controls.Add(txtBoxEditGoalDescription);
            Controls.Add(numEditGoalAmount);
            Controls.Add(lblEditGoalAmount);
            Controls.Add(lblEditGoalDescription);
            Controls.Add(btnEditGoalSave);
            Controls.Add(lblEditGoalName);
            Name = "EditGoalForm";
            Text = "EditGoalForm";
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
        private Label lblEditGoalFormHeader;
        private Label lblEditGoalDeadline;
        private DateTimePicker dateTimePickerEditGoalDeadline;
        private TextBox txtBoxEditGoalName;
    }
}