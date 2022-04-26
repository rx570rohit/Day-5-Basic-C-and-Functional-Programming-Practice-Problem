using System;

namespace LeapYear
{
    class LeapYear {
        static void Main(string[] args)
        {
            var Year = Console.ReadLine();
            int varl  = Year.Length;

            if (varl == 4)
            {
                int year = Convert.ToInt32(Year);
                if (year % 4 == 0)
                {
                    if ((year % 100 == 0) && (year % 400 != 0))
                        Console.Write("{0} is not a leap year", year);
                    else
                        Console.Write("{0} is a leap year", year);
                }
                else
                    Console.Write("{0} is not a leap year", year);
            }
            else Console.WriteLine("Please Enter A Valid Year ");
        }
    }
}
