using System;

namespace SavingInterface
{
    class PasswordManager
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
    }
}