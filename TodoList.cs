using System;

namespace SavingInterface
{
    class TodoList: IDisplayable, IResetable
    {
        // PROPERTIES
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        // CONSTRUCTORS
        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        // METHODS
        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }
        public void Display()
        {
            Console.WriteLine("Work needs to be done: ");
            for (int index = 0; index < Todos.Length; index++)
            {
                Console.WriteLine($"{index}. {this.Todos[index]}");
            }

        }
    }
}