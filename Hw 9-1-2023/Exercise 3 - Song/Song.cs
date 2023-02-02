namespace Exercise_3___Song
{
    internal class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public Song() {}

        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Number of songs:");
            int numOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < numOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split("_");
                Song song = new Song(input[0], input[1], input[2]);
                songs.Add(song);
            }
            Console.WriteLine("Enter type:");
            string type = Console.ReadLine();
            if (type == "all")
            {
                foreach (Song s in songs) Console.WriteLine(s.Name);
            }
            else
            {
                foreach (Song s in songs)
                {
                 if (s.Name == type) Console.WriteLine(s.Name);    
                }
            }
        }
    }
}