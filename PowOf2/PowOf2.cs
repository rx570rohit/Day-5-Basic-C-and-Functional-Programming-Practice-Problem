using System;

namespace PowOf2
{
    class PowOf2
    {
        public static void  Main(String []arg)
        { 
            int N =Convert.ToInt32 (Console.ReadLine());

            if (N > 0 && N < 31)
            {
                for (int i = 0; i <= N; i++)
                    Console.WriteLine(2+" ^ "+ i +" = "+Math.Pow(2, i));
            }
            else { Console.WriteLine("Enter No in range 0 to 30"); }
        }
    }
}