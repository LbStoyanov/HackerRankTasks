namespace Task_01;

internal class StartUp
{
    private static void Main(string[] args)
    {
        //Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.
        //Then print the respective minimum and maximum values as a single line of two space-separated long integers.

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);

        //Input => 256741038 623958417 467905213 714532089 938071625
        //Output => 2063136757 2744467344
    }


}

class Result
{
    public static void miniMaxSum(List<int> arr)
    {
        long minSum = 0;
        long maxSum = 0;

        arr.Sort();
        for (int i = 0; i < 4; i++)
        {
            minSum += arr[i];
        }

        arr.Reverse();
        

        for (int i = 0; i < 4; i++)
        {
            maxSum += (arr[i]);
        }

        Console.Write($"{minSum} {maxSum}");
        

    }
}