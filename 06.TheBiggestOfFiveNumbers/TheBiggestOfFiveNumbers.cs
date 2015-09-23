namespace _05.TheBiggestOfFiveNumbers
{
    using System;

    class TheBiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            float e = float.Parse(Console.ReadLine());
            float max = a;

            if (b > a)
            {
                max = b;
            }
            if (c > b)
            {
                max = c;
            }
            if (d > c)
            {
                max = d;
            }
            if (e > d)
            {
                max = e;
            }
            if (a > e)
            {
                max = a;
            }
            Console.WriteLine(max);
        }
    }
}
//Write a program that finds the biggest of five numbers by using only five if statements. 