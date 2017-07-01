using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class SecondInput
    {

        public double SecondNumber { get; private set; }

        public double InputSecondNumber()
        {
            Console.WriteLine("Type you second number :");
            string SecondNumberInput = Console.ReadLine();
            SecondNumber = Convert.ToDouble(SecondNumberInput);
            return SecondNumber;
        }
    } 
}
