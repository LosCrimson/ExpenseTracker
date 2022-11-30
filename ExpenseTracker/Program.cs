using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker;
using ExpenseTracker.Models;

namespace ExpenseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ExpenseService expenseService = new ExpenseService();

            while(true) 
            {
                switch (Menu.GetActionType())
                {
                    case ActionType.CREATE:
                        expenseService.CreateExpense();
                        break;
                    case ActionType.DELETE:
                        expenseService.DeleteExpense();
                        break;
                    case ActionType.UPDATE:
                        expenseService.UpdateExpense();
                        break;
                    case ActionType.EXIT:
                        return;
                }
            }
        }
    }
}
