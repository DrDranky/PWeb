using System;

namespace Ex1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            User bob = new User("Bob");

            bob.AddTask("Gym",Task.Priority.Medium,Task.Category.Personal,Task.State.Waiting,
                new DateTime(2021,10,13), new DateTime(2021,10,20));
            bob.AddTask("GF'sGift",Task.Priority.High,Task.Category.Personal,Task.State.InExecution,
                new DateTime(2021,10,12), new DateTime(2021,10,19));
            bob.AddTask("PWebStudy",Task.Priority.Medium,Task.Category.Work,Task.State.InExecution,
                new DateTime(2021,10,14), new DateTime(2021,10,15));
            bob.AddTask("CleanRoom",Task.Priority.Low,Task.Category.Personal,Task.State.Waiting,
                new DateTime(2021,10,9), new DateTime(2021,10,13));
            bob.AddTask("DeliverProject",Task.Priority.High,Task.Category.Work,Task.State.Done,
                new DateTime(2021,10,12), new DateTime(2021,10,14));
            bob.AddTask("WatchMovie",Task.Priority.Low,Task.Category.Personal,Task.State.Waiting,
                new DateTime(2021,10,12), new DateTime(2021,11,30));
            bob.AddTask("SendCV",Task.Priority.Low,Task.Category.Work,Task.State.Waiting,
                new DateTime(2021,10,12), new DateTime(2021,12,14));
           
            Console.WriteLine("Today is " + DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine(bob);
            bob.ShowAllTasks();
            
            
            // a)
            Console.WriteLine("\n\na) Delayed List");
            bob.ShowDelayedTasks();
            
            
            // first interpretation of b) 
            Console.WriteLine("\n\nb) First interpretation, Ordered low to high  priority list");
            bob.ShowTasksLowToHighPriority();
            
            // second interpretation of b)
            Console.WriteLine("\nb) second interpretation...");
            bob.ShowTasksWithPriority(Task.Priority.Low);            
            bob.ShowTasksWithPriority(Task.Priority.Medium);            
            bob.ShowTasksWithPriority(Task.Priority.High);            
            
            
            // c) first interpretation
            Console.WriteLine("\n\nc) Ordered per category personal first, work second list");
            bob.ShowTasksPersonalToWorkCategory();  
            
            // c) second interpretation
            Console.WriteLine("\n\nc) second interpretation...");
            bob.ShowTasksWithCategory(Task.Category.Personal);
            bob.ShowTasksWithCategory(Task.Category.Work);
            
            
            // d) first interpretation
            Console.WriteLine("\n\nd) Ordered per state waiting, in execution and done list");
            bob.ShowTasksSortedByStateOfExecution();
            
            // d) second interpretation
            Console.WriteLine("\n\nd) second interpretation...");
            bob.ShowTasksWithState(Task.State.Done);
            bob.ShowTasksWithState(Task.State.Waiting);
            bob.ShowTasksWithState(Task.State.InExecution);

            
            Console.WriteLine("\n\ne) List after \"Done\" state removed");
            bob.RemoveDoneTasks();
            bob.ShowAllTasks();
            
            Console.WriteLine("\n\nf) List after \"Personal\" category removed");
            bob.RemovePersonalTasks();
            bob.ShowAllTasks();
            
            Console.WriteLine("\n\ng) List after \"Low\" priority removed");
            bob.RemoveLowPriorityTasks();
            bob.ShowAllTasks();


        }
    }
}