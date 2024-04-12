namespace osu_BL
{
    public class Days
    {
        public static void Stamina()
        {
            BeatInfo Dedge = new BeatInfo();

            BeatMap diff1 = new BeatMap
            {
                title = "Astronic's Insane",
                artist = "Fellowship",
                mapper = "Astronic",
                length = "04:49",
                BPM = "178",
                objects = "1207",
                circles = "785",
                sliders = "421",
                spinners = "1",
                CS = "3.6",
                AR = "9",
                OD = "8.4",
                HP = "5",
                star = "4.97"
            };

            BeatMap diff2 = new BeatMap
            {
                title = "Maki's Extra",
                artist = "Fellowship",
                mapper = "Maki",
                length = "04:49",
                BPM = "178",
                objects = "1676",
                circles = "1287",
                sliders = "388",
                spinners = "1",
                CS = "4",
                AR = "9.3",
                OD = "9",
                HP = "5.6",
                star = "6.02"
            };

            BeatMap diff3 = new BeatMap
            {
                title = "AnedeuwuAAa's Extreme Collab",
                artist = "Fellowship",
                mapper = "nebuwua, AnedeuwuAAa, etc.",
                length = "04:49",
                BPM = "178",
                objects = "1989",
                circles = "1718",
                sliders = "270",
                spinners = "1",
                CS = "4.1",
                AR = "9.6",
                OD = "9.4",
                HP = "4.3",
                star = "6.86"
            };

            BeatMap diff4 = new BeatMap
            {
                title = "Relentless Heartache",
                artist = "Fellowship",
                mapper = "nebuwua",
                length = "04:49",
                BPM = "178",
                objects = "2113",
                circles = "1842",
                sliders = "270",
                spinners = "1",
                CS = "4.3",
                AR = "9.7",
                OD = "9.5",
                HP = "5.2",
                star = "7.38"
            };

            Dedge.DisplayDiffInfo(diff1);
            Dedge.DisplayDiffInfo(diff2);
            Dedge.DisplayDiffInfo(diff3);
            Dedge.DisplayDiffInfo(diff4);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}