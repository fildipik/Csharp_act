using System;

namespace item10
{
    class act1_item10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your score (0-9): ");
            int inputScore = Int32.Parse(Console.ReadLine());
            int bonus;
            switch (inputScore)
            {
                case 1:
                    bonus = inputScore * 10;
                    Console.Write("Your bonus point is: {0}", bonus);
                    Console.ReadLine();
                    break;
                case 2:
                    bonus = inputScore * 10;
                    Console.WriteLine("Your bonus point is: {0}", bonus);
                    Console.ReadLine();
                    break;
                case 3:
                    bonus = inputScore * 10;
                    Console.WriteLine("Your bonus point is: {0}", bonus);
                    Console.ReadLine();
                    break;
                case 4:
                    bonus = inputScore * 100;
                    Console.WriteLine("Your bonus point is: {0}", bonus);
                    Console.ReadLine();
                    break;
                case 5:
                    bonus = inputScore * 100;
                    Console.WriteLine("Your bonus point is: {0}", bonus);
                    Console.ReadLine();
                    break;
                case 6:
                    bonus = inputScore * 100;
                    Console.WriteLine("Your bonus point is: {0}", bonus);
                    Console.ReadLine();
                    break;
                case 7:
                    bonus = inputScore * 1000;
                    Console.WriteLine("Your bonus point is: {0}", bonus);
                    Console.ReadLine();
                    break;
                case 8:
                    bonus = inputScore * 1000;
                    Console.WriteLine("Your bonus point is: {0}", bonus);
                    Console.ReadLine();
                    break;
                case 9:
                    bonus = inputScore * 1000;
                    Console.WriteLine("Your bonus point is: {0}", bonus);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Error: Incorrect Input.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}