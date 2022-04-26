using System;

namespace EvenOdd
{
    class Program
    {
        public static void Main(String [] arg)
        {
            int n = Convert.ToInt32(Console.ReadLine()); 
            if ((n & 1) != 1)
            {
                Console.WriteLine(n +" is "+"Even No");
            }
            else Console.WriteLine(n + " is " + "Odd No");
        }
    }
}