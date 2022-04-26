using System;

namespace HarmonicNo
{
    class HarmonicNo
    {
        public static void Main(String []arg) 
        {
            int N = Convert.ToInt32(Console.Read()); 
            float harmonic = 1;

         
            for (int i = 2; i <= N; i++)
            {
                harmonic += (float)1 / i;
            }
            Console.WriteLine("Nth Harmonic No : "+harmonic );
        }
    }
}
