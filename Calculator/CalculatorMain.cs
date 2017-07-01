using System;

namespace Calculator
{
    class CalculatorMain
    {
        static void Main(string[] args)
        {

            FirstInput firstNum = new FirstInput();
            SecondInput secondNum = new SecondInput();
            Operation operation = new Operation();


            double answer;
            answer =  operation.InputOperation(firstNum.InputFirstNumber(), secondNum.InputSecondNumber());

            //Output
            Console.WriteLine("\nResult of " + firstNum.FirstNumber+ " " + operation.operationInput  + " " 
                + secondNum.SecondNumber + " = " + answer + ".");
            Console.ReadKey();
        }
    }
}