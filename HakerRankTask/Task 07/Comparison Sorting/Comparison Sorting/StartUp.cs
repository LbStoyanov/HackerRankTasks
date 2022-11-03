namespace Comparison_Sorting
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Quicksort usually has a running time of n x log(n) , but is there an algorithm that can sort even faster? In general, this is not possible.
            //Most sorting algorithms are comparison sorts, i.e. they sort a list just by comparing the elements to one another. A comparison sort algorithm
            //cannot beat n x log(n) (worst-case) running time, since n x log(n)  represents the minimum number of comparisons needed to know where to place each element.
            
            //Input:


            int n = int.Parse(Console.ReadLine());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = CountingSort(arr);

            Console.WriteLine(String.Join(" ", result));

        }

        public static List<int> CountingSort(List<int> arr)
        {

            int[] result = new int[100];

            for (int i = 0; i < arr.Count; i++)
            {
                result[arr[i]]++;
            }

            return result.ToList();

            //int[] result = new int[100];

            //arr.ForEach(a => result[a]++);

            //return result.ToList();

        }
    }
}