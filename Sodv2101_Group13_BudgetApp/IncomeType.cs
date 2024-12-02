using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodv2101_Group13_BudgetApp
{
    internal class IncomeType
    {

        public int TypeId { get; set; }
        public string Type {  get; set; }

        public IncomeType(int id, string type)
        {
            TypeId = id;
            Type = type;
        }
    }
}
