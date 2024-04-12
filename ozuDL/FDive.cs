namespace osu_BL
{
    public class FDive
    {
        public static void Rainbow()
        {
            BeatInfo FreedomDive = new BeatInfo();

            BeatMap diff1 = new BeatMap
            {
                title = "Insane",
                artist = "xi",
                mapper = "FrenZ396",
                length = "04:21",
                BPM = "222",
                objects = "968",
                circles = "424",
                sliders = "542",
                spinners = "2",
                CS = "4",
                AR = "9",
                OD = "8",
                HP = "4.5",
                star = "5.18",
            };

            BeatMap diff2 = new BeatMap
            {
                title = "Extra",
                artist = "xi",
                mapper = "FrenzZ96",
                length = "04:21",
                BPM = "222",
                objects = "1303",
                circles = "775",
                sliders = "526",
                spinners = "2",
                CS = "4",
                AR = "9.3",
                OD = "8.8",
                HP = "5",
                star = "6.42"
            };
            BeatMap diff3 = new BeatMap
            {
                title = "Extreme",
                artist = "xi",
                mapper = "FrenZ396",
                length = "04:21",
                BPM = "222",
                objects = "1579",
                circles = "1084",
                sliders = "493",
                spinners = "2",
                CS = "4",
                AR = "9.6",
                OD = "9.2",
                HP = "5.5",
                star = "7.36"
            };

            BeatMap diff4 = new BeatMap
            {
                title = "ENDLESS DiMENSiONS",
                artist = "xi",
                mapper = "FrenZ396",
                length = "04:21",
                BPM = "222",
                objects = "2009",
                circles = "1553",
                sliders = "454",
                spinners = "2",
                CS = "4",
                AR = "9.8",
                OD = "9.6",
                HP = "6",
                star = "7.98"
            };

            FreedomDive.DisplayDiffInfo(diff1);
            FreedomDive.DisplayDiffInfo(diff2);
            FreedomDive.DisplayDiffInfo(diff3);
            FreedomDive.DisplayDiffInfo(diff4);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}