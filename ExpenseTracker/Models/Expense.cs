using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int expenseSize { get; set; }
        public string expenseName { get; set; }

        public Expense()
        {
            this.expenseSize = expenseSize;
            this.expenseName = expenseName;
        }
    }
}
