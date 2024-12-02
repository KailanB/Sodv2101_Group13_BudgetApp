using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Group13_BudgetApp
{
    internal class IncomeSalary : Income
    {



        // public string TimePeriod { get; private set; } // actually thinking we shouldn't have this maybe?
        // leave salary as monthly for simplicity
        // then both income types can share the TotalEarned method to return total monthly earnings for either
        // that way an income list can easily get monthly total earned for ALL income types??

        public IncomeSalary() { }

        public IncomeSalary(string name, double amount) : base(name, amount)
        {
            // don't need this??
            // TimePeriod = timePeriod;
        }


        public IncomeSalary(string name, double amount, int incomeTypeId) : base(name, amount, incomeTypeId)
        {

        }

        public IncomeSalary(int incomeId, string name, double amount, int incomeTypeId, int userId) : base(incomeId, name, amount, incomeTypeId, userId)
        {

        }

        public IncomeSalary(int incomeId, string name, double amount, int incomeTypeId, string type, int userId) : base(incomeId, name, amount, incomeTypeId, type, userId)
        {

        }


        public override double GetMonthlyEarnings(int month)
        {
            return Amount;
        }
    }
}
