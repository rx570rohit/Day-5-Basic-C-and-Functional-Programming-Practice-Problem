using System;

namespace FlipCoin
{
    class FlipCoinMain
    {    static Random rnd = new Random();
        public static void Main(String [] arg)
        {   int head = 0; int tail = 0; 
            int NumOfTimeCoinFlip = Convert.ToInt32(Console.ReadLine());
            if (NumOfTimeCoinFlip > 0)
            {
                for (int i = 0; i < NumOfTimeCoinFlip; i++)
                {

                    double x = rnd.NextDouble();
                    if (x < 0.5)
                    {
                        head++;
                    }
                    else if (x > 0.5) { tail++; }
                    else { Console.WriteLine("match draw"); }



                }
                Console.WriteLine("(head to tail ) % = " + (head / tail) * 100);
            }
            else { Console.WriteLine("please enter positive no "); }

            
        }
    }
}