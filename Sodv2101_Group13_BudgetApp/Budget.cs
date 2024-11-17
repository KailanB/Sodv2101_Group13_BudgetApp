using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Group13_BudgetApp
{
    internal class Budget
    {
        public string Name { get; private set; }
        public double Max { get; private set; }
        public string Description { get; private set; }

        public List<Expense> expenses { get; private set; } = new List<Expense>();

        public Budget()
        {

        }

        public Budget(string name, double max, string description)
        {
            Name = name;
            Max = max;
            Description = description;
        }


        public void AddNewExpense(string name, double amount, string description, string timePeriod)
        {
            Expense newExpense = new Expense(name, amount, description, timePeriod);
            expenses.Add(newExpense);


        }



    }
}
