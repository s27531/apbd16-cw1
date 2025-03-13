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

    }

    public static double GetAverage(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++) {
            sum += numbers[i];
        }

        return sum / (double) numbers.Length;
    }
}