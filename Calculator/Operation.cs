using System;


namespace Calculator
{
    class Operation
    {



        public static double operation;
        public string operate;

        public string operationInput
        {
            get
            {
                return operate;
            }
            set
            {
                operate = value;
            }
        }
        public double InputOperation(double FirstInput, double SecondInput)
        {
            Console.WriteLine("Enter the operation + (addition), - (subtraction), * (multiplication), / (division):");
            operationInput = Console.ReadLine();

            if (operationInput == "+" || operationInput == "addition")
            {
                operation = FirstInput + SecondInput;
            }
            else if (operationInput == "-" || operationInput == "subtraction")
            {
                operation = FirstInput - SecondInput;
            }
            else if (operationInput == "*" || operationInput == "multiplication")
            {
                operation = FirstInput * SecondInput;
            }
            else if (operationInput == "/" || operationInput == "division")
            {
                operation = FirstInput / SecondInput;
            }
            return operation;
        }
    }
}
