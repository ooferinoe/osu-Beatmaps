namespace osu_BL
{
    public class EWF
    {
        public static void Ekoro()
        {
            BeatInfo Freeze = new BeatInfo();

            BeatMap diff1 = new BeatMap
            {
                title = "Normal",
                artist = "UNDEAD CORPORATION",
                mapper = "Ekoro",
                length = "03:13",
                BPM = "240",
                objects = "219",
                circles = "72",
                sliders = "147",
                spinners = "0",
                CS = "3",
                AR = "5",
                OD = "3.5",
                HP = "3",
                star = "1.98"
            };

            BeatMap diff2 = new BeatMap
            {
                title = "Hard",
                artist = "UNDEAD CORPORATION",
                mapper = "Ekoro",
                length = "03:13",
                BPM = "240",
                objects = "390",
                circles = "150",
                sliders = "240",
                spinners = "0",
                CS = "3.5",
                AR = "6.5",
                OD = "5",
                HP = "4",
                star = "2.72"
            };

            BeatMap diff3 = new BeatMap
            {
                title = "Insane",
                artist = "UNDEAD CORPORATION",
                mapper = "Ekoro",
                length = "03:13",
                BPM = "240",
                objects = "643",
                circles = "223",
                sliders = "420",
                spinners = "0",
                CS = "4",
                AR = "8.5",
                OD = "6.5",
                HP = "4.5",
                star = "4.15"
            };

            BeatMap diff4 = new BeatMap
            {
                title = "Lunatic",
                artist = "UNDEAD CORPORATION",
                mapper = "Ekoro",
                length = "03:13",
                BPM = "240",
                objects = "961",
                circles = "511",
                sliders = "450",
                spinners = "0",
                CS = "4",
                AR = "9",
                OD = "8",
                HP = "5",
                star = "5.81"
            };

            BeatMap diff5 = new BeatMap
            {
                title = "Extra",
                artist = "UNDEAD CORPORATION",
                mapper = "Ekoro",
                length = "03:13",
                BPM = "240",
                objects = "1370",
                circles = "957",
                sliders = "413",
                spinners = "0",
                CS = "4",
                AR = "9.5",
                OD = "8.7",
                HP = "5.5",
                star = "7.21"
            };

            BeatMap diff6 = new BeatMap
            {
                title = "Time Freeze",
                artist = "UNDEAD CORPORATION",
                mapper = "Ekoro",
                length = "03:13",
                BPM = "240",
                objects = "1590",
                circles = "1212",
                sliders = "378",
                spinners = "0",
                CS = "4",
                AR = "10",
                OD = "9.4",
                HP = "6",
                star = "8.11"
            };

            Freeze.DisplayDiffInfo(diff1);
            Freeze.DisplayDiffInfo(diff2);
            Freeze.DisplayDiffInfo(diff3);
            Freeze.DisplayDiffInfo(diff4);
            Freeze.DisplayDiffInfo(diff5);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}