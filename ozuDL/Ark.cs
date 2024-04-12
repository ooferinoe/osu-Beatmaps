namespace osu_BL
{
    public class Ark
    {
        public static void BabyMetal()
        {
            BeatInfo Stream = new BeatInfo();

            BeatMap diff1 = new BeatMap
            {
                title = "Collab Expert",
                artist = "BABYMETAL",
                mapper = "ItsWinter et. al.",
                length = "05:11",
                BPM = "50-220 (200)",
                objects = "1389",
                circles = "831",
                sliders = "557",
                spinners = "1",
                CS = "4",
                AR = "9.2",
                OD = "8.8",
                HP = "4",
                star = "5.29"
            };

            BeatMap diff2 = new BeatMap
            {
                title = "kerupt's Extreme",
                artist = "BABYMETAL",
                mapper = "kerupt",
                length = "05:03",
                BPM = "50-220 (200)",
                objects = "2051",
                circles = "1566",
                sliders = "485",
                spinners = "0",
                CS = "4",
                AR = "9.6",
                OD = "9.3",
                HP = "5",
                star = "6.88"
            };

            BeatMap diff3 = new BeatMap
            {
                title = "Extreme",
                artist = "BABYMETAL",
                mapper = "ItsWinter",
                length = "05:11",
                BPM = "50-220 (200)",
                objects = "2285",
                circles = "1941",
                sliders = "343",
                spinners = "1",
                CS = "4",
                AR = "9.7",
                OD = "9.5",
                HP = "5",
                star = "7.63"
            };

            BeatMap diff4 = new BeatMap
            {
                title = "Aratashii Mirai",
                artist = "BABYMETAL",
                mapper = "ItsWinter",
                length = "05:11",
                BPM = "50-220 (200)",
                objects = "2185",
                circles = "1748",
                sliders = "435",
                spinners = "2",
                CS = "4.3",
                AR = "9.8",
                OD = "9.6",
                HP = "5",
                star = "7.74"
            };

            Stream.DisplayDiffInfo(diff1);
            Stream.DisplayDiffInfo(diff2);
            Stream.DisplayDiffInfo(diff3);
            Stream.DisplayDiffInfo(diff4);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}