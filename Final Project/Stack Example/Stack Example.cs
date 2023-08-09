namespace DefaultNamespace;

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
                // Move car back to the main line using stack operations
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