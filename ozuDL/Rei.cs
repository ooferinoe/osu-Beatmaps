namespace osu_BL
{
    public class Rei
    {
        public static void Cig()
        {
            BeatInfo Jump = new BeatInfo();

            BeatMap diff1 = new BeatMap
            {
                title = "Akitoshi's Normal",
                artist = "THE ORAL CIGARETTES",
                mapper = "Akitoshi",
                length = "01:54",
                BPM = "128-186 (186)",
                objects = "182",
                circles = "61",
                sliders = "121",
                spinners = "0",
                CS = "3.2",
                AR = "5",
                OD = "4 ",
                HP = "4",
                star = "2.21"
            };

            BeatMap diff2 = new BeatMap
            {
                title = "Shunao's Hard",
                artist = "THE ORAL CIGARETTES",
                mapper = "Shunao",
                length = "01:54",
                BPM = "128-186 (186)",
                objects = "296",
                circles = "114",
                sliders = "182",
                spinners = "0",
                CS = "3.7",
                AR = "8",
                OD = "6",
                HP = "4.5",
                star = "3.59"
            };

            BeatMap diff3 = new BeatMap
            {
                title = "NiNo's Insane",
                artist = "THE ORAL CIGARETTES",
                mapper = "NiNo",
                length = "01:54",
                BPM = "128-186 (186)",
                objects = "399",
                circles = "246",
                sliders = "153",
                spinners = "0",
                CS = "4",
                AR = "9",
                OD = "8",
                HP = "5",
                star = "4.75"
            };

            BeatMap diff4 = new BeatMap
            {
                title = "Expert",
                artist = "THE ORAL CIGARETTES",
                mapper = "Sotarks",
                length = "01:54",
                BPM = "128-186 (186)",
                objects = "385",
                circles = "207",
                sliders = "178",
                spinners = "0",
                CS = "4",
                AR = "9.2",
                OD = "8.8",
                HP = "5",
                star = "5.39"
            };

            BeatMap diff5 = new BeatMap
            {
                title = "Nevo's Expert",
                artist = "THE ORAL CIGARETTES",
                mapper = "Nevo",
                length = "01:54",
                BPM = "128-186 (186)",
                objects = "468",
                circles = "354",
                sliders = "114",
                spinners = "0",
                CS = "3.8",
                AR = "9.3",
                OD = "9",
                HP = "5",
                star = "5.99"
            };

            BeatMap diff6 = new BeatMap
            {
                title = "A r M i N's Extra",
                artist = "THE ORAL CIGARETTES",
                mapper = "A r M i N",
                length = "01:54",
                BPM = "128-186 (186)",
                objects = "403",
                circles = "241",
                sliders = "162",
                spinners = "0",
                CS = "3.8",
                AR = "9.2",
                OD = "9",
                HP = "6",
                star = "6"
            };

            BeatMap diff7 = new BeatMap
            {
                title = "Mir's Extra",
                artist = "THE ORAL CIGARETTES",
                mapper = "Mir",
                length = "01:54",
                BPM = "128-186 (186)",
                objects = "493",
                circles = "411",
                sliders = "82",
                spinners = "0",
                CS = "4",
                AR = "9.3",
                OD = "9",
                HP = "5",
                star = "6.18"
            };

            BeatMap diff8 = new BeatMap
            {
                title = "Cataclysm",
                artist = "THE ORAL CIGARETTES",
                mapper = "Sotarks",
                length = "01:54",
                BPM = "128-186 (186)",
                objects = "421",
                circles = "270",
                sliders = "151",
                spinners = "0",
                CS = "4.2",
                AR = "9.4",
                OD = "9.1",
                HP = "5.2",
                star = "6.4"
            };

            Jump.DisplayDiffInfo(diff1);
            Jump.DisplayDiffInfo(diff2);
            Jump.DisplayDiffInfo(diff3);
            Jump.DisplayDiffInfo(diff4);
            Jump.DisplayDiffInfo(diff5);
            Jump.DisplayDiffInfo(diff6);
            Jump.DisplayDiffInfo(diff7);
            Jump.DisplayDiffInfo(diff8);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}