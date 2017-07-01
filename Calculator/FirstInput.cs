using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class FirstInput
    {

        public double FirstNumber { get; private set; }

        public double InputFirstNumber()
        {
        Console.WriteLine("Type you first number :");
        string FirstNumberInput = Console.ReadLine();
        FirstNumber = double.Parse(FirstNumberInput);
            return FirstNumber;
        }
    }   
}
