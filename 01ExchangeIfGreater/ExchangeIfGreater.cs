using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Please write your 1st number: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Please write your 2nd number: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            a = b;
            b = a;
            Console.WriteLine(b+ " " + a);
        }
        else
        {
            Console.WriteLine(a + " " + b);
        }
    }
}
