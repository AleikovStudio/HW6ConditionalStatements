using System;

class NumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Please write 3 numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a>b && a>c)
        {
            if (b>c)
            {
                Console.WriteLine("Descending order A: " + a + " " + b + " " + c);
            }
            else
            {
                Console.WriteLine("Descending order A1: " + a + " " + c + " " + b);
            }
        }
        if (b>a && b>c)
        {
            if (a>c)
            {
                Console.WriteLine("Descending order B: " + b + " " + a + " " +c); 
            }
            else
            {
                Console.WriteLine("Descending order B1: " + b + " " + c + " " +a);
            }
        }
        if (c>a && c>b)
        {
            if (a>b)
            {
                Console.WriteLine("Descending order C: " + c + " " + a + " " + b); 
            }
            else
            {
                Console.WriteLine("Descending order C1: " + c + " " + b + " " + a);
            }
        }
    }
}
