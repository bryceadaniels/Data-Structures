using final_project_bryceadaniels.Tree_Solution;
using System.Collections;
var songDictionary = new Dictionary<int, (string,string)>();

var song1 = 1234;
var song2 = 8520;
var song3 = 7896;
var song4 = 456;
var song5 = 9510;
var song6 = 6384;
var song7 = 654;
var song8 = 753;
songDictionary.Add(song1,("Song A","Artist S"));
songDictionary.Add(song2,("Song B","Artist T"));
songDictionary.Add(song3,("Song C","Artist U"));
songDictionary.Add(song4,("Song D","Artist V"));
songDictionary.Add(song5,("Song E", "Artist W"));
songDictionary.Add(song6,("Song F", "Artist X"));
songDictionary.Add(song7,("Song G", "Artist Y"));
songDictionary.Add(song8,("Song H", "Artist Z"));

var unsortedSongs = new List<int>();

unsortedSongs.Add(song1);
unsortedSongs.Add(song2);
unsortedSongs.Add(song3);
unsortedSongs.Add(song4);
unsortedSongs.Add(song5);
unsortedSongs.Add(song6);
unsortedSongs.Add(song7);
unsortedSongs.Add(song8);


BinarySearchTree songTree = new BinarySearchTree();
foreach(var song in unsortedSongs) songTree.Insert(song);

Console.WriteLine("Songs in Order of Most Listens");
var i = 1;
foreach (int song in songTree.Reverse())
{
    Console.WriteLine($"{i}) {songDictionary[song].Item1} by {songDictionary[song].Item2} with {song} listens");
    i++;
}