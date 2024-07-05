using ozuModel;
using ozuDL;
using osu_BL;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeatMapGetServices getServices = new BeatMapGetServices();

            var song = getServices.GetAllBeatMaps();

            foreach (var item in song)
            {
                Console.WriteLine(item.title);
                Console.WriteLine(item.artist);
                Console.WriteLine();
            }

        }
    }
}