# Stacks

### Introduction
Stacks are seen all around in our daily lives. We all, even though we shouldn't, have stacks of papers and books on our desks. We all love to see the tower of pancakes on our plates in the morning. That's a stack!

A stack is a fundamental data structure in computer science that follows the Last In, First Out (LIFO) principle. It is an ordered collection of elements where you can add or remove at only one end called the "top." 

The stack operates like a physical stack of objects, where you can only access the topmost item.
Imagine a stack of books. You can only place a book on top of the stack or remove the topmost book. The last book placed on the stack is the first book that can be removed. If you want the bottom book, you have to first remove all of the books on top one at a time. This analogy helps illustrate the LIFO behavior of a stack.

![](stack-of-books-vector-1027951.jpg)

### Operations


| Operation  | What it Does                                       | Syntax               | Big O  |
|------------|----------------------------------------------------|----------------------|--------|
| push       | Add something to the stack                         | Stack.Push(value)    | O(1)   |
| pop        | Take off whatever is on the top                    | Stack.Pop()          | O(1)   |
| peek       | See what is at the top without removing it         | Stack.Peek()         | O(1)   |
| size       | Find out how many items are in stack               | Stack.Count()        | O(1)   |
| empty      | If the stack contains anything (Returns boolean)   | if (Stack.Count ==0) | O(1)   |


### Example: Papers to Grade

![](istockphoto-527525264-612x612.jpg)

Imagine you are a teacher before everything is online. You would have a **_stack_** of tests to grade. The person on top was the last person to finish and the person on the bottom was the first to finish.
When you are grading this, you will grade the top first and the bottom last.

For this, we will have 2 stacks. One will be the stack of ungraded tests. The other will be a stack of graded tests. We need a program that will allow tests to be turned in (added to ungraded pile) and graded (removed from ungraded and moved to graded).

```csharp
public static class Papers
{
    public static void Run()
    {
        var ungraded = new Stack<string>();
        var graded = new Stack<List<string>>();
        var command = "0";

        while (command != "4" )
        {
            Console.WriteLine();
            System.Console.WriteLine("1) Add Test \n2) Grade Test \n3) See Grades\n4) Quit");
            System.Console.Write("Choice: ");
            command = Console.ReadLine();

            if (command == "1")
            {
                //Get Info
                System.Console.Write("What is the name? ");
                var name = Console.ReadLine();
                // Add Test
                ungraded.Push(name);
            }
            else if (command == "2")
            {
                // Grade Test
                if (ungraded.Count != 0)
                {
                    var test = ungraded.Pop();
                    Console.Write($"Grade for {test}: ");
                    var grade = Console.ReadLine();
                    var testGrade = new List<string>(new[] { test, grade });
                    graded.Push(testGrade);
                }
                else Console.WriteLine("No tests to grade");
            }
            else if (command == "3")
            {
            // Display each graded test
                foreach (var test in graded )
                {
                    Console.WriteLine($"{test[0]}: {test[1]}");
                }
            }
            else if (command == "4")
            {
                Console.Write("Quitting...");
            }
        }
    }
}
```

### Problem to Solve: Music History

Our goal in this project is to highlight uses of data structures in a music player application. One key use of stacks could be in the history. 
Suppose you want to go to the last played song, you would just go to the top of the stack. What if you want to go further? Just keep popping the last song. 

Your job is to make a program that allows a user to:
* Add a song in the history
* Pull up the most recent song
* View the last 10 songs listened to

When you are done, review the solution here: [Solution](Stack Solution)

[Back to Welcome](0-Welcome.md)