using System;

namespace SavingInterface
{
    class PasswordManager : IDisplayable, IResetable
    {
        // FIELDS
        private string headerSymbol = "-";
        private string password;
        // PROPERTIES
        public string HeaderSymbol
        {
            get { return this.headerSymbol; }
        }
        private string Password
        {
            get { return this.password; }
            set
            {
                if (value.Length < 8) { Console.WriteLine("Password is at least 8 characters");}
                else { this.password = value; }
            }
        }

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
            Console.WriteLine("Password");
            for (int time = 0; time < 11; time++)
            {
                Console.Write(this.HeaderSymbol);
            }
            Console.WriteLine();


            if (!this.Hidden)
            {
                Console.WriteLine(this.Password);
            }
            else { Console.WriteLine("***"); }
            Console.WriteLine();
        }
        public bool ChangePassword(string passwordValidate, string newPassword)
        {
            if (passwordValidate == this.Password)
            {
                this.Password = newPassword;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            this.password = new String("");
            this.Hidden = false;
        }
    }
}