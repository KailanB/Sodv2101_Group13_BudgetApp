using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Group13_BudgetApp
{
    public class Contribution
    {
        public int ContributionID { get; set; }
        public int GoalID { get;  set; } 
        public double Amount { get;  set; }
        public string Description { get;  set; }

        public DateTime Date { get;  set; }


        public Contribution()
        {

        }

        public Contribution(int goalId, double amount, string description, DateTime date)
        {
            GoalID = goalId;
            Amount = amount;
            Description = description;
            Date = date;
        }
        public Contribution(int contributionId, int goalId, double amount, string description, DateTime date)
        {
            ContributionID = contributionId;
            GoalID = goalId;
            Amount = amount;
            Description = description;
            Date = date;
        }

    }
}
