namespace _01.ExchangeIfGreater
{
    using System;

    class ExchangeIfGreater
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number:");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float max = a;
            float min = b;

            if (a > b)
            {
                max = a;
                min = b;
            }
            if (a < b)
            {
                max = b;
                min = a;
            }
            Console.WriteLine("{0} {1}",min,max);
            
        }
    }
}
//Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space. 
