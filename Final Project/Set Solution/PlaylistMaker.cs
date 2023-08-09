PlaylistProgram.Run();


public static class PlaylistProgram
{
    public static void Run()
    {
        List<(string,HashSet<string>)> playlists = new List<(string,HashSet<string>)>();
        var choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("1) Make new Playlist \n2) Add Song to Playlist \n3) Combine Playlists \n4) Display Playlist \n5) Quit");
            choice = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    var newPlaylist = MakePlaylist();
                    playlists.Add(newPlaylist);
                    break;
                case 2:
                    Console.WriteLine("Which playlist would you like to add a song to (input number)? ");
                    int i = 1;
                    foreach (var playlist in playlists)
                    {
                        Console.WriteLine($"{i}) {playlist.Item1}");
                        i++;
                    }

                    int number = Int32.Parse(Console.ReadLine()) -1;
                    Console.WriteLine($"You chose: {playlists[number].Item1} \nWhat song would you like to add? ");
                    var song = Console.ReadLine();
                    AddSong(playlists[number].Item2,song);
                    break;
                case 3:
                    i = 1;
                    foreach (var playlist in playlists)
                    {
                        Console.WriteLine($"{i}) {playlist.Item1}");
                        i++;
                    }

                    Console.WriteLine("What is the first playlist you would like to combine? (Input number) ");
                    int firstNumber = Int32.Parse(Console.ReadLine()) -1;
                    Console.WriteLine("What is the second playlist you would like to combine? (Input number) ");
                    int secondNumber = Int32.Parse(Console.ReadLine()) -1;
                    var comboPlaylist = CombinePlaylists(playlists[firstNumber].Item2, playlists[secondNumber].Item2);
                    playlists.Add(comboPlaylist);
                    break;
                case 4:
                    i = 1;
                    foreach (var playlist in playlists)
                    {
                        Console.WriteLine($"{i}) {playlist.Item1}");
                        i++;
                    }

                    Console.WriteLine("Which playlist would you like to display? (Input number) ");
                    int displayNumber = Int32.Parse(Console.ReadLine()) -1;
                    DisplayPlaylist(playlists[displayNumber].Item2);
                    break;
                case 5:
                    Console.WriteLine("Have a good day!");
                    break;
            }

            Console.WriteLine();
        }
    }
    private static (string, HashSet<string>) MakePlaylist()
    {
        Console.Write("What would you like to name the playlist? ");
        string name = Console.ReadLine();
        var playlist = new HashSet<string>();
        return (name, playlist);
    }

    private static void AddSong(HashSet<string> playlist, string song)
    {
        if (!playlist.Contains(song)) playlist.Add(song);
        else
            Console.WriteLine($"{song} is already in the playlist");
    }

    private static (string, HashSet<string>) CombinePlaylists(HashSet<string> playlist1, HashSet<string> playlist2)
    {
        Console.Write("What would you like to name the playlist? ");
        string name = Console.ReadLine();
        var combinedPlaylist = new HashSet<string>();
        foreach (var song in playlist1)
            combinedPlaylist.Add(song);

        foreach (var song in playlist2)
            if (!combinedPlaylist.Contains(song))
                combinedPlaylist.Add(song);

        return (name, combinedPlaylist);
    }

    private static void DisplayPlaylist(HashSet<string> playlist)
    {
        foreach (var song in playlist)
            Console.WriteLine(song);
    }
}