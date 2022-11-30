using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Models;

namespace ExpenseTracker
{
    public class ReportingService
    {

        //ExpenseService expenseService = new ExpenseService();

        public void ReportAll()
        {

            ExpenseRepository.ExpenseList.ForEach(Console.WriteLine);
        }
    }
}
