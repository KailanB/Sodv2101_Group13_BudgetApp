namespace Sodv2101_Group13_BudgetApp.Input_Forms
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
			((System.ComponentModel.ISupportInitialize)numBudgetAmount).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 55);
			label1.Name = "label1";
			label1.Size = new Size(42, 15);
			label1.TabIndex = 0;
			label1.Text = "Name:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 99);
			label2.Name = "label2";
			label2.Size = new Size(80, 15);
			label2.TabIndex = 1;
			label2.Text = "Max Amount:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 141);
			label3.Name = "label3";
			label3.Size = new Size(67, 15);
			label3.TabIndex = 2;
			label3.Text = "Description";
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(12, 288);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 3;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(273, 288);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(75, 23);
			btnCreate.TabIndex = 4;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// numBudgetAmount
			// 
			numBudgetAmount.DecimalPlaces = 2;
			numBudgetAmount.Location = new Point(100, 97);
			numBudgetAmount.Name = "numBudgetAmount";
			numBudgetAmount.Size = new Size(159, 23);
			numBudgetAmount.TabIndex = 5;
			// 
			// txtBudgetDescription
			// 
			txtBudgetDescription.Location = new Point(100, 138);
			txtBudgetDescription.Multiline = true;
			txtBudgetDescription.Name = "txtBudgetDescription";
			txtBudgetDescription.Size = new Size(159, 113);
			txtBudgetDescription.TabIndex = 6;
			// 
			// txtBudgetName
			// 
			txtBudgetName.Location = new Point(100, 52);
			txtBudgetName.Name = "txtBudgetName";
			txtBudgetName.Size = new Size(159, 23);
			txtBudgetName.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(111, 9);
			label4.Name = "label4";
			label4.Size = new Size(109, 15);
			label4.TabIndex = 8;
			label4.Text = "Create New Budget";
			// 
			// CreateBudget
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(360, 323);
			Controls.Add(label4);
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
		private Label label4;
	}
}