using osu_BL;

namespace osu_
{
    public class Diffs
    {

        public static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome to the Beatmap selection!");
            while (true)
            {

                Console.WriteLine();
                Console.WriteLine("Below is a list of Beatmaps:");
                Console.WriteLine("1. FREEDOM DiVE");
                Console.WriteLine("2. Everything will freeze");
                Console.WriteLine("3. Arkadia");
                Console.WriteLine("4. ReI");
                Console.WriteLine("5. Guinea Pig Bridge");
                Console.WriteLine("6. Glory Days");
                Console.WriteLine("7. Disorder");
                Console.WriteLine();
                Console.Write("Please select a Beatmap: ");

                string choices = Console.ReadLine();

                switch (choices)
                {
                    case "1":
                        {
                            Console.WriteLine("------------------------------");
                            FDive.Rainbow();
                            break;
                        }

                    case "2":
                        {
                            Console.WriteLine("------------------------------");
                            EWF.Ekoro();
                            break;
                        }

                    case "3":
                        {
                            Console.WriteLine("------------------------------");
                            Ark.BabyMetal();
                            break;
                        }

                    case "4":
                        {
                            Console.WriteLine("------------------------------");
                            Rei.Cig();
                            break;
                        }

                    case "5":
                        {
                            Console.WriteLine("------------------------------");
                            GPig.Bridge();
                            break;
                        }

                    case "6":
                        {
                            Console.WriteLine("------------------------------");
                            Days.Stamina();
                            break;
                        }

                    case "7":
                        {
                            Console.WriteLine("------------------------------");
                            Disnuts.Speed();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid choice!");
                            Console.WriteLine("------------------------------");
                            break;
                            return;
                        }
                }




            }
        }
    }
}