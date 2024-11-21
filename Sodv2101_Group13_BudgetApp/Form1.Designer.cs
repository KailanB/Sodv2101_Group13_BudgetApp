namespace Sodv2101_Group13_BudgetApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnCreateBudget = new Button();
			comboBudgets = new ComboBox();
			SuspendLayout();
			// 
			// btnCreateBudget
			// 
			btnCreateBudget.Location = new Point(599, 82);
			btnCreateBudget.Name = "btnCreateBudget";
			btnCreateBudget.Size = new Size(106, 23);
			btnCreateBudget.TabIndex = 0;
			btnCreateBudget.Text = "Create Budget";
			btnCreateBudget.UseVisualStyleBackColor = true;
			btnCreateBudget.Click += btnCreateBudget_Click;
			// 
			// comboBudgets
			// 
			comboBudgets.FormattingEnabled = true;
			comboBudgets.Location = new Point(584, 147);
			comboBudgets.Name = "comboBudgets";
			comboBudgets.Size = new Size(121, 23);
			comboBudgets.TabIndex = 1;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(comboBudgets);
			Controls.Add(btnCreateBudget);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button btnCreateBudget;
        private ComboBox comboBudgets;
    }
}
