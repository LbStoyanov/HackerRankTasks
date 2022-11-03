using System;

namespace Task_05
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            //You will be given a list of 32 bit unsigned integers.
            //Flip all the bits (1 -> 0 and 0 -> 1) and return the result as an unsigned integer.
            int queriessCount = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < queriessCount; i++)
            {
                long n = long.Parse(Console.ReadLine());

                Console.WriteLine(flippingBits(n));
            }


        }

        public static long flippingBits(long n)
        {
            return (long)(Math.Pow(2,32)) - 1 - n;
        }
    }
}
