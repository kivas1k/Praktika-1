using Newtonsoft.Json;

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
                    Console.WriteLine("1. Add Task\n2. Delete Task\n3. Edit Task\n4. View Tasks for Today\n" +
                                      "5. View Tasks for Tomorrow\n6. View Tasks for the Week\n7. View all Task\n" +
                                      "8. View all Completed Tasks\n9. View all Unfinished tasks\n" +
                                      "10. Enter the index of the task to mark as completed\n11. Exit");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Console.WriteLine("Enter new name:\n");

                            string name = Console.ReadLine();

                            Console.WriteLine("Enter task description:\n");

                            string description = Console.ReadLine();

                            Console.WriteLine("Enter task date (yyyy-MM-dd):\n");

                            DateTime date = DateTime.Parse(Console.ReadLine());

                            tasks.Add(new Task { Name = name, Description = description, Date = date });

                            break;

                        case 2:

                            Console.WriteLine("Enter the index of the task to delete:\n");

                            int index = int.Parse(Console.ReadLine());

                            tasks.RemoveAt(index);

                            break;

                        case 3:

                            Console.WriteLine("Enter the index of the task to edit:\n");

                            int editIndex = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter new name:\n");

                            string newName = Console.ReadLine();

                            Console.WriteLine("Enter new task description:\n");
                            
                            string newDescription = Console.ReadLine();

                            Console.WriteLine("Enter new task date (yyyy-MM-dd):\n");

                            DateTime newDate = DateTime.Parse(Console.ReadLine());

                            tasks[editIndex].Name = newName;

                            tasks[editIndex].Description = newDescription;

                            tasks[editIndex].Date = newDate;

                            break;

                        case 4:

                            Console.WriteLine("Tasks for today:\n");

                            foreach (Task task in tasks)
                            {
                                if (task.Date.Date == DateTime.Today)
                                {
                                    Console.WriteLine(
                                        $"{task.Name} - {task.Description} - {task.Date.ToString("yyyy-MM-dd\n")}");
                                }
                            }

                            break;

                        case 5:

                            Console.WriteLine("Tasks for tomorrow:\n");

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

                            Console.WriteLine("Tasks for the week:\n");

                            DateTime startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);

                            DateTime endOfWeek = startOfWeek.AddDays(6);

                            foreach (Task task in tasks)
                            {
                                if (task.Date.Date >= startOfWeek && task.Date.Date <= endOfWeek)
                                {
                                    Console.WriteLine(
                                        $"{task.Name} - {task.Description} - {task.Date.ToString("yyyy-MM-dd\n")}");
                                }
                            }

                            break;

                        case 7:

                            Console.WriteLine("All tasks:\n");

                            foreach (var task in tasks)
                            {
                                string status = task.Date.Date > DateTime.Today ? "Upcoming" : "Completed";

                                Console.WriteLine(
                                    $"{task.Name} - {task.Description} - {task.Date.ToString("yyyy-MM-dd")} - {status} - Completed: {task.IsCompleted}");
                            }

                            break;

                        case 8:

                            Console.WriteLine("8. View  all Completed Tasks\n");

                            foreach (var task in tasks)
                            {
                                if (task.IsCompleted)
                                {
                                    Console.WriteLine($"{task.Name} - {task.Description} - {task.Date.ToString("yyyy-MM-dd\n")}");
                                }
                            }
                            
                            break;
                        
                        case 9:

                            Console.WriteLine("9. View all Unfinished tasks\n");

                            foreach (var task in tasks)
                            {
                                if (!task.IsCompleted)
                                {
                                    Console.WriteLine($"{task.Name} - {task.Description} - {task.Date.ToString("yyyy-MM-dd")}");
                                }
                            }

                            break;
                        
                        case 10:

                            Console.WriteLine("Enter the index of the task to mark as completed:\n");

                            int completedIndex = int.Parse(Console.ReadLine());
                            
                            Console.WriteLine("Has the task been completed? (yes/no):\n");

                            string isCompleted = Console.ReadLine().ToLower();
                            
                            if (isCompleted == "yes")
                            {
                                tasks[completedIndex].IsCompleted = true;
                            }
                            else
                            {
                                tasks[completedIndex].IsCompleted = false;
                            }

                            break;

                        case 11:

                            string json = JsonConvert.SerializeObject(tasks);
                            
                            File.WriteAllText(fileName, json);
                            
                            Console.WriteLine("bye bye\n");

                            return;
                    }
                }
            }
            else if (userInput.ToLower() == "no")
            {
                Console.WriteLine("bye bye\n");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}