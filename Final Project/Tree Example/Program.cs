using Tree_Files;

var unsortedNumbers = new[] { 5, 89, 52, 11, 3, 7, 81, 63 };
BinarySearchTree sortedTree = new BinarySearchTree();

foreach (var number in unsortedNumbers)
    sortedTree.Insert(number);

var sortedNumbers = new List<int>();
foreach (var value in sortedTree)
    sortedNumbers.Add(value);

Console.WriteLine("Unsorted Numbers");
foreach (var num in unsortedNumbers) Console.Write($"{num} ");
Console.WriteLine();
Console.WriteLine("Sorted Numbers");
foreach (var num in sortedNumbers) Console.Write($"{num} ");