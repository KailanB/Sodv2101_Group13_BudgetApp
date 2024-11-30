namespace Sodv2101_Group13_BudgetApp.InputForms
{
    partial class AddGoalForm
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
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnSaveGoal = new Button();
            lblGoalAmount = new Label();
            lblGoalDescription = new Label();
            lblGoalDeadline = new Label();
            btnUpdateGoal = new Button();
            btnDeleteGoal = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblAddGoalHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblGoalName
            // 
            lblGoalName.AutoSize = true;
            lblGoalName.Location = new Point(38, 74);
            lblGoalName.Name = "lblGoalName";
            lblGoalName.Size = new Size(39, 15);
            lblGoalName.TabIndex = 0;
            lblGoalName.Text = "Name";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(170, 121);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(200, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 175);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 3;
            // 
            // btnSaveGoal
            // 
            btnSaveGoal.Location = new Point(47, 332);
            btnSaveGoal.Name = "btnSaveGoal";
            btnSaveGoal.Size = new Size(75, 23);
            btnSaveGoal.TabIndex = 4;
            btnSaveGoal.Text = "Save";
            btnSaveGoal.UseVisualStyleBackColor = true;
            // 
            // lblGoalAmount
            // 
            lblGoalAmount.AutoSize = true;
            lblGoalAmount.Location = new Point(38, 123);
            lblGoalAmount.Name = "lblGoalAmount";
            lblGoalAmount.Size = new Size(51, 15);
            lblGoalAmount.TabIndex = 5;
            lblGoalAmount.Text = "Amount";
            // 
            // lblGoalDescription
            // 
            lblGoalDescription.AutoSize = true;
            lblGoalDescription.Location = new Point(38, 178);
            lblGoalDescription.Name = "lblGoalDescription";
            lblGoalDescription.Size = new Size(67, 15);
            lblGoalDescription.TabIndex = 6;
            lblGoalDescription.Text = "Description";
            // 
            // lblGoalDeadline
            // 
            lblGoalDeadline.AutoSize = true;
            lblGoalDeadline.Location = new Point(38, 241);
            lblGoalDeadline.Name = "lblGoalDeadline";
            lblGoalDeadline.Size = new Size(110, 15);
            lblGoalDeadline.TabIndex = 7;
            lblGoalDeadline.Text = "Deadline (Optional)";
            // 
            // btnUpdateGoal
            // 
            btnUpdateGoal.Location = new Point(187, 332);
            btnUpdateGoal.Name = "btnUpdateGoal";
            btnUpdateGoal.Size = new Size(93, 23);
            btnUpdateGoal.TabIndex = 8;
            btnUpdateGoal.Text = "Update Goal";
            btnUpdateGoal.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGoal
            // 
            btnDeleteGoal.Location = new Point(358, 332);
            btnDeleteGoal.Name = "btnDeleteGoal";
            btnDeleteGoal.Size = new Size(75, 23);
            btnDeleteGoal.TabIndex = 9;
            btnDeleteGoal.Text = "Delete ";
            btnDeleteGoal.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(170, 235);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // lblAddGoalHeader
            // 
            lblAddGoalHeader.Dock = DockStyle.Top;
            lblAddGoalHeader.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddGoalHeader.Location = new Point(0, 0);
            lblAddGoalHeader.Name = "lblAddGoalHeader";
            lblAddGoalHeader.Size = new Size(491, 58);
            lblAddGoalHeader.TabIndex = 11;
            lblAddGoalHeader.Text = "Add Goal";
            lblAddGoalHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddGoal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 450);
            Controls.Add(lblAddGoalHeader);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnDeleteGoal);
            Controls.Add(btnUpdateGoal);
            Controls.Add(lblGoalDeadline);
            Controls.Add(lblGoalDescription);
            Controls.Add(lblGoalAmount);
            Controls.Add(btnSaveGoal);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(lblGoalName);
            Name = "AddGoal";
            Text = "AddGoal";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGoalName;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnSaveGoal;
        private Label lblGoalAmount;
        private Label lblGoalDescription;
        private Label lblGoalDeadline;
        private Button btnUpdateGoal;
        private Button btnDeleteGoal;
        private DateTimePicker dateTimePicker1;
        private Label lblAddGoalHeader;
    }
}