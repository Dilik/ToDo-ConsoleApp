using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_ConsoleApp
{
    class ToDo
    {
        public static void listItems() {
            List<string> toDoList = new List<string>();
            bool AppRuning = true;

            Console.WriteLine("Welcome to the Simple To Do List");
            Console.WriteLine("Type The Following Commands:\n To Exit: '-exit' \n To See Entire List: '-show' \n To Delete:'ItemFromTheToDoList-' \n");

            while (AppRuning)
            {
                Console.WriteLine("Please enter a list item to add or a command to perform:");

                //read in what the user types
                var input = Console.ReadLine();
              
                switch (input)
                {
                    //if we are told to exit, close the program
                    case string a when a.StartsWith("-exit"):
                        AppRuning = false;
                        break;

                    //if we are told to remove an item from our list, 
                    //remove it
                    case string b when b.ToUpper().EndsWith("-"):
                        var endIndex = b.IndexOf("-");
                        var item = b.Substring(0, endIndex);
                        if (toDoList.Contains(item))
                        {
                            toDoList.Remove(item);
                            Console.WriteLine("Removed {0} \n", item);
                        }
                        else
                        {
                            Console.WriteLine("{0} is not currently in the list, it cannot be removed", item);
                        }
                        break;

                    //if we are told to show the list, show it
                    case string c when c.StartsWith("-show"):
                        Console.WriteLine("\n------To Do List-----");
                        foreach (var task in toDoList)
                        {
                            Console.WriteLine(task);
                        }
                        Console.WriteLine("---------------------\n");
                        break;

                    //if none of those commands are given, 
                    //add whatever was typed in to the To Do list
                    default:
                        toDoList.Add(input);
                        break;
                }
            }
        }
    }
}
