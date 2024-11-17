using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Group13_BudgetApp
{
    internal class Expense
    {

        public string Name { get; private set; }
        public double Amount { get; private set; }
        public string Description { get; private set; }

        public string TimePeriod { get; private set; }


        public Expense()
        {

        }

        public Expense(string name, double amount, string description, string timePeriod)
        {
            Name = name;
            Amount = amount;
            Description = description;
            TimePeriod = timePeriod;
        }


    }
}
