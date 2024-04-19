using osu_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ozuDL
{
    public class SongMap
    {
        List<BeatMap> maps = new List<BeatMap>();

        public SongMap()
        {
            SongMaps();
        }

        public void SongMaps()
        {
            BeatMap arkadia = new BeatMap()
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

            BeatMap disorder = new BeatMap()
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


            BeatMap EWF = new BeatMap()
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


            BeatMap freedomDive = new BeatMap()
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


            BeatMap gloryDays = new BeatMap()
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


            BeatMap GPB = new BeatMap()
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


            BeatMap rei = new BeatMap()
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
            maps.Add(arkadia);
            maps.Add(disorder);
            maps.Add(EWF);
            maps.Add(freedomDive);
            maps.Add(gloryDays);
            maps.Add(GPB);
            maps.Add(rei);

        }
        public List<BeatMap> GetBeatMaps()
        {
            return maps;
        }
    }
}
