using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Group13_BudgetApp
{
    abstract class Income
    {
        public int IncomeId { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public int TypeID { get; set; }
        public string Type {  get; set; }
        public int UserID { get; set; }

        public Income()
        {

        }

        // used for inserting into DB before we have IncomeID
        public Income(string name, double amount, int typeId)
        {

            Name = name;
            Amount = amount;
            TypeID = typeId;
        }

        public Income(int incomeId, string name, double amount, int incomeTypeId, int userId)
        {
            IncomeId = incomeId;
            Name = name;
            Amount = amount;
            TypeID = incomeTypeId;
            UserID = userId;
        }
        public Income(int incomeId, string name, double amount, int incomeTypeId, string typeId, int userId)
        {
            IncomeId = incomeId;
            Name = name;
            Amount = amount;
            TypeID = incomeTypeId;
            Type = typeId;
            UserID = userId;
        }

        public Income(string name, double amount)
        {
            Name = name;
            Amount = amount;
        }

        public abstract double GetMonthlyEarnings(int month);

    }
}
