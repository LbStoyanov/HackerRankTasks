namespace Pangram
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var result = pangrams(input);

            Console.WriteLine(result);
        }

        public static string pangrams(string input)
        {
            bool[] mark = new bool[26];

            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if ('A' <= input[i] && input[i] <= 'Z')
                {
                    index = input[i] - 'A';
                }
                else if ('a' <= input[i] && input[i] <= 'z')
                {
                    index = input[i] - 'a';
                }
                else
                {
                    continue;
                }

                mark[index] = true;
            }

            for (int i = 0; i <= 25; i++)
            {
                if (mark[i] == false)
                {
                    return "not pangram";
                }
            }

            return "pangram";
        }
    }
}