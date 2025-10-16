using System;
using System.Collections.Generic;

class Program
{
    public delegate bool NumberCondition(int number);

    public static bool IsEven(int number) => number % 2 == 0;
    public static bool IsOdd(int number) => number % 2 != 0;
    public static bool IsGreaterThanTen(int number) => number > 10;

    public static void PrintMatchingNumbers(int start, int end, NumberCondition condition)
    {
        for (int i = start; i <= end; i++)
        {
            if (condition(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    public static int CountMatchingNumbers(int start, int end, NumberCondition condition)
    {
        int count = 0;
        for (int i = start; i <= end; i++)
        {
            if (condition(i))
            {
                count++;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Please provide start and end numbers as command-line arguments.");
            return;
        }

        int start = int.Parse(args[0]);
        int end = int.Parse(args[1]);

        Console.WriteLine("Even Numbers:");
        PrintMatchingNumbers(start, end, IsEven);

        Console.WriteLine("\nOdd Numbers:");
        PrintMatchingNumbers(start, end, IsOdd);

        Console.WriteLine("\nNumbers Greater Than 10:");
        PrintMatchingNumbers(start, end, IsGreaterThanTen);

        Console.WriteLine($"\nCount of Numbers Greater Than 10: {CountMatchingNumbers(start, end, IsGreaterThanTen)}");
    }
}
