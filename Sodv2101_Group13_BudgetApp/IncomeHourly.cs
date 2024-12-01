using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Group13_BudgetApp
{
    internal class IncomeHourly : Income
    {
        public double Hours { get; set; }

        public IncomeHourly(string name, double amount, string timePeriod) : base(name, amount)
        {
            
        }

        public void AddHours(double hours)
        {
            Hours += hours;
        }

        

        public override double GetTotalEarned()
        {
            return Hours * Amount;
        }

    }
}
