using ozuDL;

namespace osu_BL
{
    public class Verify
    {
        public bool VerifyUser(string userName)
        {
            UserData data = new UserData();
            var result = data.GetUser(userName);

            return result.userName != null ? true : false;
        }

        public List<BeatMap> GetBeatMaps()
        {
            SongMap songMap = new SongMap();
            return songMap.GetBeatMaps();
        }
    }
}
