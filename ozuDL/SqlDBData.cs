using ozuModel;
using System.Data.SqlClient;

namespace ozuDL
{
    public class SqlDbData
    {

        string connectionString
            = "Server = tcp:20.2.38.141,1433; Database = osu!; User Id = sa; Password = integ2!";
        // = "Data Source =DESKTOP-7NDQCQL; Initial Catalog = osu!; Integrated Security = True;";

        SqlConnection sqlConnection;

        public SqlDbData()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<BeatMap> GetBeatMaps()
        {
            string selectStatement = "SELECT title, artist FROM song";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            List<BeatMap> song = new List<BeatMap>();

            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                string title = reader["title"].ToString();
                string artist = reader["artist"].ToString();

                BeatMap readSong = new BeatMap();
                readSong.title = title;
                readSong.artist = artist;

                song.Add(readSong);
            }

            sqlConnection.Close();

            return song;
        }

        public int AddSongMap(string title, string artist)
        {
            int success;

            string insertStatement = "INSERT INTO song VALUES (@title, @artist)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@title", title);
            insertCommand.Parameters.AddWithValue("@artist", artist);
            sqlConnection.Open();

            success = insertCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        public int UpdateSongMap(string title, string artist)
        {
            int success;

            string updateStatement = $"UPDATE song SET title = @title WHERE artist = @artist";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
            sqlConnection.Open();

            updateCommand.Parameters.AddWithValue("@title", title);
            updateCommand.Parameters.AddWithValue("@artist", artist);

            success = updateCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        public int DeleteSongMap(string title)
        {
            int success;

            string deleteStatement = $"DELETE FROM song WHERE title = @title";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            sqlConnection.Open();

            deleteCommand.Parameters.AddWithValue("@title", title);

            success = deleteCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }
    }
}