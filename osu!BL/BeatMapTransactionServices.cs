    using ozuDL;
using ozuModel;

namespace osu_BL
{
    public class BeatMapTransactionServices
    {
        BeatMapValidationServices validationServices = new BeatMapValidationServices();
        SongData songData = new SongData();

        public bool CreateBeatMap(BeatMap song)
        {
            bool result = false;

            if (validationServices.CheckIfTitleExists(song.title))
            {
                result = songData.AddSongMap(song) > 0;
            }

            return result;
        }

        public bool CreateBeatMap(string title, string artist)
        {
            BeatMap song = new BeatMap { title = title, artist = artist };

            return CreateBeatMap(song);
        }

        public bool UpdateSongMap(BeatMap song)
        {
            bool result = false;

            if (validationServices.CheckIfTitleExists(song.title))
            {
                result = songData.UpdateSongMap(song) > 0;
            }

            return result;
        }

        public bool UpdateSongMap(string title, string artist)
        {
            BeatMap song = new BeatMap { title = title, artist = artist };

            return UpdateSongMap(song);
        }

        public bool DeleteSongMap(BeatMap song)
        {   
            bool result = false;

            if (validationServices.CheckIfTitleExists(song.title))
            {
                result = songData.DeleteSongMap(song) > 0;
            }

            return result;
        }
    }
}