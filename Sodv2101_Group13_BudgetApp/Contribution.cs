using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Group13_BudgetApp
{
    internal class Contribution
    {

        public string Name { get; private set; } // Should the Name be a comboBox of Categories with options of (Budget, Financial Goal, Expense)
        public double Amount { get; private set; }
        public string Description { get; private set; }

        public string Deadline { get; private set; }


        public Contribution()
        {

        }

        public Contribution(string name, double amount, string description, string deadline)
        {
            Name = name;
            Amount = amount;
            Description = description;
            Deadline = deadline;
        }

    }
}
