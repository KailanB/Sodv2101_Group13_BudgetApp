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
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnEGFSave = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            lblEditGoalFormHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 80);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // comboBox1
            // 
            btnEditGoalSave.Location = new Point(105, 373);
            btnEditGoalSave.Name = "btnEditGoalSave";
            btnEditGoalSave.Size = new Size(146, 36);
            btnEditGoalSave.TabIndex = 2;
            btnEditGoalSave.Text = "Save";
            btnEditGoalSave.UseVisualStyleBackColor = true;
            btnEditGoalSave.Click += btnEditGoalSave_Click;
            // 
            // btnEGFSave
            // 
            btnEGFSave.Location = new Point(145, 326);
            btnEGFSave.Name = "btnEGFSave";
            btnEGFSave.Size = new Size(146, 36);
            btnEGFSave.TabIndex = 2;
            btnEGFSave.Text = "Save";
            btnEGFSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 143);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "Goal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 209);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 266);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 5;
            label4.Text = "New Goal Amount";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(206, 143);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(197, 23);
            comboBox2.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(206, 264);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(197, 23);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 201);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 9;
            // 
            // lblEditGoalFormHeader
            // 
            lblEditGoalFormHeader.Dock = DockStyle.Top;
            lblEditGoalFormHeader.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditGoalFormHeader.Location = new Point(0, 0);
            lblEditGoalFormHeader.Name = "lblEditGoalFormHeader";
            lblEditGoalFormHeader.Size = new Size(492, 57);
            lblEditGoalFormHeader.TabIndex = 10;
            lblEditGoalFormHeader.Text = "Edit Goal";
            lblEditGoalFormHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditGoalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 421);
            Controls.Add(lblEditGoalFormHeader);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEGFSave);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "EditGoalForm";
            Text = "EditGoalForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button btnEGFSave;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private Label lblEditGoalFormHeader;
    }
}