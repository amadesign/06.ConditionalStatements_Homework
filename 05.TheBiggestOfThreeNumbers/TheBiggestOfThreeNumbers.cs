namespace _05.TheBiggestOfThreeNumbers
{
    using System;

    class TheBiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float max = a;

            if (b > a)
            {
                max = b;
            }
            if (c > b)
            {
                max = c;
            }
            if (a > c)
            {
                max = a;
            }
            Console.WriteLine(max);
        }
    }
}
//Write a program that finds the biggest of three numbers.