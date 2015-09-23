using System;

class NumberAsWords
{
    static void Main() // решение на асистенката от софтуни
    {
        Console.WriteLine("Please type a number (0-999)");
        int Num = int.Parse(Console.ReadLine());
        int dig1 = Num % 10;
        int dig2 = (Num / 10) % 10;
        int dig3 = (Num / 100) % 10;

        if (Num <= 999 && Num >= 0)
        {
            //DIG3
            if (dig3 != 0)
            {
                switch (dig3)
                {
                    case 0:
                        Console.Write("");
                        break;
                    case 1:
                        Console.Write("One hundred");
                        break;
                    case 2:
                        Console.Write("Two hundred");
                        break;
                    case 3:
                        Console.Write("Three hundred");
                        break;
                    case 4:
                        Console.Write("Four hundred");
                        break;
                    case 5:
                        Console.Write("Five hundred");
                        break;
                    case 6:
                        Console.Write("Six hundred");
                        break;
                    case 7:
                        Console.Write("Seven hundred");
                        break;
                    case 8:
                        Console.Write("Eight hundred");
                        break;
                    case 9:
                        Console.Write("Nine hundred");
                        break;

                    default:
                        break;
                }
            }

            //DIG2
            if (dig3 != 0)
            {
                Console.Write(" and ");
            }
            switch (dig2)
            {
                case 0:
                    Console.Write("");
                    break;
                case 1:
                    switch (dig1)
                    {
                        case 0:
                            // Console.Write("{0} ", dig3 == 0 ? "Ten" : "ten");
                            string asWord = "ten";
                            Console.Write("{0} ", dig3 == 0 ? UppercaseFirst(asWord) : asWord);
                            break;
                        case 1:
                            Console.Write("{0} ", dig3 == 0 ? "Eleven" : "eleven");
                            break;
                        case 2:
                            Console.Write("{0} ", dig3 == 0 ? "Twelve" : "twelve");
                            break;
                        case 3:
                            Console.Write("{0} ", dig3 == 0 ? "Thirteen" : "thirteen");
                            break;
                        case 4:
                            Console.Write("{0} ", dig3 == 0 ? "Fourteen" : "fourteen");
                            break;
                        case 5:
                            Console.Write("{0} ", dig3 == 0 ? "Fifteen" : "fifteen");
                            break;
                        case 6:
                            Console.Write("{0} ", dig3 == 0 ? "Sixteen" : "sixteen");
                            break;
                        case 7:
                            Console.Write("{0} ", dig3 == 0 ? "Seventeen" : "seventeen");
                            break;
                        case 8:
                            Console.Write("{0} ", dig3 == 0 ? "Eighteen" : "eighteen");
                            break;
                        case 9:
                            Console.Write("{0} ", dig3 == 0 ? "Nineteen" : "nineteen");
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    Console.Write("{0} ", dig3 == 0 ? "Twenty" : "twenty");
                    break;
                case 3:
                    Console.Write("{0} ", dig3 == 0 ? "Thirty" : "thirty");
                    break;
                case 4:
                    Console.Write("{0} ", dig3 == 0 ? "Fourty" : "fourty");
                    break;
                case 5:
                    Console.Write("{0} ", dig3 == 0 ? "Fifty" : "fifty");
                    break;
                case 6:
                    Console.Write("{0} ", dig3 == 0 ? "Sixty" : "sixty");
                    break;
                case 7:
                    Console.Write("{0} ", dig3 == 0 ? "Seventy" : "seventy");
                    break;
                case 8:
                    Console.Write("{0} ", dig3 == 0 ? "Eighty" : "eighty");
                    break;
                case 9:
                    Console.Write("{0} ", dig3 == 0 ? "Ninety" : "ninety");
                    break;

                default:
                    break;
            }

            //dig1
            if (dig2 != 1 && dig1 != 0)
            {
                //if (dig2 != 0 && dig3 != 0)
                //{
                //    Console.Write(" ");                    
                //}                
                switch (dig1)
                {
                    case 0:
                        Console.Write("");
                        break;
                    case 1:
                        Console.Write("{0} ", dig3 == 0 ? "One" : "one");
                        break;
                    case 2:
                        Console.Write("{0} ", dig3 == 0 ? "Two" : "two");
                        break;
                    case 3:
                        Console.Write("{0} ", dig3 == 0 ? "Three" : "three");
                        break;
                    case 4:
                        Console.Write("{0} ", dig3 == 0 ? "Four" : "four");
                        break;
                    case 5:
                        Console.Write("{0} ", dig3 == 0 ? "Five" : "five");
                        break;
                    case 6:
                        Console.Write("{0} ", dig3 == 0 ? "Six" : "six");
                        break;
                    case 7:
                        Console.Write("{0} ", dig3 == 0 ? "Seven" : "seven");
                        break;
                    case 8:
                        Console.Write("{0} ", dig3 == 0 ? "Eight" : "eight");
                        break;
                    case 9:
                        Console.Write("{0} ", dig3 == 0 ? "Nine" : "nine");
                        break;

                    default:
                        break;
                }
            }

            if (dig1 == 0 && dig2 == 0 && dig3 == 0)
            {
                Console.Write("Zero");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }

    static string UppercaseFirst(string s)
    {
        return char.ToUpper(s[0]) + s.Substring(1);
    }
}