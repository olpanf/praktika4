namespace ConsoleTodo
{
    class Program
    {
        public static List<Task> taskList = new List<Task>();

        static void Main(string[] args)
        {
            Task firstTask = new Task(name: "полить цветы", description: "вечером", date: new DateTime(2022, 10, 20));
            Task secondTask = new Task(name: "сходить к бабушке ", description: "утром", date: new DateTime(2022, 10, 20));
            Task thirdTask = new Task(name: "сделать дз", description: "по всем предметам на неделю вперед", date: new DateTime(2022, 10, 21));
            Task fourthTask = new Task(name: "отдохнуть", description: "обязательно!!!", date: new DateTime(2022, 10, 19));

            taskList.Add(firstTask);
            taskList.Add(secondTask);
            taskList.Add(thirdTask);
            taskList.Add(fourthTask);

            DateTime date = new(2022, 10, 20);

            List<Task> orderedList = taskList;
            orderedList = taskList.Where(o => o.date == date).ToList();

            var menu = new Menu(taskList);
            menu.DrawMenu(date);
        }

        public static void ViewTaskDetails(int index)
        {
            int taskID = index;

            Console.WriteLine("--------------------------\n" +
                              $"Date: {taskList.ElementAt(taskID).date}\n" +
                              $"--------------------------\n");
            Console.Write($"Task: {taskList.ElementAt(taskID).name}\n" +
                          $"Description: {taskList.ElementAt(taskID).description}");
        }

        public static List<Task> SortByDate(DateTime date)
        {
            List<Task> orderedList = taskList;
            orderedList = taskList.Where(o => o.date == date).ToList();

            return orderedList;
        }
    }
}