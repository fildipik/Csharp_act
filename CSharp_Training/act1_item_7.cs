using System;

namespace CSharp_Training
{
    class act1_item_7
    { 
    static int[] GetNumbers()
        { 
        int[] arr = new int[5];

        for (int ctr = 0; ctr < 5; ctr++)
             {
            Console.WriteLine("Enter number {0}", ctr + 1);
            string input = Console.ReadLine();

            int x;
            if (int.TryParse(input, out x) == true)
            {
                arr[ctr] = x;
            }
            else
            {
                arr[ctr] = 0;
            }

        }

        return arr;
    }

    static int GreatestNum(int[] arr)
    {
        int greatest = 0;
        foreach (var item in arr)
        {

            if (item > greatest)
                greatest = item;
        }

        return greatest;
    }

    static void Main(string[] args)
    {
        int[] numbers = GetNumbers();

        Console.WriteLine("Here are our numbers:");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("The greatest of them all: {0}", GreatestNum(numbers));


        Console.Read();

    }
}

}