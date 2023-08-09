namespace Stack_Solution;

public class Music_History_Solution
{
    public static void Run()
    {
        var songHistory = new Stack<string>();
        var command = "0";

        while (command != "4" )
        {
            Console.WriteLine();
            System.Console.WriteLine("1) Add Song \n2) Last Song \n3) View History\n4) Quit");
            System.Console.Write("Choice: ");
            command = Console.ReadLine();

            if (command == "1")
            {
                //Get Info
                System.Console.Write("What is the name of the song? ");
                var name = Console.ReadLine();
                // Add Test
                songHistory.Push(name);
            }
            else if (command == "2")
            {
                // Move car back to the main line using stack operations
                if (songHistory.Count != 0)
                {
                    var song = songHistory.Pop();
                    Console.Write($"Last song listened to: {song} ");
                }
                else Console.WriteLine("No songs in history");
            }
            else if (command == "3")
            {
                int count = 0;
                foreach (var song in songHistory )
                {
                    if (count == 10) break;
                    Console.WriteLine(song);
                    count++;
                }
            }
            else if (command == "4")
            {
                Console.Write("Quitting...");
            }
        }
    }
}