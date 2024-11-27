﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Group13_BudgetApp
{
    internal class Expense
    {

        public int ExpenseId { get; set; } // Check if it is necessary to match the DB
        public int BudgetId { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public string TimePeriod { get; set; }


        public Expense()
        {

        }


        public Expense(int expenseId, int budgetId, string name, double amount, string description, string timePeriod)
        {
            ExpenseId = expenseId;//I am not sure about the ID if we follow the db
            BudgetId = budgetId;
            Name = name;
            Amount = amount;
            Description = description;
            TimePeriod = timePeriod;
        }


    }
}
