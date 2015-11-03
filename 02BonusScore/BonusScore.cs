using System;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Please enter integer between 1 and 9: ");
        int a = int.Parse(Console.ReadLine());

        if (a == 1 || a == 2 || a == 3)
        {
            Console.WriteLine("The BONUS score is: {0}", (a * 10));
        }
        else if (a == 4 || a == 5 || a == 6)
        {
            Console.WriteLine("The BONUS score is: {0}", (a * 100));
        }
        else if (a == 7 || a == 8 || a == 9)
        {
            Console.WriteLine("The BONUS score is: {0}", (a * 1000));
        }
        else
        {
            Console.WriteLine("Invalid score!");
        }
    }
}

//DRUGO RESHENIE SAS SWITCH CASE
//using System;

//class BonusNumber
//{
//    static void Main()
//    {
//        Console.WriteLine("Please write a number between 1 and 9: ");
//        int a = int.Parse(Console.ReadLine());

//        switch (a)
//        {
//            case 1: 
//            case 2:
//            case 3: 
//                Console.WriteLine("The BONUS score is: " + (a * 10));
//                break;
//            case 4:
//            case 5:
//            case 6:
//                Console.WriteLine("The BONUS score is: " + (a * 100));
//                break;
//            case 7:
//            case 8:
//            case 9:
//                Console.WriteLine("The BONUS score is: " + (a*1000));
//                break;
//            default:
//                Console.WriteLine("Invalid Score!");
//                break;

//        }
//    }
//}

