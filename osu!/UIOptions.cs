using osu_BL;
using ozuDL;
using ozuModel;

namespace osu_
{
    public class UIOptions
    {
        BeatMapTransactionServices BMTS = new BeatMapTransactionServices();
        EmailServices ES = new EmailServices();

        public void AddSong(string title, string artist)
        {
            Console.WriteLine("""
                      Add a beatmap
                _________________________
                """);

            Console.WriteLine("BeatMap Title: ");
            title = Console.ReadLine();
            Console.WriteLine("BeatMap Artist: ");
            artist = Console.ReadLine();

            BMTS.CreateBeatMap(title, artist);

            ES.emailNewSong(title, artist);
        }

        public void DisplaySong()
        {
            Console.WriteLine("""
                    These are the current beatmaps and their artist
                ______________________________________________________
                """);

            foreach(var song in BMTS.GetBeatMap())
            {
                Console.WriteLine("title: " + song.title);
                Console.WriteLine("by: " + song.artist);
                Console.WriteLine();
            }
        }
    }
}
