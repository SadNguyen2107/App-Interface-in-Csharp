using System;

namespace SavingInterface
{
    class TodoList : IDisplayable, IResetable
    {
        // FIELDS
        private string headerSymbol = "-";
        // PROPERTIES
        public string HeaderSymbol
        {
            get { return this.headerSymbol; }
        }
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
            if (this.nextOpenIndex < 5)
            {
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            }
            else
            {
                Console.WriteLine("That is too much for Todos List");
            }
        }
        public void Display()
        {
            Console.WriteLine("Todos");
            for (int time = 0; time < 8; time++)
            {
                Console.Write(this.HeaderSymbol);
            }
            Console.WriteLine();

            foreach (string todo in this.Todos)
            {
                if (!String.IsNullOrEmpty(todo))
                {
                    Console.WriteLine(todo);
                }
                else Console.WriteLine("[]");
            }
        }

        public void Reset()
        {
            this.Todos = new String[5];
            this.nextOpenIndex = 0;
        }
    }
}