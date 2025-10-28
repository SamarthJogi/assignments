using System;
using InvestmentApp;

class Program
{
    static void Main()
    {
        Console.WriteLine("\n\t==Investment Program==");

        Investment inv1 = new Investment();
        inv1.Amount = 10000;
        inv1.Rate = 5.5;
        inv1.Period =3;
        inv1.Print();
        Console.WriteLine($"Simple Interest : {inv1.GetInterest():0.00}");
        Console.WriteLine();

        Investment inv2 = new Investment(5000 , 8.5 ,5);
        inv2.Print();
        Console.WriteLine($"Simple Interest : {inv2.GetInterest():0.00}");
    }
}