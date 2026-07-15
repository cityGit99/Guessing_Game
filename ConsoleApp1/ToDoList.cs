using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace gameCollection
{
    public class ToDoList
    {
       public void todoList()
        {

            Console.WriteLine("Welcome to To-Do-List");
            string option = "";

            List<string> tasklist = new List<string>();


            while (option != "e")
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Enter 1 to add new task item");
                Console.WriteLine("Enter 2 to remove task item");
                Console.WriteLine("Enter 3 to view task item");
                Console.WriteLine("Enter e to exit the program");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Please add in your item:");
                    string task = Console.ReadLine();
                    tasklist.Add(task);
                    Console.WriteLine("Task added to the list.");
                }
                else if (option == "2")
                {

                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(i + " : " + tasklist[i]);
                    }

                    Console.WriteLine("Please enter the task item to remove:");
                    int taskNumber = int.Parse(Console.ReadLine());
                    tasklist.RemoveAt(taskNumber);

                }
                else if (option == "3")
                {
                    Console.WriteLine("Here are your task items:");
                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(i + " : " + tasklist[i]);
                    }

                }
                else if (option == "e")
                {
                    Console.WriteLine("Exiting the program.");

                }
                else
                {
                    Console.WriteLine("You enter the invalid option, please try again");
                }

                Console.WriteLine("Thank for using the to-do-list");
            }
        }

    }
}
