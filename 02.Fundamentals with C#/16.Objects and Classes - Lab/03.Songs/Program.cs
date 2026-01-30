namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> playlist = new List<Song>();

            for (int i = 1; i <= n; i++)
            {
                string[] songTokens = Console.ReadLine().Split("_");
                Song song = new Song();
                song.TypeList = songTokens[0];
                song.Time = songTokens[1];
                song.Name = songTokens[1];

                playlist.Add(song);
            }

            string playlistToPint = Console.ReadLine();

            if (playlistToPint == "all")
            {
                foreach (var song in playlist)
                {
                    Console.WriteLine(song.Name);
                }
                return;
            }

            foreach (Song song in playlist)
            {
                if (song.TypeList == playlistToPint)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }

    class Song 
    {
        public string TypeList {  get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
