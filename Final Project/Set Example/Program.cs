
public static class SetExample
{
    public static void Run()
    { 
        var s1 = new HashSet<int>(new[] { 1, 2, 3, 4, 5, 6, 7 });
        var s2 = new HashSet<int>(new[] { 4, 5, 6, 7, 8, 9, 10 });
        Console.WriteLine(Intersection(s1, s2).AsString()); 
        Console.WriteLine(Union(s1, s2).AsString()); 
    }
    // Performs a set union operation.
    private static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2)
    {
        var result = new HashSet<int>();
        // Add all of first set
        foreach (int number in set1)
        {
            result.Add(number);
        }

        // Add items from second set not in first set
        foreach (var number in set2)
        {
            if (set1.Contains(number) == false)
            {
                result.Add(number);
            }
        }

        return result;
    }

// Performs a set intersection operation.

    private static HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2)
    {
        var intersection = new HashSet<int>();
        foreach (int number in set1)
        {
            if (set2.Contains(number))
            {
                intersection.Add(number);
            }
        }

        return intersection;
    }
    public static string AsString(this System.Collections.IEnumerable set) {
        return "<Set>{" + string.Join(", ", (HashSet<int>)set) + "}";
    }
}