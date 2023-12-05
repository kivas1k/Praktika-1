using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace DailyPlanner
{
    class Program
    {
        public static void Main()
        {
            string fileName = "tasks.json";

            List<Task> tasks = new List<Task>();

            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);

                tasks = JsonConvert.DeserializeObject<List<Task>>(json);
            }
            Console.WriteLine("Welcome to the diary, do you want to write down your business? (yes/no) ");

            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "yes")
            {
                
                while (true)
                {
                    Console.WriteLine("1. Add Task");

                    Console.WriteLine("2. Delete Task");

                    Console.WriteLine("3. Edit Task");

                    Console.WriteLine("4. View Tasks for Today");

                    Console.WriteLine("5. View Tasks for Tomorrow");

                    Console.WriteLine("6. View Tasks for the Week");

                    Console.WriteLine("7. View all Task");

                    Console.WriteLine("8. Enter the index of the task to mark as completed");

                    Console.WriteLine("9. Exit");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Console.WriteLine("Enter new name:");

                            string name = Console.ReadLine();
                            
                            Console.WriteLine();

                            Console.WriteLine("Enter task description:");

                            string description = Console.ReadLine();
                            
                            Console.WriteLine();

                            Console.WriteLine("Enter task date (yyyy-MM-dd):");

                            DateTime date = DateTime.Parse(Console.ReadLine());
                            
                            Console.WriteLine();

                            tasks.Add(new Task { Name = name, Description = description, Date = date });

                            break;

                        case 2:

                            Console.WriteLine("Enter the index of the task to delete:");

                            int index = int.Parse(Console.ReadLine());
                            
                            Console.WriteLine();

                            tasks.RemoveAt(index);

                            break;

                        case 3:

                            Console.WriteLine("Enter the index of the task to edit:");

                            int editIndex = int.Parse(Console.ReadLine());
                            
                            Console.WriteLine();

                            Console.WriteLine("Enter new name:");

                            string newName = Console.ReadLine();
                            
                            Console.WriteLine();

                            Console.WriteLine("Enter new task description:");

                            string newDescription = Console.ReadLine();
                            
                            Console.WriteLine();

                            Console.WriteLine("Enter new task date (yyyy-MM-dd):");

                            DateTime newDate = DateTime.Parse(Console.ReadLine());
                            
                            Console.WriteLine();

                            tasks[editIndex].Name = newName;

                            tasks[editIndex].Description = newDescription;

                            tasks[editIndex].Date = newDate;

                            break;

                        case 4:

                            Console.WriteLine("Tasks for today:");

                            foreach (Task task in tasks)
                            {
                                if (task.Date.Date == DateTime.Today)
                                {
                                    Console.WriteLine(
                                        $"{task.Name} - {task.Description} - {task.Date.ToString("yyyy-MM-dd")}");
                                }
                            }

                            break;

                        case 5:

                            Console.WriteLine("Tasks for tomorrow:");

                            foreach (Task task in tasks)
                            {
                                if (task.Date.Date == DateTime.Today.AddDays(1))
                                {
                                    Console.WriteLine(
                                        $"{task.Name} - {task.Description} - {task.Date.ToString("yyyy-MM-dd")}");
                                }
                            }

                            break;

                        case 6:

                            Console.WriteLine("Tasks for the week:");

                            DateTime startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);

                            DateTime endOfWeek = startOfWeek.AddDays(6);

                            foreach (Task task in tasks)
                            {
                                if (task.Date.Date >= startOfWeek && task.Date.Date <= endOfWeek)
                                {
                                    Console.WriteLine(
                                        $"{task.Name} - {task.Description} - {task.Date.ToString("yyyy-MM-dd")}");
                                }
                            }

                            break;

                        case 7:

                            Console.WriteLine("All tasks:");

                            foreach (var task in tasks)
                            {
                                string status = task.Date.Date > DateTime.Today ? "Upcoming" : "Completed";

                                Console.WriteLine(
                                    $"{task.Name} - {task.Description} - {task.Date.ToString("yyyy-MM-dd")} - {status} - Completed: {task.IsCompleted}");
                            }

                            break;

                        case 8:

                            Console.WriteLine("Enter the index of the task to mark as completed:");

                            int completedIndex = int.Parse(Console.ReadLine());
                            
                            Console.WriteLine();

                            Console.WriteLine("Has the task been completed? (yes/no):");

                            string isCompleted = Console.ReadLine().ToLower();
                            
                            Console.WriteLine();

                            if (isCompleted == "yes")
                            {
                                tasks[completedIndex].IsCompleted = true;
                            }
                            else
                            {
                                tasks[completedIndex].IsCompleted = false;
                            }

                            break;

                        case 9:

                            string json = JsonConvert.SerializeObject(tasks);
                            
                            File.WriteAllText(fileName, json);
                            
                            Console.WriteLine("bye bye");

                            return;
                    }
                }
            }
            else if (userInput.ToLower() == "no")
            {
                Console.WriteLine("bye bye");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}