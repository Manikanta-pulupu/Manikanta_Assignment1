using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Program
    {
        static List<Task> tasks = new List<Task>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Simple Task List");
                Console.WriteLine("1. Create a task");
                Console.WriteLine("2. Read a task");
                Console.WriteLine("3. Update a task");
                Console.WriteLine("4. Delete a task");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option: ");

                int option = Convert.ToInt32(Console.ReadLine());
                
                switch(option)
                {
                    case 1:
                        CreateTask();
                        break;
                    case 2:
                        ReadTasks();
                        break;
                    case 3:
                        UpdateTask();
                        break;
                    case 4:
                        DeleteTask();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default: 
                        Console.WriteLine("Invalid option");
                        break;

                }
            }
        }
        static void CreateTask()
        {
            Console.WriteLine("Enter task Title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter task Description");
            string desc = Console.ReadLine();

            Task task = new Task { Title = title, Description = desc };
            tasks.Add(task);

            Console.WriteLine("Task has been created successfully");
        }


        static void ReadTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available");
            }
            else
            {
                foreach(Task task in tasks)
                {
                    Console.WriteLine($" Task {tasks.IndexOf(task) + 1}: {task.Title} - {task.Description}");
                }
            }
        }

        static void UpdateTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available");
            }
            else
            {
                Console.WriteLine("Enter task number to update: ");
                int taskNum = Convert.ToInt32(Console.ReadLine())-1;

                if(taskNum>=0 && taskNum < tasks.Count)
                {
                    Console.WriteLine("Enter new task title: ");
                    string newTitle = Console.ReadLine();
                    Console.WriteLine("Enter new task description: ");
                    string newDesc = Console.ReadLine();

                    tasks[taskNum].Title = newTitle;
                    tasks[taskNum].Description = newDesc;

                    Console.WriteLine("Task Updated successfully");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
        }




        static void DeleteTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                Console.Write("Enter task number to delete: ");
                int taskNumber = Convert.ToInt32(Console.ReadLine()) - 1;

                if (taskNumber >= 0 && taskNumber < tasks.Count)
                {
                    tasks.RemoveAt(taskNumber);
                    Console.WriteLine("Task deleted successfully");
                }
                else
                {
                    Console.WriteLine("Invalid task number");
                }
            }
        }

        class Task
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }

    }
}
