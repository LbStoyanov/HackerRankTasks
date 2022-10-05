using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Task_04
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            //Given an array of integers, where all elements but one occur twice, find the unique element.
            //Complete the lonely integer function in the editor below.
            //lonely integer has the following parameter(s):
            //int a[n]: an array of integers

            //int n = int.Parse(Console.ReadLine());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = lonelyinteger(a);

            Console.WriteLine(result);

        }

        public static int lonelyinteger(List<int> a)
        {
            var dict = new Dictionary<int, int>();
            
            for (int i = 0; i < a.Count; i++)
            {
                if (!dict.ContainsKey(a[i]))
                {
                    dict.Add(a[i],0);
                }

                dict[a[i]]++;
            }

            int result = 0;

            foreach (var kvp in dict)
            {
                if (kvp.Value == 1)
                {
                    result = kvp.Key;
                }
            }

            
            return result;
        }   
    }
}
