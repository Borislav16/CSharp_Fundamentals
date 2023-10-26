using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSong = int.Parse(Console.ReadLine());
            List<Song> playlist = new List<Song>();
            for (int i = 0; i < numberOfSong; i++)
            {
                string[] lineInput = Console.ReadLine().Split("_");
                string listType = lineInput[0];
                string songName = lineInput[1];
                string songTime = lineInput[2];

                Song song = new Song(listType, songName, songTime);
                playlist.Add(song);
            }
            string filter = Console.ReadLine();
            foreach (Song song in playlist)
            {
                if (song.TypeList == filter)
                {
                    Console.WriteLine(song.Name);
                }
                if(filter == "all")
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }

    public class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

        public Song()
        {

        }

        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
    }
}
