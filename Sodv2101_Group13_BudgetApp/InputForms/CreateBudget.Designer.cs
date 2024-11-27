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
            label4 = new Label();
            lblBudgetError = new Label();
            ((System.ComponentModel.ISupportInitialize)numBudgetAmount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 73);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 132);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Max Amount:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 188);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(14, 384);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(312, 384);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(86, 31);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // numBudgetAmount
            // 
            numBudgetAmount.DecimalPlaces = 2;
            numBudgetAmount.Location = new Point(114, 129);
            numBudgetAmount.Margin = new Padding(3, 4, 3, 4);
            numBudgetAmount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numBudgetAmount.Name = "numBudgetAmount";
            numBudgetAmount.Size = new Size(182, 27);
            numBudgetAmount.TabIndex = 5;
            // 
            // txtBudgetDescription
            // 
            txtBudgetDescription.Location = new Point(114, 184);
            txtBudgetDescription.Margin = new Padding(3, 4, 3, 4);
            txtBudgetDescription.Multiline = true;
            txtBudgetDescription.Name = "txtBudgetDescription";
            txtBudgetDescription.Size = new Size(181, 149);
            txtBudgetDescription.TabIndex = 6;
            // 
            // txtBudgetName
            // 
            txtBudgetName.Location = new Point(114, 69);
            txtBudgetName.Margin = new Padding(3, 4, 3, 4);
            txtBudgetName.Name = "txtBudgetName";
            txtBudgetName.Size = new Size(181, 27);
            txtBudgetName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 12);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 8;
            label4.Text = "Create New Budget";
            // 
            // lblBudgetError
            // 
            lblBudgetError.AutoSize = true;
            lblBudgetError.ForeColor = Color.Red;
            lblBudgetError.Location = new Point(14, 347);
            lblBudgetError.Name = "lblBudgetError";
            lblBudgetError.Size = new Size(0, 20);
            lblBudgetError.TabIndex = 9;
            // 
            // CreateBudget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 431);
            Controls.Add(lblBudgetError);
            Controls.Add(label4);
            Controls.Add(txtBudgetName);
            Controls.Add(txtBudgetDescription);
            Controls.Add(numBudgetAmount);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
		private Label label4;
		private Label lblBudgetError;
	}
}