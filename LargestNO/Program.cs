using System;

namespace LargestNo
{
    class Program
    {
        public static void Main(String []arg)
        {
            int a;
            int b;
            int c;
            int large;

            //input the numbers
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            c = Convert.ToInt32(Console.ReadLine());

            //finding largest number using if-else
            if (a > b && a > c)
                large = a;
            else if (b > a && b > c)
                large = b;
            else large = c;
            Console.WriteLine("Largest no is "+large);   
        }
    }
}