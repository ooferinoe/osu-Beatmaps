namespace osu_BL
{
    public class GPig
    {
        public static void Bridge()
        {
            BeatInfo Tech = new BeatInfo();

            BeatMap diff1 = new BeatMap
            {
                title = "Normal",
                artist = "Parry Gripp",
                mapper = "Sotarks",
                length = "00:39",
                BPM = "180",
                objects = "66",
                circles = "29",
                sliders = "36",
                spinners = "1",
                CS = "3",
                AR = "5",
                OD = "4",
                HP = "3",
                star = "2.28"
            };

            BeatMap diff2 = new BeatMap
            {
                title = "Hard",
                artist = "Parry Gripp",
                mapper = "Sotarks",
                length = "00:39",
                BPM = "180",
                objects = "101",
                circles = "45",
                sliders = "55",
                spinners = "1",
                CS = "3.5",
                AR = "7.5",
                OD = "6",
                HP = "4.5",
                star = "3.32"
            };

            BeatMap diff3 = new BeatMap
            {
                title = "Light Insane",
                artist = "Parry Gripp",
                mapper = "Sotarks",
                length = "00:39",
                BPM = "180",
                objects = "131",
                circles = "82",
                sliders = "48",
                spinners = "1",
                CS = "3.7   ",
                AR = "8.2",
                OD = "8",
                HP = "5",
                star = "4.09"
            };

            BeatMap diff4 = new BeatMap
            {
                title = "Insane",
                artist = "Parry Gripp",
                mapper = "Sotarks",
                length = "00:37",
                BPM = "180",
                objects = "138",
                circles = "86",
                sliders = "52",
                spinners = "0",
                CS = "3.8",
                AR = "9",
                OD = "8.5",
                HP = "5.5",
                star = "4.66"
            };

            BeatMap diff5 = new BeatMap
            {
                title = "Reform's Expert",
                artist = "Parry Gripp",
                mapper = "Reform",
                length = "00:37",
                BPM = "180",
                objects = "144",
                circles = "98",
                sliders = "46",
                spinners = "0",
                CS = "3.5",
                AR = "9",
                OD = "8.7",
                HP = "5.7",
                star = "5.14"
            };

            BeatMap diff6 = new BeatMap
            {
                title = "Guinea Pig Technology",
                artist = "Parry Gripp",
                mapper = "Sotarks",
                length = "00:37",
                BPM = "180",
                objects = "158",
                circles = "117",
                sliders = "41",
                spinners = "0",
                CS = "3.8",
                AR = "9.2",
                OD = "9.1",
                HP = "6.2",
                star = "5.63"
            };

            Tech.DisplayDiffInfo(diff1);
            Tech.DisplayDiffInfo(diff2);
            Tech.DisplayDiffInfo(diff3);
            Tech.DisplayDiffInfo(diff4);
            Tech.DisplayDiffInfo(diff5);
            Tech.DisplayDiffInfo(diff6);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}