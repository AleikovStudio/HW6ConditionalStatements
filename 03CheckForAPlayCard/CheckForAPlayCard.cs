using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.WriteLine("Please enter the play card symbol: ");
        string playCard = Console.ReadLine();

        //2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A

        if (playCard == "2" || playCard == "3" || playCard == "4" || playCard == "5" || playCard == "6" || playCard == "7" || playCard == "8" || playCard == "9" || playCard == "10" || playCard == "J" || playCard == "Q" || playCard == "K" || playCard == "A")
        {
            Console.WriteLine("\"YES!\" - Valid playing card!");
        }
        else
        {
            Console.WriteLine("\"NO\" - This is not a playing card!");
        }
    }
}

// DRUGO RESHENIE SAS SWITCH CASE
//using System;

//class CheckForAPlayCard
//{
//    static void Main()
//    {
//        Console.WriteLine("Please enter the playing card: ");
//        string playCard = Console.ReadLine();

//        switch (playCard)
//        {
//            case "2":
//            case "3":
//            case "4":
//            case "5":
//            case "6":
//            case "7":
//            case "8":
//            case "9":
//            case "10":
//            case "J":
//            case "Q":
//            case "K":
//            case "A":
//                Console.WriteLine("YES");
//                break;
                            
//            default:
//                Console.WriteLine("NO");
//                break;
//        }
//    }
//}
