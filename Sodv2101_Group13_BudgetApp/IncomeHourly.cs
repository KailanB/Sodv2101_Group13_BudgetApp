using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Group13_BudgetApp
{
    internal class IncomeHourly : Income
    {
        public List<HoursWorked> HoursList { get; set; } = new List<HoursWorked>();
        public double HoursTotal { get; set; }

        public IncomeHourly(string name, double amount) : base(name, amount)
        {

        }

        public IncomeHourly(string name, double amount, int incomeTypeId) : base(name, amount, incomeTypeId)
        {

        }

        public IncomeHourly(int incomeId, string name, double amount, int incomeTypeId, int userId) : base(incomeId, name, amount, incomeTypeId, userId)
        {

        }
        public IncomeHourly(int incomeId, string name, double amount, int incomeTypeId, string type, int userId) : base(incomeId, name, amount, incomeTypeId, type, userId)
        {

        }

        public void AddHours(HoursWorked hours)
        {
            HoursList.Add(hours);
        }

        public double GetTotalEarned()
        {
            double total = 0;
            foreach (HoursWorked hour in HoursList)
            {
                total += hour.Hours;
            }
            return total;

        }

        public override double GetMonthlyEarnings(int month)
        {
            double totalHours = 0;
            foreach (HoursWorked hour in HoursList)
            {
                if (hour.Date.Month == month)
                {
                    totalHours += hour.Hours;
                }

            }
            return totalHours * Amount;
        }
    }
}
