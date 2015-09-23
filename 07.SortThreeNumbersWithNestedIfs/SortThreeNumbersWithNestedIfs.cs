namespace _07.SortThreeNumbersWithNestedIfs
{
    using System;

    class SortThreeNumbersWithNestedIfs
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float biggest = a;
            float middle = b;
            float smallest = c;
            

            if (b > a)
            {
                biggest = b;
                middle = a;
                smallest = c;
            }
            if (c > b)
            {
                biggest = c;
                middle = b;
                smallest = a;
   
            }
            if (a > c)
            {
                biggest = a;
                middle = c;
                smallest = b;
            }
            Console.WriteLine("{0} {1} {2}",biggest, middle, smallest);
                

            }
                

        }
    }
//Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality. 
