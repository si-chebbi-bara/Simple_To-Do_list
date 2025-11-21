Console.WriteLine("Welcome to TO-Do App");
List<string> taskList = new List<string>();
string option = "";

while (option != "e")
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Add a task");
    Console.WriteLine("2. remove a task");
    Console.WriteLine("3. view a list of tasks");
    Console.WriteLine("4. press e to quit");
    
    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("Please enter name of task");
            string task = Console.ReadLine();
            taskList.Add(task);
            Console.WriteLine("Task added");
            break;
        case "2":
            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine(i + " : " +  taskList[i]);
            }

            Console.WriteLine("please enter the num of task to remove it");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            taskList.RemoveAt(taskNumber);
            break;
        
        case "3":
            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine(taskList[i]);
            }
            break;
        case "4":
            Console.WriteLine("Exiting...");
            
            break;
        default:
            Console.WriteLine("Please enter a valid option");
            break; 
    }
}