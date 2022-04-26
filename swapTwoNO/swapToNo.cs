using System;

namespace swapTwoNo
{
    class swapToNO
    {
        public static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a:"+a+" "+"b:"+b);
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("a:" + a + " " + "b:" + b);
        }
    }
}