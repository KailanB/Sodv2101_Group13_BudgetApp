namespace Sodv2101_Group13_BudgetApp.InputForms
{
	partial class CreateBudget
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
            label2 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            btnCreate = new Button();
            numBudgetAmount = new NumericUpDown();
            txtBudgetDescription = new TextBox();
            txtBudgetName = new TextBox();
            lblBudgetError = new Label();
            lblCreateBudget = new Label();
            ((System.ComponentModel.ISupportInitialize)numBudgetAmount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Max Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Plum;
            btnCancel.Location = new Point(17, 241);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Plum;
            btnCreate.Location = new Point(214, 241);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // numBudgetAmount
            // 
            numBudgetAmount.DecimalPlaces = 2;
            numBudgetAmount.Location = new Point(104, 112);
            numBudgetAmount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numBudgetAmount.Name = "numBudgetAmount";
            numBudgetAmount.Size = new Size(185, 23);
            numBudgetAmount.TabIndex = 5;
            // 
            // txtBudgetDescription
            // 
            txtBudgetDescription.Location = new Point(104, 153);
            txtBudgetDescription.Multiline = true;
            txtBudgetDescription.Name = "txtBudgetDescription";
            txtBudgetDescription.Size = new Size(185, 72);
            txtBudgetDescription.TabIndex = 6;
            // 
            // txtBudgetName
            // 
            txtBudgetName.Location = new Point(104, 67);
            txtBudgetName.Name = "txtBudgetName";
            txtBudgetName.Size = new Size(185, 23);
            txtBudgetName.TabIndex = 7;
            // 
            // lblBudgetError
            // 
            lblBudgetError.AutoSize = true;
            lblBudgetError.ForeColor = SystemColors.ControlText;
            lblBudgetError.Location = new Point(12, 278);
            lblBudgetError.Name = "lblBudgetError";
            lblBudgetError.Size = new Size(0, 15);
            lblBudgetError.TabIndex = 9;
            // 
            // lblCreateBudget
            // 
            lblCreateBudget.Dock = DockStyle.Top;
            lblCreateBudget.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateBudget.Location = new Point(0, 0);
            lblCreateBudget.Name = "lblCreateBudget";
            lblCreateBudget.Size = new Size(327, 57);
            lblCreateBudget.TabIndex = 20;
            lblCreateBudget.Text = "Create Budget";
            lblCreateBudget.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateBudget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(327, 313);
            Controls.Add(lblCreateBudget);
            Controls.Add(lblBudgetError);
            Controls.Add(txtBudgetName);
            Controls.Add(txtBudgetDescription);
            Controls.Add(numBudgetAmount);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateBudget";
            Text = "CreateBudget";
            ((System.ComponentModel.ISupportInitialize)numBudgetAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private Label label2;
		private Label label3;
		private Button btnCancel;
		private Button btnCreate;
		private NumericUpDown numBudgetAmount;
		private TextBox txtBudgetDescription;
		private TextBox txtBudgetName;
		private Label lblBudgetError;
        private Label lblCreateBudget;
    }
}