namespace _03.CheckForAPlayCard
{
    using System;

    class CheckForAPlayCard
    {
        static void Main()
        {
            string c = (Console.ReadLine());

            if (c == "A" || c == "J" || c == "K" || c == "Q"|| c== "2"|| c=="3"||c=="4"||c=="5"||c=="6"||c=="7"||c=="8"||c=="9"||c=="10")

            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
//Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples: