namespace osu_BL
{
    public class BeatInfo
    {
        public void DisplayDiffInfo(BeatMap diff)
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