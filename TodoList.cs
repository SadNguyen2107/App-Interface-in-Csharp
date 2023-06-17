using System;

namespace SavingInterface
{
    class TodoList
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
    }
}