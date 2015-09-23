namespace _09.PlayWithIntDoubleAndString
{
    using System;

    class PlayWithIntDoubleAndString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 -- > int");
            Console.WriteLine("1 -- > double");
            Console.WriteLine("1 -- > string");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Please enter a int:");
                int numberInt = int.Parse(Console.ReadLine());
                Console.WriteLine(numberInt + 1);
            }
            if (choice == 2)
            {
                Console.WriteLine("Please enter a double:");
                double numberDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(numberDouble + 1);
            }
            if (choice == 3)
            {
                Console.WriteLine("Please enter a string:");
                string word = Console.ReadLine();
                Console.WriteLine(word +"*");  
            }
            
        }
    }
}
//Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement. 