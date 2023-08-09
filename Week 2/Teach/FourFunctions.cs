namespace teach_02;

/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Teach - Problem 1
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class FourFunctions {
    public static void Run() {
        // Test CalculateFactorial
        Console.WriteLine("Test CalculateFactorial");
        Console.WriteLine(CalculateFactorial(4)); // Should print 24
        Console.WriteLine(CalculateFactorial(5)); // Should print 120

        Console.WriteLine("------------");

        // Test CalculateStats
        Console.WriteLine("Test CalculateStats");
        Console.WriteLine(CalculateStats(new[] { 1, 2, 3, 4, 5 }));
        Console.WriteLine(CalculateStats(new[] { 1, 2, 3 }));

        Console.WriteLine("------------");

        // Test PrintTriangle
        Console.WriteLine("Test PrintTriangle");
        PrintTriangle(5); // Print triangle with side length 5
        Console.WriteLine();
        PrintTriangle(8); // Print triangle with side length 8

        Console.WriteLine("------------");

        // Test PrintTriangle
        Console.WriteLine("Test DisplayLettersInNames");
        DisplayLettersInNames(new[] { "Bob", "Sue", "Tim" }); // Print out each letter one at a time
    }
    /// <summary>
    /// Calculate n! which equals n * (n-1) * (n-2) * ... * 2 * 1
    /// </summary>
    /// <param name="n">number specifying the n for n!</param>
    private static int CalculateFactorial(int n) //This is O(n)
    {
        var factorial = 1;
        for (var x = 1; x <= n; ++x)
            factorial *= x;

        return factorial;
    }

    /// <summary>
    /// Determine and return the length of the numbers list, the sum
    /// of all the numbers, and the average of the numbers.
    /// </summary>
    /// <returns>Tuple with the sum, count, and average of the supplied numbers</returns>
    private static Tuple<int, int, float> CalculateStats(int[] numbers) //This is O(2n) so just O(n)
    {
        var totalSum = 0;
        var count = 0;
        foreach (var number in numbers)
            totalSum += number;
        foreach (var number in numbers)
            count += 1;
        var average = ((float)totalSum) / count;
        return new Tuple<int, int, float>(totalSum, count, average);
    }

    /// <summary>
    /// Print a filled in isosceles triangle to the screen
    /// </summary>
    /// <param name="size">number of characters for the length of the side</param>
    private static void PrintTriangle(int size) // This is o(n^2)
    {
        for (var i = 0; i < size; ++i) {
            for (var j = 0; j <= i; ++j)
                Console.Write("*");
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Display each letter of each name in the list on a separate line
    /// </summary>
    /// <param name="names">array of names to display</param>
    private static void DisplayLettersInNames(string[] names) //THis is O(n^2)
    {
        foreach (var name in names)
        foreach (var letter in name)
            Console.WriteLine(letter);
    }
}