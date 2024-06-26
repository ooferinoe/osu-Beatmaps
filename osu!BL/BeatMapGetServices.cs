using ozuDL;
using ozuModel;

namespace osu_BL
{
    public class BeatMapGetServices
    {
        public List<BeatMap> GetAllBeatMaps()
        {
            SongData songData = new SongData();

            return songData.GetBeatMaps();

        }

        public BeatMap GetBeatMaps(string title, string artist)
        {
            BeatMap foundSongMap = new BeatMap();

            foreach (var song in GetAllBeatMaps())
            {
                if (song.title == title && song.artist == artist)
                {
                    foundSongMap = song;
                }
            }

            return foundSongMap;
        }

        public BeatMap GetSongMap(string title)
        {
            BeatMap foundSongMap = new BeatMap();

            foreach (var song in GetAllBeatMaps())
            {
                if (song.title == title)
                {
                    foundSongMap = song;
                }
            }

            return foundSongMap;
        }
    }
}