using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Group13_BudgetApp
{
    public class FinancialGoal
    {

        public int GoalID { get; set; }
        public string Name { get;  set; }
        public double MaxAmount { get;  set; }
        public string? Description { get;  set; }
        // Added deadline and UserID
        public DateTime? Deadline { get;  set; }
        public int UserID { get; private set; }

        public List<Contribution> Contributions { get; set; } = new List<Contribution>();

        public FinancialGoal()
        {

        }

        public FinancialGoal(string name, double maxAmount, string description, DateTime deadline)
        {
            Name = name;
            MaxAmount = maxAmount;
            Description = description;
            Deadline = deadline;
        }


        public void AddNewExpense(string name, double amount, string description, DateTime timePeriod)
        {
            Contribution newContribution = new Contribution(name, amount, description, timePeriod);
            Contributions.Add(newContribution);


        }


    }
}
