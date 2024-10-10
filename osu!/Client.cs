using ozuModel;
using ozuDL;
using osu_BL;
using osu_;
using MimeKit.Tnef;
using Microsoft.VisualBasic.FileIO;
using Org.BouncyCastle.Asn1.Tsp;

namespace osu_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*BeatMapGetServices getServices = new BeatMapGetServices();

            var song = getServices.GetAllBeatMaps();

            foreach (var item in song)
            {
                Console.WriteLine(item.title);
                Console.WriteLine(item.artist);
                Console.WriteLine();
            }*/
            WelcomePage();
        }

        static void WelcomePage()
        {
            UIOptions UIOpt = new UIOptions();

            while (true)
            {
                Console.WriteLine("""
                    ________________________________________
                                Welcome to osu!

                    Enter your action:
                    1. View existing beatmaps
                    2. Add a beatmap
                    3. Exit game

                    """);

                try
                {
                    int choice = Convert.ToInt16(Console.ReadLine());
                    string title = null, artist = null;

                    switch (choice)
                    {
                        case 1:
                            UIOpt.DisplaySong();
                            break;

                        case 2:
                            UIOpt.AddSong(title, artist);
                            WelcomePage();
                            break;

                        case 3:
                            Console.WriteLine("See you next time.");
                            return;
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid option. Please try again.");
                }
            }
        }
    }
}