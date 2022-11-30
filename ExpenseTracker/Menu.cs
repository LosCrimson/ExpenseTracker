using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Models;

namespace ExpenseTracker
{
    public class Menu
    {
        public static ActionType GetActionType()
        {
            do
            {
                Console.WriteLine("Pick an option: ");
                Console.WriteLine("[1] Create expense");
                Console.WriteLine("[2] Delete expense");
                Console.WriteLine("[3] Update expense");
                Console.WriteLine("[4] EXIT");

                string menuChoice = Console.ReadLine();

                switch(menuChoice) 
                {
                    case "1":
                        return ActionType.CREATE;
                    case "2":
                        return ActionType.DELETE;
                    case "3":
                        return ActionType.UPDATE;
                    case "4":
                        return ActionType.EXIT;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            } while(true);
        }
    }
}
