﻿using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Enter a time in format “hh:mm tt”:");
        string timeString = Console.ReadLine();
        string format = "h:mm tt";
        DateTime enterTime = DateTime.ParseExact(timeString,
        format, CultureInfo.InvariantCulture);
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("2:59 AM");
        if (enterTime >= startTime || enterTime <= endTime)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }

}