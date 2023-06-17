// Define IDisplayable in this file

using System;

namespace SavingInterface
{
    interface IDisplayable
    {
        //PROPERTIES
        string HeaderSymbol { get; }

        // METHODS
        void Display();
    }
}