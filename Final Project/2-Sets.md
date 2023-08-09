# Sets

## Introduction
A set data structure is a collection of unique elements, where each element appears only once in the set. Unlike other data structures like arrays or lists, sets do not preserve any specific order or index for the elements. The primary purpose of a set is to provide efficient membership testing and eliminate duplicates.

Key characteristics of a set data structure are as follows:

* Uniqueness 
  * A set guarantees that each element it contains is unique. If you attempt to add a duplicate element to a set, it will be ignored since it already exists.

* No specific order 
  * The elements in a set are not stored in any particular order. Therefore, you cannot access elements by index like you would in an array or list.

* Fast membership testing
  * One of the main benefits of a set is its efficiency in checking whether an element exists in the set or not. Sets are designed to perform membership tests quickly, even for large collections of elements.

* Dynamic size 
  * Sets can dynamically grow or shrink as elements are added or removed.

![](https://media.geeksforgeeks.org/wp-content/uploads/20230504134511/insert.png)

When trying to visualize a set, think of a teenage boy's room. There is **a lot** of stuff. When someone else walks into the room, there appears to be no order and it is absolute chaos.
When you need to find something, you look in every place. This would be like iterating through all of a list until you find what you want. That is inefficient. 

Have you ever seen the boy go through his room? He knows where everything is! You ask him where his shoes are, he goes directly to the bottom left drawer that also has some of his hats. 
It doesn't matter how unorganized it is, **he** knows where everything is. Let's say he wants his favorite shirt, if it isn't exactly where it should be, he knows it's missing.

These examples demonstrate how sets work. The set has a hashing algorithm that organizes data. To the hash set, there is an order. This allows the efficiency to be high for set operations, as seen in the table below. 

![](https://previews.123rf.com/images/klotz/klotz1809/klotz180900006/107715037-cluttered-messy-teenage-boys-bedroom-with-piles-of-clothes-music-and-sports-equipment.jpg)

### Common Operations:

| Operation | What it Does                                     | Syntax               | Big O  |
|-----------|--------------------------------------------------|----------------------|--------|
| Add       | Add something to the set                         | Set.Add(value)       | O(1)   |
| Remove    | Remove something from the set                    | Set.Remove(value)    | O(1)   |
| Has       | See if something is in the set                   | Set.Contains(value)  | O(1)   |
| Size      | Find out how many items are in stack             | Set.Count()          | O(1)   |


## Example: Union & Intersection of Data Sets

Below you will find an example of how to use sets to perform the union and intersection operators.
Union is to combine two data sets together, however, there are to be no duplicates. Intersection is an operator to find what is in both of the data sets.

```csharp
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
        foreach (int number in set1)  // Iterate through first set
        {
            if (set2.Contains(number))  // If it is in both sets
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
```

## Problem to Solve: Making and Combining Playlists
Your task is to make a program to allow a user to make and combine playlists together. 

Give them options to add songs to playlists, make a new playlist, and combine playlists to make a new playlist. 

When you are done, review the solution here: [Solution](Set Solution)

[Back to Welcome](0-Welcome.md)