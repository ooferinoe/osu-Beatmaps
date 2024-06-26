namespace osu_BL
{
    public class BeatMapValidationServices
    {

        BeatMapGetServices getservices = new BeatMapGetServices();

        public bool CheckIfTitleExists(string title)
        {
            bool result = getservices.GetSongMap(title) != null;
            return result;
        }

        public bool CheckIfBeatMapExists(string username, string password)
        {
            bool result = getservices.GetBeatMaps(username, password) != null;
            return result;
        }

    }
}
