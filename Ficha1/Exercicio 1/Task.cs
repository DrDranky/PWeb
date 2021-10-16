using System;

namespace Ex1
{
    public class Task
    {
        public Task(string name, Priority priority, Category category, State state, DateTime registerDate,
            DateTime limitDate)
        {
            _name = name;
            TaskPriority = priority;
            TaskCategory = category;
            TaskState = state;
            _registerDate = registerDate;
            _limitDate = limitDate;
        }

        public enum Priority{Low, Medium, High}
        public enum Category{Personal,Work}
        public enum State{InExecution,Waiting,Done}

        public readonly Priority TaskPriority;
        public readonly Category TaskCategory;
        public readonly State TaskState;

        private readonly DateTime _registerDate;
        private readonly DateTime _limitDate;
        private readonly string _name;

        public static void PrepareForPrint()
        {
            Console.WriteLine("{0,-15} {1, -12} {2, -12} {3, -13} {4, -16} {5, -15}",
                "[ Name ]", "[ Priority ]", "[ Category ]", "[ State ]", "[ RegisterDate ]", "[ LimitDate ]");
        }
        public void Print()
        {
            Console.WriteLine("{0,-15} {1, -12} {2, -12} {3, -13} {4, -16:dd/MM/yyyy} {5, -15:dd/MM/yyyy}", _name,
               TaskPriority, TaskCategory, TaskState, _registerDate, _limitDate);
        }

        public bool IsDelayed() => DateTime.Now > _limitDate;

    }
}