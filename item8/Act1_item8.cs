using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace item8
{
    class act1_item8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter variable type (0 for int, 1 for double, 2 for string): ");
            int Var = Int32.Parse(Console.ReadLine());

            switch (Var)
            {
                case 0:
                    {
                        Console.Write("Enter int variable: ");
                        int varInt = Int32.Parse(Console.ReadLine());
                        varInt++;
                        Console.WriteLine("The output is= {0}", varInt);
                        Console.ReadLine();
                        break;
                    }
                case 1:
                    {
                        Console.Write("Enter double variable: ");
                        double varDouble = double.Parse(Console.ReadLine());
                        varDouble++;
                        Console.WriteLine("The output is = {0}", varDouble);
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter string variable: ");
                        string varString = Console.ReadLine();
                        varString = varString + '*';
                        Console.WriteLine("The output is= {0}", varString);
                        Console.ReadLine();
                        break;
                    }
                default: Console.WriteLine("Wrong input");Console.ReadLine(); break;
            }
        }
    }
}