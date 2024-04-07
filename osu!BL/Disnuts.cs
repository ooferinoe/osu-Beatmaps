namespace osu_BL
{
    public class Disnuts
    {
        public static void Speed()
        {
            BeatInfo Fast = new BeatInfo();

            BeatMap diff1 = new BeatMap
            {
                title = "Easy",
                artist = "HyuN ft. YURI",
                mapper = "eiri-",
                length = "02:08",
                BPM = "193",
                objects = "202",
                circles = "102",
                sliders = "100",
                spinners = "0",
                CS = "2.5",
                AR = "5",
                OD = "4",
                HP = "3",
                star = "2.08"
            };

            BeatMap diff2 = new BeatMap
            {
                title = "Normal",
                artist = "HyuN ft. YURI",
                mapper = "eiri-",
                length = "02:09",
                BPM = "193",
                objects = "332",
                circles = "164",
                sliders = "168",
                spinners = "0",
                CS = "3",
                AR = "6",
                OD = "5",
                HP = "4",
                star = "2.53"
            };

            BeatMap diff3 = new BeatMap
            {
                title = "Skytuna's Hard",
                artist = "HyuN ft. YURI",
                mapper = "Skytuna",
                length = "02:07",
                BPM = "193",
                objects = "377",
                circles = "164",
                sliders = "211",
                spinners = "2",
                CS = "3.5",
                AR = "8",
                OD = "7",
                HP = "4.5",
                star = "3.91"
            };

            BeatMap diff4 = new BeatMap
            {
                title = "Plaudible's Insane",
                artist = "HyuN ft. YURI",
                mapper = "Plaudible",
                length = "02:08",
                BPM = "193",
                objects = "478",
                circles = "254",
                sliders = "224",
                spinners = "0",
                CS = "4",
                AR = "9",
                OD = "8",
                HP = "5",
                star = "4.96"
            };

            BeatMap diff5 = new BeatMap
            {
                title = "Sylas' Expert",
                artist = "HyuN ft. YURI",
                mapper = "Sylas",
                length = "02:09",
                BPM = "193",
                objects = "662",
                circles = "428",
                sliders = "232",
                spinners = "2",
                CS = "3.8",
                AR = "9.3",
                OD = "8.4",
                HP = "5",
                star = "5.96"
            };

            BeatMap diff6 = new BeatMap
            {
                title = "Acyl's Extra",
                artist = "HyuN ft. YURI",
                mapper = "Acyl",
                length = "02:09",
                BPM = "193",
                objects = "709",
                circles = "354",
                sliders = "353",
                spinners = "2",
                CS = "2.7",
                AR = "9.5",
                OD = "8.7",
                HP = "5",
                star = "6.26"
            };

            BeatMap diff7 = new BeatMap
            {
                title = "Eternity",
                artist = "HyuN ft. YURI",
                mapper = "eiri-",
                length = "02:09",
                BPM = "193",
                objects = "713",
                circles = "451  ",
                sliders = "262",
                spinners = "0",
                CS = "4.5",
                AR = "9.7",
                OD = "9",
                HP = "6",
                star = "7.2"
            };

            Fast.DisplayDiffInfo(diff1);
            Fast.DisplayDiffInfo(diff2);
            Fast.DisplayDiffInfo(diff3);
            Fast.DisplayDiffInfo(diff4);
            Fast.DisplayDiffInfo(diff5);
            Fast.DisplayDiffInfo(diff6);
            Fast.DisplayDiffInfo(diff7);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}