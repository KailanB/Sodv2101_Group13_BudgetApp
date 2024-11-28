using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Group13_BudgetApp
{
    public class Budget
    {
        public int BudgetID {  get; set; }
        public string Name { get; private set; }
        public double Max { get; private set; }
        public string Description { get; private set; }
        public int UserID { get; private set; } 

        public List<Expense> Expenses { get; set; } = new List<Expense>();

        public Budget()
        {

        }

		public Budget(string name, double max, string description)
		{
			Name = name;
			Max = max;
			Description = description;
		}

		public Budget(int budgetId, string name, double max, string description, int userID)
        {
            BudgetID = budgetId;
            Name = name;
            Max = max;
            Description = description;
            UserID = userID;
        }


        public void AddNewExpense(Expense expense)
        {
			// Expense newExpense = new Expense(name, amount, description, timePeriod);
			Expenses.Add(expense);

        }

        public double GetExpenseTotal(int month)
        {
            double total = 0;
            foreach(Expense expense in Expenses)
            {
                total += expense.Amount;
            }

            return total;
        }

		public double GetExpenseTotalByMonth(int month)
		{
			double total = 0;
			foreach (Expense expense in Expenses)
			{
                if(expense.TimePeriod.Month == month)
                {
                    total += expense.Amount;
                }
				
			}

			return total;
		}



	}
}
