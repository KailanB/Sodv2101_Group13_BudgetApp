using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Group13_BudgetApp
{
    abstract class Income
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public int IncomeTypeID { get; set; }

        public Income()
        {

        }

        public Income(string name, double amount)
        {
            Name = name;
            Amount = amount;
        }

        public abstract double GetTotalEarned();

    }
}
