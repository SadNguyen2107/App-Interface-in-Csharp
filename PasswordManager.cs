using System;

namespace SavingInterface
{
    class PasswordManager : IDisplayable
    {
        // PROPERTIES
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        // CONSTRUCTORS
        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        // METHODS
        public void Display()
        {
            if (!this.Hidden)
            {
                Console.WriteLine($"Password: {this.Password}");
            }
            else { Console.WriteLine("Password: *"); }
        }
    }
}