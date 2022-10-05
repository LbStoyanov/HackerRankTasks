using System;
using System.Collections.Generic;
using System.Linq;
// ReSharper disable All

namespace Task_03
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            //There is a collection of input strings and a collection of query strings.
            //For each query string, determine how many times it occurs in the list of input strings.
            //Return an array of the results.

            int inputCount = int.Parse(Console.ReadLine());
            var inputList = new List<string>();

            for (int i = 0; i < inputCount; i++)
            {
                var input = Console.ReadLine();
                inputList.Add(input);
            }

            int queryCount = int.Parse(Console.ReadLine());
            var queries = new List<string>();

            for (int i = 0; i < queryCount; i++)
            {
                var input = Console.ReadLine();
                queries.Add(input);
            }

            var result = MatchingStrings(inputList, queries);
            Console.WriteLine(String.Join("\n",result));

        }

        public static List<int> MatchingStrings(List<string> strings, List<string> queries)
        {
            var result = new List<int>();
            var queryDict = new Dictionary<string, int>();

            for (int i = 0; i < queries.Count; i++)
            {
                var currentQuery = queries[i];

                result.Add(0);

                //if (!queryDict.ContainsKey(currentQuery))
                //{
                //    queryDict.Add(currentQuery, 0);
                //}

                for (int j = 0; j < strings.Count; j++)
                {
                    var currentString = strings[j];
                    
                    if (currentQuery == currentString)
                    {
                        result[i]++;
                        //queryDict[currentQuery]++;
                    }
                }
            }

            //foreach (var query in queryDict)
            //{
            //    result.Add(query.Value);
            //}

            
            return result;
        }

    }
}
