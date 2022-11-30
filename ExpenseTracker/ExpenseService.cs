using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Models;

namespace ExpenseTracker
{
    public class ExpenseService
    {

        ReportingService reportingService = new ReportingService();

        public void AddExpense(Expense expense)
        {
            ExpenseRepository.ExpenseList.Add(expense);
        }

        public void RemoveExpense(int id)
        {
            ExpenseRepository.ExpenseList.RemoveAt(id);
        }

        public void CreateExpense()
        {
            Expense expense = new Expense();
            Console.WriteLine("Size of expense: ");
            expense.expenseSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name of expense: ");
            expense.expenseName = Console.ReadLine();
            AddExpense(expense);

        }
        internal void DeleteExpense()
        {
            //ExpenseRepository.ExpenseList.ForEach(Console.WriteLine);
            foreach(var expenseitem in ExpenseRepository.ExpenseList) 
            {
                Console.WriteLine(expenseitem.expenseName + " - " + expenseitem.expenseSize);
            }

            Console.WriteLine("Input which expense you want to Delete: ");
            int id= Convert.ToInt32(Console.ReadLine());
            RemoveExpense(id-1);
        }
        internal void UpdateExpense()
        {
            throw new NotImplementedException();
        }
    }
}
