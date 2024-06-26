using ozuModel;

namespace ozuDL
{
    public class SongData
    {
        List<BeatMap> song;
        SqlDbData sqlData;
        public SongData()
        {
            song = new List<BeatMap>();
            sqlData = new SqlDbData();

            //UserFactory _userFactory = new UserFactory();
            //users = _userFactory.GetDummyUsers();
        }

        public List<BeatMap> GetBeatMaps()
        {
            song = sqlData.GetBeatMaps();
            return song;
        }

        public int AddSongMap(BeatMap song)
        {
            return sqlData.AddSongMap(song.title, song.artist);
        }

        public int UpdateSongMap(BeatMap song)
        {
            return sqlData.UpdateSongMap(song.title, song.artist);
        }

        public int DeleteSongMap(BeatMap song)
        {
            return sqlData.DeleteSongMap(song.title);
        }
    }
}
