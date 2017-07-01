using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace item11
{
    class Act1_item11
    {

        static void Main(string[] args)
        {
            //Reading INput
            Console.Write("Enter a number between 0 and 999: ");
            int num = Int32.Parse(Console.ReadLine());

            //Getting the Third digit of the number
            int thirdDigit = (num / 100 | 0);
            int secondDigit;

            //Getting the second digit along with the first digit
            if (num > 99)
            {
                secondDigit = (num % 100);
            }
            else
            {
                secondDigit = num;
            };

            //Getting the first digit
            int firstDigit = (num % 10);

            //Converting third digit to strings
            switch (thirdDigit)
            {
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundred "); break;
                case 3: Console.Write("Three hundred "); break;
                case 4: Console.Write("Four hundred "); break;
                case 5: Console.Write("Five hundred "); break;
                case 6: Console.Write("Six hundred "); break;
                case 7: Console.Write("Seven hundred "); break;
                case 8: Console.Write("Eight hundred "); break;
                case 9: Console.Write("Nine hundred "); break;
            }

            //Converting the second digit to strings
            if (thirdDigit >= 1 && secondDigit >= 1) Console.Write("and ");

            if (secondDigit >= 20 && secondDigit < 30) Console.Write("Twenty"); 

            else if (secondDigit >= 30 && secondDigit < 40) Console.Write("Thirty");
            else if (secondDigit >= 40 && secondDigit < 50) Console.Write("Fourty");
            else if (secondDigit >= 50 && secondDigit < 60) Console.Write("Fifty");
            else if (secondDigit >= 60 && secondDigit < 70) Console.Write("Sixty");
            else if (secondDigit >= 70 && secondDigit < 80) Console.Write("Seventy");
            else if (secondDigit >= 80 && secondDigit < 90) Console.Write("Eighty");
            else if (secondDigit >= 90 && secondDigit < 100) Console.Write("Ninety");

            //special cases for numbers from 11-19
            switch (secondDigit)
            {
                case 1: Console.Write("one"); break;
                case 2: Console.Write("two"); break;
                case 3: Console.Write("three"); break;
                case 4: Console.Write("four"); break;
                case 5: Console.Write("five"); break;
                case 6: Console.Write("six"); break;
                case 7: Console.Write("seven"); break;
                case 8: Console.Write("eight"); break;
                case 9: Console.Write("nine"); break;
                case 10: Console.Write("ten"); break;
                case 11: Console.Write(" eleven"); break;
                case 12: Console.Write(" twelve"); break;
                case 13: Console.Write(" thirteen"); break;
                case 14: Console.Write(" fourteen"); break;
                case 15: Console.Write(" fifteen"); break;
                case 16: Console.Write(" sixteen"); break;
                case 17: Console.Write(" seventeen"); break;
                case 18: Console.Write(" eighteen"); break;
                case 19: Console.Write(" nineteen"); break;
            }
            if (secondDigit > 20)
            {
                //Converting first digit to strings
                switch (firstDigit)
                {
                    case 1: Console.Write(" one"); break;
                    case 2: Console.Write(" two"); break;
                    case 3: Console.Write(" three"); break;
                    case 4: Console.Write(" four"); break;
                    case 5: Console.Write(" five"); break;
                    case 6: Console.Write(" six"); break;
                    case 7: Console.Write(" seven"); break;
                    case 8: Console.Write(" eight"); break;
                    case 9: Console.Write(" nine"); break;
                }
            }
            if (num == 0) Console.Write("Zero");
            Console.ReadLine();
        }
    }
}