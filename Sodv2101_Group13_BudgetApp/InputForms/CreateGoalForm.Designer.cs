namespace Sodv2101_Group13_BudgetApp.InputForms
{
    partial class CreateGoalForm
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
            lblGoalName = new Label();
            numericUpDownAddGoalAmount = new NumericUpDown();
            txtBoxAddGoalDescription = new TextBox();
            txtBoxAddGoalName = new TextBox();
            btnSaveGoal = new Button();
            lblGoalAmount = new Label();
            lblGoalDescription = new Label();
            lblGoalDeadline = new Label();
            dateTimePickerAddGoalDeadline = new DateTimePicker();
            lblAddGoalHeader = new Label();
            lblErrorOutput = new Label();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddGoalAmount).BeginInit();
            SuspendLayout();
            // 
            // lblGoalName
            // 
            lblGoalName.AutoSize = true;
            lblGoalName.Location = new Point(12, 73);
            lblGoalName.Name = "lblGoalName";
            lblGoalName.Size = new Size(42, 15);
            lblGoalName.TabIndex = 0;
            lblGoalName.Text = "Name:";
            // 
            // numericUpDownAddGoalAmount
            // 
            numericUpDownAddGoalAmount.Location = new Point(135, 108);
            numericUpDownAddGoalAmount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownAddGoalAmount.Name = "numericUpDownAddGoalAmount";
            numericUpDownAddGoalAmount.Size = new Size(163, 23);
            numericUpDownAddGoalAmount.TabIndex = 1;
            // 
            // txtBoxAddGoalDescription
            // 
            txtBoxAddGoalDescription.Location = new Point(135, 147);
            txtBoxAddGoalDescription.Multiline = true;
            txtBoxAddGoalDescription.Name = "txtBoxAddGoalDescription";
            txtBoxAddGoalDescription.Size = new Size(163, 23);
            txtBoxAddGoalDescription.TabIndex = 2;
            // 
            // txtBoxAddGoalName
            // 
            txtBoxAddGoalName.Location = new Point(135, 70);
            txtBoxAddGoalName.Name = "txtBoxAddGoalName";
            txtBoxAddGoalName.Size = new Size(163, 23);
            txtBoxAddGoalName.TabIndex = 3;
            // 
            // btnSaveGoal
            // 
            btnSaveGoal.BackColor = Color.Plum;
            btnSaveGoal.Location = new Point(223, 234);
            btnSaveGoal.Name = "btnSaveGoal";
            btnSaveGoal.Size = new Size(75, 23);
            btnSaveGoal.TabIndex = 4;
            btnSaveGoal.Text = "Save";
            btnSaveGoal.UseVisualStyleBackColor = false;
            btnSaveGoal.Click += btnSaveGoal_Click;
            // 
            // lblGoalAmount
            // 
            lblGoalAmount.AutoSize = true;
            lblGoalAmount.Location = new Point(12, 110);
            lblGoalAmount.Name = "lblGoalAmount";
            lblGoalAmount.Size = new Size(54, 15);
            lblGoalAmount.TabIndex = 5;
            lblGoalAmount.Text = "Amount:";
            // 
            // lblGoalDescription
            // 
            lblGoalDescription.AutoSize = true;
            lblGoalDescription.Location = new Point(12, 150);
            lblGoalDescription.Name = "lblGoalDescription";
            lblGoalDescription.Size = new Size(70, 15);
            lblGoalDescription.TabIndex = 6;
            lblGoalDescription.Text = "Description:";
            // 
            // lblGoalDeadline
            // 
            lblGoalDeadline.AutoSize = true;
            lblGoalDeadline.Location = new Point(12, 193);
            lblGoalDeadline.Name = "lblGoalDeadline";
            lblGoalDeadline.Size = new Size(110, 15);
            lblGoalDeadline.TabIndex = 7;
            lblGoalDeadline.Text = "Deadline (Optional)";
            // 
            // dateTimePickerAddGoalDeadline
            // 
            dateTimePickerAddGoalDeadline.Location = new Point(135, 187);
            dateTimePickerAddGoalDeadline.Name = "dateTimePickerAddGoalDeadline";
            dateTimePickerAddGoalDeadline.Size = new Size(163, 23);
            dateTimePickerAddGoalDeadline.TabIndex = 10;
            // 
            // lblAddGoalHeader
            // 
            lblAddGoalHeader.Dock = DockStyle.Top;
            lblAddGoalHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddGoalHeader.Location = new Point(0, 0);
            lblAddGoalHeader.Name = "lblAddGoalHeader";
            lblAddGoalHeader.Size = new Size(349, 58);
            lblAddGoalHeader.TabIndex = 11;
            lblAddGoalHeader.Text = "Create Goal";
            lblAddGoalHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblErrorOutput
            // 
            lblErrorOutput.AutoSize = true;
            lblErrorOutput.ForeColor = Color.Red;
            lblErrorOutput.Location = new Point(12, 273);
            lblErrorOutput.Name = "lblErrorOutput";
            lblErrorOutput.Size = new Size(0, 15);
            lblErrorOutput.TabIndex = 12;
            lblErrorOutput.TextChanged += lblAddGoalErrorMessage_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Plum;
            btnCancel.Location = new Point(12, 234);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateGoalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(349, 311);
            Controls.Add(btnCancel);
            Controls.Add(lblErrorOutput);
            Controls.Add(lblAddGoalHeader);
            Controls.Add(dateTimePickerAddGoalDeadline);
            Controls.Add(lblGoalDeadline);
            Controls.Add(lblGoalDescription);
            Controls.Add(lblGoalAmount);
            Controls.Add(btnSaveGoal);
            Controls.Add(txtBoxAddGoalName);
            Controls.Add(txtBoxAddGoalDescription);
            Controls.Add(numericUpDownAddGoalAmount);
            Controls.Add(lblGoalName);
            Name = "CreateGoalForm";
            Text = "CreateGoal";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddGoalAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGoalName;
        private NumericUpDown numericUpDownAddGoalAmount;
        private TextBox txtBoxAddGoalDescription;
        private TextBox txtBoxAddGoalName;
        private Button btnSaveGoal;
        private Label lblGoalAmount;
        private Label lblGoalDescription;
        private Label lblGoalDeadline;
        private DateTimePicker dateTimePickerAddGoalDeadline;
        private Label lblAddGoalHeader;
        private Label lblErrorOutput;
        private Button btnCancel;
    }
}