internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("abc");
        Console.WriteLine("cba");

        int[] nums = { 1, 2, 3, 4, 5, 2 };
        double avg = GetAverage(nums);
        Console.WriteLine("Avg: " + avg);
        Console.WriteLine($"Max: {FindMax(nums)}");
    }

    public static double GetAverage(int[] numbers)
    {
        int sum = 0;
        for (int j = 0; j < numbers.Length; j++) {
            sum += numbers[j];
        }

        return sum / (double) numbers.Length;
    }

    public static int FindMax(int[] numbers)
    {
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }
}