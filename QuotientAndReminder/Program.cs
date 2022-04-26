using System;

namespace QuotientAndReminder
{
    class QuotentAndReminder
    {
        public static void Main(String []arg) {
            Console.WriteLine("Enter Dividend and divisor respectively");
        int dividend = Convert.ToInt32(Console.ReadLine());
        int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

        Console.WriteLine("Dividend:{0} Divisor:{1}",dividend,divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
            }
    }
}