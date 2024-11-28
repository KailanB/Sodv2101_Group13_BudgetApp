using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Group13_BudgetApp
{
    internal class FinancialGoal
    {


        public string Name { get; private set; }
        public double Max { get; private set; }
        public string? Description { get; private set; }
        // Added deadline and UserID
        public DateTime? Deadline { get; private set; }
        public int UserID { get; private set; }

        public List<Contribution> contributions { get; private set; } = new List<Contribution>();

        public FinancialGoal()
        {

        }

        public FinancialGoal(string name, double max, string description)
        {
            Name = name;
            Max = max;
            Description = description;
        }


        public void AddNewExpense(string name, double amount, string description, string timePeriod)
        {
            Contribution newContribution = new Contribution(name, amount, description, timePeriod);
            contributions.Add(newContribution);


        }


    }
}
