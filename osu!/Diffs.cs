using osu_BL;
using ozuDL;

namespace osu_
{
    public class Diffs
    {
        public static void Main(string[] args)
        {
            SongMap song = new SongMap();

            {
                Console.Write("Enter Username: ");
                string userName = Console.ReadLine();

                Verify userData = new Verify();
                bool result = userData.VerifyUser(userName);

                if (result)
                {
                    Verify beatData = new Verify();
                    List<BeatMap> beatList = beatData.GetBeatMaps();

                    Console.WriteLine("Welcome to the Beatmap selection!");
                    Console.WriteLine("This is an application that will display the selected Beatmap's highest difficulty");
                    while (true)
                    {

                        Console.WriteLine();
                        Console.WriteLine("Below is the list of available Beatmaps:");
                        Console.WriteLine("[1] Arkadia");
                        Console.WriteLine("[2] Disorder");
                        Console.WriteLine("[3] Everything will freeze");
                        Console.WriteLine("[4] FREEDOM DiVE");
                        Console.WriteLine("[5] Glory Days");
                        Console.WriteLine("[6] Guinea Pig Bridge");
                        Console.WriteLine("[7] ReI");
                        Console.WriteLine();
                        Console.Write("Please select a Beatmap: ");

                        int choices = Convert.ToInt32(Console.ReadLine());

                        switch (choices)
                        {
                            case 1:
                                Console.WriteLine("------------------------------");
                                DisplayDiffInfo(beatList[0]);
                                break;

                            case 2:
                                Console.WriteLine("------------------------------");
                                DisplayDiffInfo(beatList[1]);
                                break;

                            case 3:
                                Console.WriteLine("------------------------------");
                                DisplayDiffInfo(beatList[2]);
                                break;

                            case 4:
                                Console.WriteLine("------------------------------");
                                DisplayDiffInfo(beatList[3]);
                                break;

                            case 5:
                                Console.WriteLine("------------------------------");
                                DisplayDiffInfo(beatList[4]);
                                break;

                            case 6:
                                Console.WriteLine("------------------------------");
                                DisplayDiffInfo(beatList[5]);
                                break;

                            case 7:
                                Console.WriteLine("------------------------------");
                                DisplayDiffInfo(beatList[6]);
                                break;

                            default:
                                Console.WriteLine();
                                Console.WriteLine("Invalid choice!");
                                Console.WriteLine("------------------------------");
                                break;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("User not found.");
                    return;
                }
            }
        }
        private static void DisplayDiffInfo(BeatMap diff)
        {
            Console.WriteLine();
            Console.WriteLine("Difficulty Name: " + diff.title);
            Console.WriteLine("Artist: " + diff.artist);
            Console.WriteLine("Mapper: " + diff.mapper);
            Console.WriteLine("Length: " + diff.length);
            Console.WriteLine("BPM: " + diff.BPM);
            Console.WriteLine("Objects: " + diff.objects);
            Console.WriteLine("Circles: " + diff.circles);
            Console.WriteLine("Sliders: " + diff.sliders);
            Console.WriteLine("Spinners: " + diff.spinners);
            Console.WriteLine("CS: " + diff.CS);
            Console.WriteLine("AR: " + diff.AR);
            Console.WriteLine("OD: " + diff.OD);
            Console.WriteLine("HP: " + diff.HP);
            Console.WriteLine("Star Rating: " + diff.star);
            Console.WriteLine();
            Console.WriteLine("------------------------------");
        }
    }
}
