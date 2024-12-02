namespace Sodv2101_Group13_BudgetApp.InputForms
{
	partial class UpdateBudgetForm
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
            lblBudgetError = new Label();
            txtBudgetName = new TextBox();
            txtBudgetDescription = new TextBox();
            numBudgetAmount = new NumericUpDown();
            btnEdit = new Button();
            btnCancel = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblUpdateContribution = new Label();
            ((System.ComponentModel.ISupportInitialize)numBudgetAmount).BeginInit();
            SuspendLayout();
            // 
            // lblBudgetError
            // 
            lblBudgetError.AutoSize = true;
            lblBudgetError.ForeColor = SystemColors.ControlText;
            lblBudgetError.Location = new Point(12, 294);
            lblBudgetError.Name = "lblBudgetError";
            lblBudgetError.Size = new Size(0, 15);
            lblBudgetError.TabIndex = 19;
            // 
            // txtBudgetName
            // 
            txtBudgetName.Location = new Point(119, 75);
            txtBudgetName.Name = "txtBudgetName";
            txtBudgetName.Size = new Size(183, 23);
            txtBudgetName.TabIndex = 17;
            // 
            // txtBudgetDescription
            // 
            txtBudgetDescription.Location = new Point(119, 158);
            txtBudgetDescription.Multiline = true;
            txtBudgetDescription.Name = "txtBudgetDescription";
            txtBudgetDescription.Size = new Size(183, 76);
            txtBudgetDescription.TabIndex = 16;
            // 
            // numBudgetAmount
            // 
            numBudgetAmount.DecimalPlaces = 2;
            numBudgetAmount.Location = new Point(119, 116);
            numBudgetAmount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numBudgetAmount.Name = "numBudgetAmount";
            numBudgetAmount.Size = new Size(183, 23);
            numBudgetAmount.TabIndex = 15;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Plum;
            btnEdit.Location = new Point(227, 254);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Plum;
            btnCancel.Location = new Point(17, 254);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 12;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 11;
            label2.Text = "Max Amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 10;
            label1.Text = "Name:";
            // 
            // lblUpdateContribution
            // 
            lblUpdateContribution.Dock = DockStyle.Top;
            lblUpdateContribution.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdateContribution.Location = new Point(0, 0);
            lblUpdateContribution.Name = "lblUpdateContribution";
            lblUpdateContribution.Size = new Size(344, 57);
            lblUpdateContribution.TabIndex = 34;
            lblUpdateContribution.Text = "Update Budget";
            lblUpdateContribution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpdateBudgetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(344, 330);
            Controls.Add(lblUpdateContribution);
            Controls.Add(lblBudgetError);
            Controls.Add(txtBudgetName);
            Controls.Add(txtBudgetDescription);
            Controls.Add(numBudgetAmount);
            Controls.Add(btnEdit);
            Controls.Add(btnCancel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateBudgetForm";
            Text = "UpdateBudgetForm";
            ((System.ComponentModel.ISupportInitialize)numBudgetAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBudgetError;
		private TextBox txtBudgetName;
		private TextBox txtBudgetDescription;
		private NumericUpDown numBudgetAmount;
		private Button btnEdit;
		private Button btnCancel;
		private Label label3;
		private Label label2;
		private Label label1;
        private Label lblUpdateContribution;
    }
}