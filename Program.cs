public class SumArray
{
    public static void Main(string[] args)
    {
        int[] array = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
        int total = 0;

        // add each element's value total
        for (int counter = 0; counter < array.Length; ++counter)
            total += array[counter];

        Console.WriteLine($"Total of array elements: {total}");
    } // end Main
} // end class SumArray
