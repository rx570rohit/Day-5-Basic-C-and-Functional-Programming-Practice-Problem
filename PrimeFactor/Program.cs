using System;

namespace PrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int i, j;
            int count = 0;
            int flag = 0;

            Console.Write("Prime factor of {0}:\n", num);
            for (i = 2; i < num; i++)
            {
               
                if (num % i == 0)
                {
                    count = 0;
                    for (j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            count++;
                    }
                    if (count == 2)
                    {
                        flag = 1;
                        Console.Write(i + " ");
                    }
                }
            }

            if (flag == 0)
                Console.Write("There is no Prime factor for {0} ", num);
        }
    }
}
