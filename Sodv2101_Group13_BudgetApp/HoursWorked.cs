using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Group13_BudgetApp
{
    internal class HoursWorked
    {

        public int HoursID { get; set; }
        public double Hours { get; set; }
        public DateTime Date { get; set; }
        public int IncomeID { get; set; }



        public HoursWorked(int hoursID, double hours, DateTime date, int incomeID)
        {
            HoursID = hoursID;
            Hours = hours;
            Date = date;
            IncomeID = incomeID;
        }


    }
}
